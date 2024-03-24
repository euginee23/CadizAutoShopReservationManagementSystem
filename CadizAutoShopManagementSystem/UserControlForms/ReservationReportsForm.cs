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
    public partial class ReservationReportsForm : UserControl
    {
        public ReservationReportsForm()
        {
            InitializeComponent();
            PopulateReservations();
            PopulateMechanicComboBox();
            PopulateStatusComboBox();
            PopulateServiceTypeComboBox();
        }

        private void PopulateMechanicComboBox()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT CONCAT(firstName, ' ', lastName) AS mechanicName FROM mechanic_info";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string mechanicName = reader["mechanicName"].ToString();
                                mechanic_cmbx.Items.Add(mechanicName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating mechanic combobox: " + ex.Message);
            }
        }

        private void PopulateStatusComboBox()
        {
            status_cmbx.Items.AddRange(new object[] { "All Statuses", "Pending", "Approved", "Done", "Completed", "Cancelled" });
        }

        private void PopulateServiceTypeComboBox()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT serviceType FROM services";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string serviceType = reader["serviceType"].ToString();
                                serviceType_cmbx.Items.Add(serviceType);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating service type combo box: " + ex.Message);
            }
        }

        private void PopulateReservations()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT r.reservation_id, 
                                           CONCAT(c.firstName, ' ', c.lastName) AS customerName, 
                                           CONCAT(s.serviceType, ' (₱', FORMAT(s.laborCost, 2), ')') AS serviceNeeded, 
                                           CONCAT(cv.make, ' ', cv.model, ' (', cv.year, ')') AS vehicleInfo, 
                                           r.problem_description, 
                                           r.date, 
                                           TIME_FORMAT(r.time, '%h:%i:%s %p') AS time, 
                                           r.status, 
                                           IFNULL(CONCAT(m.firstName, ' ', m.lastName, ' (', m.specialization, ')'), 'No mechanic assigned') AS assignedMechanic
                                    FROM reservations AS r
                                    LEFT JOIN customer_info AS c ON r.customer_id = c.customer_id
                                    LEFT JOIN services AS s ON r.service_id = s.service_id
                                    LEFT JOIN customer_vehicles AS cv ON r.vehicle_id = cv.vehicle_id
                                    LEFT JOIN mechanic_info AS m ON r.assigned_mechanic = m.mechanic_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        DataTable reservationTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(reservationTable);
                        }

                        reservationReportDataGrid.DataSource = reservationTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving reservation data: " + ex.Message);
            }
        }


        private void FilterReservationsByMechanic(string mechanicName)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT r.reservation_id, 
                                           CONCAT(c.firstName, ' ', c.lastName) AS customerName, 
                                           CONCAT(s.serviceType, ' (₱', FORMAT(s.laborCost, 2), ')') AS serviceNeeded, 
                                           CONCAT(cv.make, ' ', cv.model, ' (', cv.year, ')') AS vehicleInfo, 
                                           r.problem_description, 
                                           r.date, 
                                           TIME_FORMAT(r.time, '%h:%i:%s %p') AS time, 
                                           r.status, 
                                           IFNULL(CONCAT(m.firstName, ' ', m.lastName, ' (', m.specialization, ')'), 'No mechanic assigned') AS assignedMechanic
                                    FROM reservations AS r
                                    LEFT JOIN customer_info AS c ON r.customer_id = c.customer_id
                                    LEFT JOIN services AS s ON r.service_id = s.service_id
                                    LEFT JOIN customer_vehicles AS cv ON r.vehicle_id = cv.vehicle_id
                                    LEFT JOIN mechanic_info AS m ON r.assigned_mechanic = m.mechanic_id
                                    WHERE CONCAT(m.firstName, ' ', m.lastName) = @mechanicName";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@mechanicName", mechanicName);

                        DataTable reservationTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(reservationTable);
                        }

                        reservationReportDataGrid.DataSource = reservationTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering reservations by mechanic: " + ex.Message);
            }
        }

        private void FilterReservationsByStatus(string status)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT r.reservation_id, 
                                    CONCAT(c.firstName, ' ', c.lastName) AS customerName, 
                                    CONCAT(s.serviceType, ' (₱', FORMAT(s.laborCost, 2), ')') AS serviceNeeded, 
                                    CONCAT(cv.make, ' ', cv.model, ' (', cv.year, ')') AS vehicleInfo, 
                                    r.problem_description, 
                                    r.date, 
                                    TIME_FORMAT(r.time, '%h:%i:%s %p') AS time, 
                                    r.status, 
                                    IFNULL(CONCAT(m.firstName, ' ', m.lastName, ' (', m.specialization, ')'), 'No mechanic assigned') AS assignedMechanic
                                FROM reservations AS r
                                LEFT JOIN customer_info AS c ON r.customer_id = c.customer_id
                                LEFT JOIN services AS s ON r.service_id = s.service_id
                                LEFT JOIN customer_vehicles AS cv ON r.vehicle_id = cv.vehicle_id
                                LEFT JOIN mechanic_info AS m ON r.assigned_mechanic = m.mechanic_id
                                WHERE r.status = @status";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@status", status);

                        DataTable reservationTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(reservationTable);
                        }

                        reservationReportDataGrid.DataSource = reservationTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering reservations by status: " + ex.Message);
            }
        }

        private void FilterReservationsByServiceType(string serviceType)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT r.reservation_id, 
                                    CONCAT(c.firstName, ' ', c.lastName) AS customerName, 
                                    CONCAT(s.serviceType, ' (₱', FORMAT(s.laborCost, 2), ')') AS serviceNeeded, 
                                    CONCAT(cv.make, ' ', cv.model, ' (', cv.year, ')') AS vehicleInfo, 
                                    r.problem_description, 
                                    r.date, 
                                    TIME_FORMAT(r.time, '%h:%i:%s %p') AS time, 
                                    r.status, 
                                    IFNULL(CONCAT(m.firstName, ' ', m.lastName, ' (', m.specialization, ')'), 'No mechanic assigned') AS assignedMechanic
                                FROM reservations AS r
                                LEFT JOIN customer_info AS c ON r.customer_id = c.customer_id
                                LEFT JOIN services AS s ON r.service_id = s.service_id
                                LEFT JOIN customer_vehicles AS cv ON r.vehicle_id = cv.vehicle_id
                                LEFT JOIN mechanic_info AS m ON r.assigned_mechanic = m.mechanic_id
                                WHERE s.serviceType = @serviceType";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@serviceType", serviceType);

                        DataTable reservationTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(reservationTable);
                        }

                        reservationReportDataGrid.DataSource = reservationTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering reservations by service type: " + ex.Message);
            }
        }

        private void FilterReservationsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT r.reservation_id, 
                                    CONCAT(c.firstName, ' ', c.lastName) AS customerName, 
                                    CONCAT(s.serviceType, ' (₱', FORMAT(s.laborCost, 2), ')') AS serviceNeeded, 
                                    CONCAT(cv.make, ' ', cv.model, ' (', cv.year, ')') AS vehicleInfo, 
                                    r.problem_description, 
                                    r.date, 
                                    TIME_FORMAT(r.time, '%h:%i:%s %p') AS time, 
                                    r.status, 
                                    IFNULL(CONCAT(m.firstName, ' ', m.lastName, ' (', m.specialization, ')'), 'No mechanic assigned') AS assignedMechanic
                                FROM reservations AS r
                                LEFT JOIN customer_info AS c ON r.customer_id = c.customer_id
                                LEFT JOIN services AS s ON r.service_id = s.service_id
                                LEFT JOIN customer_vehicles AS cv ON r.vehicle_id = cv.vehicle_id
                                LEFT JOIN mechanic_info AS m ON r.assigned_mechanic = m.mechanic_id
                                WHERE r.date BETWEEN @startDate AND @endDate";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                        cmd.Parameters.AddWithValue("@endDate", endDate.Date.AddDays(1).AddSeconds(-1)); // Set time to 23:59:59 of end date

                        DataTable reservationTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(reservationTable);
                        }

                        reservationReportDataGrid.DataSource = reservationTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering reservations by date range: " + ex.Message);
            }
        }

        private void mechanic_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMechanic = mechanic_cmbx.SelectedItem.ToString();

            if (selectedMechanic == "All Mechanics")
            {
                PopulateReservations();
            }
            else
            {
                FilterReservationsByMechanic(selectedMechanic);
            }
        }

        private void status_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = status_cmbx.SelectedItem.ToString();

            if (selectedStatus == "All Statuses")
            {
                PopulateReservations(); 
            }
            else
            {
                FilterReservationsByStatus(selectedStatus);
            }
        }

        private void serviceType_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedServiceType = serviceType_cmbx.SelectedItem.ToString();

            if (selectedServiceType == "All Service Types")
            {
                PopulateReservations();
            }
            else
            {
                FilterReservationsByServiceType(selectedServiceType);
            }
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            PopulateReservations();
        }

        private void filterDate_btn_Click(object sender, EventArgs e)
        {
            DateTime startDate = start_DatePicker.Value.Date;
            DateTime endDate = end_DatePicker.Value.Date;

            FilterReservationsByDateRange(startDate, endDate);
        }

        private void exportExcel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)reservationReportDataGrid.DataSource;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "Reservations Report";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            IXLWorksheet worksheet = workbook.Worksheets.Add(dataTable, "ReservationReports");

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
    }
}
