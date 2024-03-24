using CadizAutoShopManagementSystem.Components;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class LocalServiceRecordsReportsForm : UserControl
    {
        private LoadingStateForm loadingForm;

        public LocalServiceRecordsReportsForm()
        {
            ShowLoadingForm();
            InitializeComponent();
            PopulateLocalServiceRecords();
            PopulateMechanicComboBox();
            PopulateServicesComboBox();
            LoadStatusFilter();
            CloseLoadingForm();
        }

        private void ShowLoadingForm()
        {
            loadingForm = new LoadingStateForm();
            loadingForm.StartPosition = FormStartPosition.CenterScreen;
            loadingForm.TopMost = true;
            loadingForm.Show();
            Application.DoEvents();
        }

        private void CloseLoadingForm()
        {
            loadingForm.Close();
        }

        private void LoadStatusFilter()
        {
            status_cmbx.Items.Clear();

            status_cmbx.Items.Add("Pending");
            status_cmbx.Items.Add("On-Progress");
            status_cmbx.Items.Add("Done");
            status_cmbx.Items.Add("Completed");
            status_cmbx.SelectedIndex = 0;
        }

        private void PopulateServicesComboBox()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT serviceType FROM services";
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<string> serviceOptions = new List<string>();

                            while (reader.Read())
                            {
                                string serviceType = reader["serviceType"].ToString();
                                serviceOptions.Add(serviceType);
                            }

                            filterByServiceType_cmbx.DataSource = serviceOptions;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PopulateMechanicComboBox()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT mechanic_id, CONCAT(firstName, ' ', lastName) AS mechanicName, CONCAT ('(', specialization, ')') AS mechanicSpecialization FROM mechanic_info";

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<string> mechanicOptions = new List<string>();

                            while (reader.Read())
                            {
                                int mechanicId = Convert.ToInt32(reader["mechanic_id"]);
                                string mechanicName = reader["mechanicName"].ToString();
                                string mechanicSpecizalization = reader["mechanicSpecialization"].ToString();

                                mechanicOptions.Add(mechanicName + ' ' + mechanicSpecizalization);

                                filterByMechanic_cmbx.Tag = mechanicId;
                            }

                            filterByMechanic_cmbx.DataSource = mechanicOptions;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PopulateLocalServiceRecords()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            ls.localService_id, 
                            CONCAT(ci.firstName, ' ', ci.middleName, ' ', ci.lastName) AS customerInfo,
                            ci.contactNumber, 
                            CONCAT(cv.make, ' ', cv.model, ' (', cv.year, ')') AS vehicleInfo, 
                            s.serviceType, 
                            CONCAT(m.firstName, ' ', m.lastName, ' (', m.specialization, ')') AS mechanicInfo,
                            ls.problem_description,
                            ls.created_at,
                            ls.status
                        FROM 
                            local_service ls
                        INNER JOIN 
                            customer_info ci ON ls.customer_id = ci.customer_id
                        INNER JOIN 
                            services s ON ls.service_id = s.service_id
                        INNER JOIN 
                            customer_vehicles cv ON ls.vehicle_id = cv.vehicle_id
                        INNER JOIN 
                            mechanic_info m ON ls.assigned_mechanic = m.mechanic_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        DataTable localServiceRecordsTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(localServiceRecordsTable);
                        }

                        localServiceRecordsDataGridView.DataSource = localServiceRecordsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving local service records: " + ex.Message);
            }
        }

        private void filterByMechanic_cmbx_SelectedIndexChange(object sender, EventArgs e)
        {
            try
            {
                if (filterByMechanic_cmbx.Focused)
                {
                    string selectedMechanic = filterByMechanic_cmbx.SelectedItem?.ToString();

                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string query = @"
                    SELECT 
                        ls.localService_id, 
                        CONCAT(ci.firstName, ' ', ci.middleName, ' ', ci.lastName) AS customerInfo,
                        ci.contactNumber, 
                        CONCAT(cv.make, ' ', cv.model, ' (', cv.year, ')') AS vehicleInfo, 
                        s.serviceType, 
                        CONCAT(m.firstName, ' ', m.lastName, ' (', m.specialization, ')') AS mechanicInfo,
                        ls.problem_description,
                        ls.created_at,
                        ls.status
                    FROM 
                        local_service ls
                    INNER JOIN 
                        customer_info ci ON ls.customer_id = ci.customer_id
                    INNER JOIN 
                        services s ON ls.service_id = s.service_id
                    INNER JOIN 
                        customer_vehicles cv ON ls.vehicle_id = cv.vehicle_id
                    INNER JOIN 
                        mechanic_info m ON ls.assigned_mechanic = m.mechanic_id
                    WHERE 
                        CONCAT(m.firstName, ' ', m.lastName, ' (', m.specialization, ')') = @selectedMechanic";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@selectedMechanic", selectedMechanic);

                            DataTable localServiceRecordsTable = new DataTable();
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                adapter.Fill(localServiceRecordsTable);
                            }

                            localServiceRecordsDataGridView.DataSource = localServiceRecordsTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering local service records by mechanic: " + ex.Message);
            }
        }

        private void filterByService_cmbx_SelectedIndexChange(object sender, EventArgs e)
        {
            try
            {
                if (filterByServiceType_cmbx.Focused)
                {
                    string selectedService = filterByServiceType_cmbx.SelectedItem?.ToString();

                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string query = @"
                    SELECT 
                        ls.localService_id, 
                        CONCAT(ci.firstName, ' ', ci.middleName, ' ', ci.lastName) AS customerInfo,
                        ci.contactNumber, 
                        CONCAT(cv.make, ' ', cv.model, ' (', cv.year, ')') AS vehicleInfo, 
                        s.serviceType, 
                        CONCAT(m.firstName, ' ', m.lastName, ' (', m.specialization, ')') AS mechanicInfo,
                        ls.problem_description,
                        ls.created_at,
                        ls.status
                    FROM 
                        local_service ls
                    INNER JOIN 
                        customer_info ci ON ls.customer_id = ci.customer_id
                    INNER JOIN 
                        services s ON ls.service_id = s.service_id
                    INNER JOIN 
                        customer_vehicles cv ON ls.vehicle_id = cv.vehicle_id
                    INNER JOIN 
                        mechanic_info m ON ls.assigned_mechanic = m.mechanic_id
                    WHERE 
                        s.serviceType = @selectedService";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@selectedService", selectedService);

                            DataTable localServiceRecordsTable = new DataTable();
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                adapter.Fill(localServiceRecordsTable);
                            }

                            localServiceRecordsDataGridView.DataSource = localServiceRecordsTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering local service records by service: " + ex.Message);
            }
        }

        private void FilterLocalServiceRecordsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    ls.localService_id, 
                    CONCAT(ci.firstName, ' ', ci.middleName, ' ', ci.lastName) AS customerInfo,
                    ci.contactNumber, 
                    CONCAT(cv.make, ' ', cv.model, ' (', cv.year, ')') AS vehicleInfo, 
                    s.serviceType, 
                    CONCAT(m.firstName, ' ', m.lastName, ' (', m.specialization, ')') AS mechanicInfo,
                    ls.problem_description,
                    ls.created_at,
                    ls.status
                FROM 
                    local_service ls
                INNER JOIN 
                    customer_info ci ON ls.customer_id = ci.customer_id
                INNER JOIN 
                    services s ON ls.service_id = s.service_id
                INNER JOIN 
                    customer_vehicles cv ON ls.vehicle_id = cv.vehicle_id
                INNER JOIN 
                    mechanic_info m ON ls.assigned_mechanic = m.mechanic_id
                WHERE 
                    ls.created_at BETWEEN @startDate AND @endDate";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                        cmd.Parameters.AddWithValue("@endDate", endDate.Date.AddDays(1).AddSeconds(-1));

                        DataTable filteredLocalServiceRecordsTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(filteredLocalServiceRecordsTable);
                        }

                        localServiceRecordsDataGridView.DataSource = filteredLocalServiceRecordsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering local service records by date range: " + ex.Message);
            }
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            PopulateLocalServiceRecords();
        }

        private void filterDate_btn_Click(object sender, EventArgs e)
        {
            DateTime startDate = start_DatePicker.Value.Date;
            DateTime endDate = end_DatePicker.Value.Date;

            FilterLocalServiceRecordsByDateRange(startDate, endDate);
        }

        private void FilterLocalServiceRecordsByStatus(string selectedStatus)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    ls.localService_id, 
                    CONCAT(ci.firstName, ' ', ci.middleName, ' ', ci.lastName) AS customerInfo,
                    ci.contactNumber, 
                    CONCAT(cv.make, ' ', cv.model, ' (', cv.year, ')') AS vehicleInfo, 
                    s.serviceType, 
                    CONCAT(m.firstName, ' ', m.lastName, ' (', m.specialization, ')') AS mechanicInfo,
                    ls.problem_description,
                    ls.created_at,
                    ls.status
                FROM 
                    local_service ls
                INNER JOIN 
                    customer_info ci ON ls.customer_id = ci.customer_id
                INNER JOIN 
                    services s ON ls.service_id = s.service_id
                INNER JOIN 
                    customer_vehicles cv ON ls.vehicle_id = cv.vehicle_id
                INNER JOIN 
                    mechanic_info m ON ls.assigned_mechanic = m.mechanic_id
                WHERE 
                    ls.status = @selectedStatus";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@selectedStatus", selectedStatus);

                        DataTable filteredLocalServiceRecordsTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(filteredLocalServiceRecordsTable);
                        }

                        localServiceRecordsDataGridView.DataSource = filteredLocalServiceRecordsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering local service records by status: " + ex.Message);
            }
        }

        private void exportExcel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)localServiceRecordsDataGridView.DataSource;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "Local Service Records";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            IXLWorksheet worksheet = workbook.Worksheets.Add(dataTable, "Local Service Records");

                            worksheet.Columns().AdjustToContents();

                            workbook.SaveAs(saveFileDialog.FileName);

                            MessageBox.Show("Data exported to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void status_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedStatus = status_cmbx.SelectedItem?.ToString();
                FilterLocalServiceRecordsByStatus(selectedStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering local service records by status: " + ex.Message);
            }
        }
    }
}
