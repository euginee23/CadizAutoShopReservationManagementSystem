using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadizAutoShopManagementSystem.Components;
using CadizAutoShopManagementSystem.Forms;
using MySql.Data.MySqlClient;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class ApprovedReservationsForm : UserControl
    {
        private LoadingStateForm loadingForm;

        public ApprovedReservationsForm()
        {
            InitializeComponent();
        }

        //FORM LOAD
        private void ApprovedReservationsForm_Load(object sender, EventArgs e)
        {
            ShowLoadingForm();
            LoadApprovedReservationsData();
            PopulateMechanicComboBox();
            PopulateServicesComboBox();
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


        //LOAD DATA FROM DATABASE
        private void LoadApprovedReservationsData()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT r.reservation_id, " +
                                   "CONCAT(c.firstName, ' ', c.lastName) AS customerName, " +
                                   "s.serviceType AS serviceType, " +
                                   "CONCAT(v.make, ' ', v.model, ' ', v.year) AS vehicleName, " +
                                   "CONCAT(m.firstName, ' ', m.lastName) AS mechanicName " +
                                   "FROM reservations r " +
                                   "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                   "INNER JOIN services s ON r.service_id = s.service_id " +
                                   "INNER JOIN customer_vehicles v ON r.vehicle_id = v.vehicle_id " +
                                   "INNER JOIN mechanic_info m ON r.assigned_mechanic = m.mechanic_id " +
                                   "WHERE r.status = 'Approved'";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        approvedReservationsDataGrid.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //CELL CLICK THE RESERVATION ID
        private void approvedReservationsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = approvedReservationsDataGrid.Rows[e.RowIndex];

                string reservationId = selectedRow.Cells["reservationId_Column"].Value.ToString();
                reservationId_txt.Text = reservationId;
            }
        }

        //RESERVATION ID TEXT CHANGED FOR POPULATING THE TEXTBOXES
        private void getReservationVehicleCustomer_Textchanged(object sender, EventArgs e)
        {
            if (int.TryParse(reservationId_txt.Text, out int reservationId))
            {
                try
                {
                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string query = "SELECT c.customer_id, CONCAT(c.firstName, c.lastName) AS customerName, c.contactNumber, c.address, c.email, " +
                                       "v.vehicle_id, v.make, v.model, v.year, v.vehicle_type, v.plate_number, " +
                                       "r.problem_description, " +
                                       "CONCAT(m.firstName, ' ', m.lastName, ' ', '(', m.specialization, ')') AS mechanicName, " +
                                       "s.serviceType " +
                                       "FROM reservations r " +
                                       "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                       "INNER JOIN customer_vehicles v ON r.vehicle_id = v.vehicle_id " +
                                       "INNER JOIN mechanic_info m ON r.assigned_mechanic = m.mechanic_id " +
                                       "INNER JOIN services s ON r.service_id = s.service_id " +
                                       "WHERE r.reservation_id = @reservationId";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@reservationId", reservationId);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string serviceType = reader["serviceType"].ToString();
                                    string problemDescription = reader["problem_description"].ToString();
                                    string mechanicAssigned = reader["mechanicName"].ToString();

                                    string vehicleId = reader["vehicle_id"].ToString();
                                    string make = reader["make"].ToString();
                                    string model = reader["model"].ToString();
                                    string year = reader["year"].ToString();
                                    string vehicleType = reader["vehicle_type"].ToString();
                                    string plateNumber = reader["plate_number"].ToString();

                                    string customerId = reader["customer_id"].ToString();
                                    string customerName = reader["customerName"].ToString();
                                    string contactNumber = reader["contactNumber"].ToString();
                                    string customerAddress = reader["address"].ToString();
                                    string customerEmail = reader["email"].ToString();

                                    serviceType_txt.Text = serviceType;
                                    problemDescription_txt.Text = problemDescription;
                                    mechanicAssigned_txt.Text = mechanicAssigned;

                                    vehicleId_txt.Text = vehicleId;
                                    vehicleMake_txt.Text = make;
                                    vehicleModel_txt.Text = model;
                                    vehicleYear_txt.Text = year;
                                    vehicleType_txt.Text = vehicleType;
                                    vehiclePlateNumber_txt.Text = plateNumber;

                                    customerId_txt.Text = customerId;
                                    customerName_txt.Text = customerName;
                                    customerContact_txt.Text = contactNumber;
                                    customerAddress_txt.Text = customerAddress;
                                    customerEmail_txt.Text = customerEmail;



                                }
                                else
                                {
                                    ClearFields();
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
        }

        //CLEARING FIELDS
        private void ClearFields()
        {
          
        }

        //POPULATE MECHANIC COMBOBOX
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

        //FILTERING BY MECHANIC FUNCTION
        private void filterByMechanicAssignedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (filterByMechanic_cmbx.Focused)
                {
                    string selectedMechanic = filterByMechanic_cmbx.SelectedItem?.ToString();

                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string selectQuery = "SELECT r.reservation_id, " +
                                             "CONCAT(c.firstName, ' ', c.lastName) AS customerName, " +
                                             "s.serviceType AS serviceType, " +
                                             "CONCAT(v.make, ' ', v.model, ' ', v.year) AS vehicleName, " +
                                             "CONCAT(m.firstName, ' ', m.lastName) AS mechanicName " +
                                             "FROM reservations r " +
                                             "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                             "INNER JOIN services s ON r.service_id = s.service_id " +
                                             "INNER JOIN customer_vehicles v ON r.vehicle_id = v.vehicle_id " +
                                             "INNER JOIN mechanic_info m ON r.assigned_mechanic = m.mechanic_id " +
                                             "WHERE r.status = 'Approved'";

                        if (!string.IsNullOrEmpty(selectedMechanic))
                        {
                            selectQuery += " AND CONCAT(m.firstName, ' ', m.lastName, ' ', '(', m.specialization, ')') = @selectedMechanic";
                        }

                        using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                        {
                            if (!string.IsNullOrEmpty(selectedMechanic))
                            {
                                cmd.Parameters.AddWithValue("@selectedMechanic", selectedMechanic);
                            }

                            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable filteredDataTable = new DataTable();
                                dataAdapter.Fill(filteredDataTable);

                                approvedReservationsDataGrid.DataSource = filteredDataTable;
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

        //POPULATE SERVICES COMBOBOX
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

        //FILTERING BY SERVICE TYPE FUNCTION
        private void filterByServiceTypeIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (filterByServiceType_cmbx.Focused)
                {
                    string selectedServiceType = filterByServiceType_cmbx.SelectedItem?.ToString();

                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string selectQuery = "SELECT r.reservation_id, " +
                                             "CONCAT(c.firstName, ' ', c.lastName) AS customerName, " +
                                             "s.serviceType AS serviceType, " +
                                             "CONCAT(v.make, ' ', v.model, ' ', v.year) AS vehicleName, " +
                                             "CONCAT(m.firstName, ' ', m.lastName) AS mechanicName " +
                                             "FROM reservations r " +
                                             "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                             "INNER JOIN services s ON r.service_id = s.service_id " +
                                             "INNER JOIN customer_vehicles v ON r.vehicle_id = v.vehicle_id " +
                                             "INNER JOIN mechanic_info m ON r.assigned_mechanic = m.mechanic_id " +
                                             "WHERE r.status = 'Approved'";

                        if (!string.IsNullOrEmpty(selectedServiceType))
                        {
                            selectQuery += " AND s.serviceType = @selectedServiceType";
                        }

                        using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                        {
                            if (!string.IsNullOrEmpty(selectedServiceType))
                            {
                                cmd.Parameters.AddWithValue("@selectedServiceType", selectedServiceType);
                            }

                            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable filteredDataTable = new DataTable();
                                dataAdapter.Fill(filteredDataTable);

                                approvedReservationsDataGrid.DataSource = filteredDataTable;
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

        //SEARCH CUSTOMER NAME FUNCTION
        private void searchCustomer(object sender, EventArgs e)
        {
            try
            {
                string customerName = searchByCustomerName_txt.Text.Trim();

                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT r.reservation_id, " +
                                         "CONCAT(c.firstName, ' ', c.lastName) AS customerName, " +
                                         "s.serviceType AS serviceType, " +
                                         "CONCAT(v.make, ' ', v.model, ' ', v.year) AS vehicleName, " +
                                         "CONCAT(m.firstName, ' ', m.lastName) AS mechanicName " +
                                         "FROM reservations r " +
                                         "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                         "INNER JOIN services s ON r.service_id = s.service_id " +
                                         "INNER JOIN customer_vehicles v ON r.vehicle_id = v.vehicle_id " +
                                         "INNER JOIN mechanic_info m ON r.assigned_mechanic = m.mechanic_id " +
                                         "WHERE r.status = 'Approved'";

                    if (!string.IsNullOrEmpty(customerName))
                    {
                        selectQuery += " AND CONCAT(c.firstName, ' ', c.lastName) LIKE @customerName";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        if (!string.IsNullOrEmpty(customerName))
                        {
                            cmd.Parameters.AddWithValue("@customerName", $"%{customerName}%");
                        }

                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable filteredDataTable = new DataTable();
                            dataAdapter.Fill(filteredDataTable);

                            approvedReservationsDataGrid.DataSource = filteredDataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //SHOW ALL BUTTON CLICK
        private void showAll_btn_Click(object sender, EventArgs e)
        {
            LoadApprovedReservationsData();
        }

        //DATAGRID BUTTON CLICK
        private void buttonClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == approvedReservationsDataGrid.Columns["DoneColumn"].Index)
                {
                    int reservationId = Convert.ToInt32(approvedReservationsDataGrid.Rows[e.RowIndex].Cells["reservationId_column"].Value);
                    using (DoneReservationForm doneReservation = new DoneReservationForm(reservationId))
                    {
                        DialogResult result = doneReservation.ShowDialog();
                        LoadApprovedReservationsData();
                    }
                }
                else if (e.ColumnIndex == approvedReservationsDataGrid.Columns["CancelColumn"].Index)
                {
                    int reservationId = Convert.ToInt32(approvedReservationsDataGrid.Rows[e.RowIndex].Cells["reservationId_column"].Value);
                    using (CancelReservationForm cancelForm = new CancelReservationForm(reservationId))
                    {
                        DialogResult result = cancelForm.ShowDialog();
                        LoadApprovedReservationsData();
                    }
                }
                else if (e.ColumnIndex == approvedReservationsDataGrid.Columns["UpdateColumn"].Index)
                {
                    int reservationId = Convert.ToInt32(approvedReservationsDataGrid.Rows[e.RowIndex].Cells["reservationId_column"].Value);
                    using (AssignNewMechanicForm updateForm = new AssignNewMechanicForm(reservationId))
                    {
                        DialogResult result = updateForm.ShowDialog();
                        LoadApprovedReservationsData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
