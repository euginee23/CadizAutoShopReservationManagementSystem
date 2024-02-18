using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CadizAutoShopManagementSystem.Forms;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class ReservationsForm : UserControl
    {
        private MySqlConnection connection;

        public ReservationsForm()
        {
            InitializeComponent();
        }

        //USER CONTROL PANEL NAVIGATION
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            reservationPanel.Controls.Clear();
            reservationPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //FORM LOAD
        private void ReservationsForm_Load(object sender, EventArgs e)
        {
            connection = DatabaseManager.GetConnection();
            connection.Open();
            LoadData();
            PopulateServiceComboBox();
        }

        //DATA LOAD
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
                               "WHERE r.status = 'Pending'";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    pendingDataGrid.RowTemplate.Height = 50;
                    dataAdapter.Fill(dataTable);
                    pendingDataGrid.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //DATAGRID BUTTON CLICK FUNCTION
        private void buttonClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == pendingDataGrid.Columns["Approve"].Index)
                {
                    int reservationId = Convert.ToInt32(pendingDataGrid.Rows[e.RowIndex].Cells["reservation_id"].Value);
                    using (ApprovingReservationForm approvingForm = new ApprovingReservationForm(reservationId))
                    {
                        DialogResult result = approvingForm.ShowDialog();
                        LoadData();
                    }
                }
                else if (e.ColumnIndex == pendingDataGrid.Columns["Decline"].Index)
                {
                    int reservationId = Convert.ToInt32(pendingDataGrid.Rows[e.RowIndex].Cells["reservation_id"].Value);
                    using (DecliningReservationForm decliningForm = new DecliningReservationForm(reservationId))
                    {
                        DialogResult result = decliningForm.ShowDialog();
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //POPULATE COMBOBOX WITH SERVICES FOR FILTERING
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

        //COMBOBOX FILTER FUCNTION
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

                                pendingDataGrid.DataSource = filteredDataTable;
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

        //NAVIGATE TO APPROVED RESERVATIONS
        private void approvedReservation_btn_Click_1(object sender, EventArgs e)
        {
            ApprovedReservationsForm approvedRes = new ApprovedReservationsForm();
            addUserControl(approvedRes);
        }

        //NAVIGATE TO COMPLETED RESERVATIONS
        private void completedReservations_btn_Click(object sender, EventArgs e)
        {
            CompletedReservationsForm completedRes = new CompletedReservationsForm();
            addUserControl(completedRes);
        }

        //REFRESH BUTTON / SHOW ALL
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
