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
using ClosedXML.Excel;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class CompletedReservationsForm : UserControl
    {
        private MySqlConnection connection;

        public CompletedReservationsForm()
        {
            InitializeComponent();
        }

        //USER CONTROL PANEL NAVIGATION
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //NAVIGATE TO APPROVED RESERVATIONS
        private void approvedReservation_btn_Click(object sender, EventArgs e)
        {
            ApprovedReservationsForm approvedRes = new ApprovedReservationsForm();
            addUserControl(approvedRes);
        }

        //NAVIGATE TO PENDING RESERVATIONS
        private void pendingReservation_btn_Click(object sender, EventArgs e)
        {
            ReservationsForm pendingRes = new ReservationsForm();
            addUserControl(pendingRes);
        }

        //FORM LOAD
        private void CompletedReservationsForm_Load(object sender, EventArgs e)
        {
            connection = DatabaseManager.GetConnection();
            connection.Open();
            LoadData();
            PopulateServiceComboBox();
        }

        //RETRIEVING OF RESERVATION WITH STATUS OF COMPLETE
        private void LoadData()
        {
            try
            {
                string query = "SELECT r.reservation_id, r.problem_description, r.date, r.time, " +
                               "CONCAT(c.firstName, ' ', c.lastName) AS customerName, " +
                               "s.serviceType AS serviceType, " +
                               "CONCAT(v.make, ' ', v.model, ' ', v.year) AS vehicleName " +
                               "FROM reservations r " +
                               "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                               "INNER JOIN services s ON r.service_id = s.service_id " +
                               "INNER JOIN customer_vehicles v ON r.vehicle_id = v.vehicle_id " +
                               "WHERE r.status = 'Completed'";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    completedDataGrid.RowTemplate.Height = 50;
                    dataAdapter.Fill(dataTable);
                    completedDataGrid.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //FILTER FUNCTION BY SERVICES
        private void servicesComboBox_SelectedIndex(object sender, EventArgs e)
        {
            try
            {
                if (filter_cmbx.Focused)
                {
                    string selectedService = filter_cmbx.SelectedItem?.ToString();

                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string selectQuery = "SELECT r.reservation_id, r.problem_description, r.date, r.time, " +
                                             "CONCAT(c.firstName, ' ', c.lastName) AS customerName, " +
                                             "s.serviceType AS serviceType, " +
                                             "CONCAT(v.make, ' ', v.model, ' ', v.year) AS vehicleName " +
                                             "FROM reservations r " +
                                             "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                             "INNER JOIN services s ON r.service_id = s.service_id " +
                                             "INNER JOIN customer_vehicles v ON r.vehicle_id = v.vehicle_id " +
                                             "WHERE r.status = 'Pending'";

                        if (!string.IsNullOrEmpty(selectedService))
                        {
                            selectQuery += " AND s.serviceType = @selectedService";
                        }

                        using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                        {
                            if (!string.IsNullOrEmpty(selectedService))
                            {
                                cmd.Parameters.AddWithValue("@selectedService", selectedService);
                            }

                            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable filteredDataTable = new DataTable();
                                dataAdapter.Fill(filteredDataTable);

                                completedDataGrid.DataSource = filteredDataTable;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //REFRESH BUTTON / SHOW ALL
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //POPULATE THE COMBOBOX FOR FILTERING
        private void PopulateServiceComboBox()
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

                            filter_cmbx.DataSource = serviceOptions;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void exportExcel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)completedDataGrid.DataSource;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "CompletedReservationsExport";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            // Add the DataTable to the worksheet
                            IXLWorksheet worksheet = workbook.Worksheets.Add(dataTable, "CompletedReservations");

                            // Adjust column widths (you may need to customize these values)
                            worksheet.Columns().AdjustToContents();

                            // Save the workbook to the selected file
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
    }
}
