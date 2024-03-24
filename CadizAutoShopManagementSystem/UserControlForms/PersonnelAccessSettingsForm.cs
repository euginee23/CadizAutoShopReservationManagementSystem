using CadizAutoShopManagementSystem.Components;
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
    public partial class PersonnelAccessSettingsForm : UserControl
    {
        private LoadingStateForm loadingForm;

        public PersonnelAccessSettingsForm()
        {
            ShowLoadingForm();
            InitializeComponent();
            DisplayPersonnelInformation();
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

        private void DisplayPersonnelInformation()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT ui.userInfo_id, ui.firstName, ui.lastName, ui.contactNumber, ui.address, u.user_id " +
                                   "FROM users_information ui " +
                                   "JOIN users u ON ui.user_id = u.user_id " +
                                   "WHERE u.userRole = 'Employee'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    personnelInfoDataGrid.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving user information: " + ex.Message);
            }
        }

        private void personnelInfoDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = personnelInfoDataGrid.Rows[e.RowIndex];

                userId_lbl.Text = selectedRow.Cells["user_id"].Value.ToString();

                string firstName = selectedRow.Cells["firstName"].Value.ToString();
                string lastName = selectedRow.Cells["lastName"].Value.ToString();
                string fullName = $"{firstName} {lastName}".Trim();
                name_lbl.Text = fullName;

                int userId = Convert.ToInt32(selectedRow.Cells["user_id"].Value);

                try
                {
                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string query = "SELECT * FROM user_access WHERE user_id = @userId";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@userId", userId);
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            dashboard_chckbx.Checked = Convert.ToBoolean(reader["dashboard"]);
                            reservations_chckbx.Checked = Convert.ToBoolean(reader["reservations"]);
                            manageMechanics_chckbx.Checked = Convert.ToBoolean(reader["manage_mechanics"]);
                            manageServices_chckbx.Checked = Convert.ToBoolean(reader["manage_services"]);
                            manageInventory_chckbx.Checked = Convert.ToBoolean(reader["manage_inventory"]);
                            sellParts_chckbx.Checked = Convert.ToBoolean(reader["sell_parts"]);
                            localService_chckbx.Checked = Convert.ToBoolean(reader["local_service"]);
                            localReservation_chckbx.Checked = Convert.ToBoolean(reader["local_reservation"]);
                            reports_chckbx.Checked = Convert.ToBoolean(reader["reports"]);
                            billing_chckbx.Checked = Convert.ToBoolean(reader["billing"]);
                        }
                        else
                        {
                            foreach (Control control in checkBoxContainer.Controls)
                            {
                                if (control is CheckBox checkBox)
                                {
                                    checkBox.Checked = false;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving user access data: " + ex.Message);
                }
            }
        }

        private void setAccess_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userId_lbl.Text) || !int.TryParse(userId_lbl.Text, out int userId))
            {
                MessageBox.Show("Please select a personnel.");
                return;
            }

            bool dashboardAccess = dashboard_chckbx.Checked;
            bool reservationsAccess = reservations_chckbx.Checked;
            bool manageMechanicsAccess = manageMechanics_chckbx.Checked;
            bool manageServicesAccess = manageServices_chckbx.Checked;
            bool manageInventoryAccess = manageInventory_chckbx.Checked;
            bool sellPartsAccess = sellParts_chckbx.Checked;
            bool localServiceAccess = localService_chckbx.Checked;
            bool localReservationAccess = localReservation_chckbx.Checked;
            bool reportsAccess = reports_chckbx.Checked;
            bool billingAccess = billing_chckbx.Checked;

            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string checkExistQuery = "SELECT COUNT(*) FROM user_access WHERE user_id = @userId";
                    MySqlCommand checkExistCommand = new MySqlCommand(checkExistQuery, connection);
                    checkExistCommand.Parameters.AddWithValue("@userId", userId);
                    int userCount = Convert.ToInt32(checkExistCommand.ExecuteScalar());

                    if (userCount > 0)
                    {
                        string updateQuery = @"UPDATE user_access 
                                       SET dashboard = @dashboardAccess, reservations = @reservationsAccess, 
                                           manage_mechanics = @manageMechanicsAccess, manage_services = @manageServicesAccess, 
                                           manage_inventory = @manageInventoryAccess, sell_parts = @sellPartsAccess, 
                                           local_service = @localServiceAccess, local_reservation = @localReservationAccess, 
                                           reports = @reportsAccess, billing = @billingAccess 
                                       WHERE user_id = @userId";

                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@userId", userId);
                        updateCommand.Parameters.AddWithValue("@dashboardAccess", dashboardAccess);
                        updateCommand.Parameters.AddWithValue("@reservationsAccess", reservationsAccess);
                        updateCommand.Parameters.AddWithValue("@manageMechanicsAccess", manageMechanicsAccess);
                        updateCommand.Parameters.AddWithValue("@manageServicesAccess", manageServicesAccess);
                        updateCommand.Parameters.AddWithValue("@manageInventoryAccess", manageInventoryAccess);
                        updateCommand.Parameters.AddWithValue("@sellPartsAccess", sellPartsAccess);
                        updateCommand.Parameters.AddWithValue("@localServiceAccess", localServiceAccess);
                        updateCommand.Parameters.AddWithValue("@localReservationAccess", localReservationAccess);
                        updateCommand.Parameters.AddWithValue("@reportsAccess", reportsAccess);
                        updateCommand.Parameters.AddWithValue("@billingAccess", billingAccess);

                        updateCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        string insertQuery = @"INSERT INTO user_access (user_id, dashboard, reservations, manage_mechanics, 
                                       manage_services, manage_inventory, sell_parts, local_service, local_reservation, 
                                       reports, billing) 
                                       VALUES (@userId, @dashboardAccess, @reservationsAccess, @manageMechanicsAccess, 
                                       @manageServicesAccess, @manageInventoryAccess, @sellPartsAccess, @localServiceAccess, 
                                       @localReservationAccess, @reportsAccess, @billingAccess)";

                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@userId", userId);
                        insertCommand.Parameters.AddWithValue("@dashboardAccess", dashboardAccess);
                        insertCommand.Parameters.AddWithValue("@reservationsAccess", reservationsAccess);
                        insertCommand.Parameters.AddWithValue("@manageMechanicsAccess", manageMechanicsAccess);
                        insertCommand.Parameters.AddWithValue("@manageServicesAccess", manageServicesAccess);
                        insertCommand.Parameters.AddWithValue("@manageInventoryAccess", manageInventoryAccess);
                        insertCommand.Parameters.AddWithValue("@sellPartsAccess", sellPartsAccess);
                        insertCommand.Parameters.AddWithValue("@localServiceAccess", localServiceAccess);
                        insertCommand.Parameters.AddWithValue("@localReservationAccess", localReservationAccess);
                        insertCommand.Parameters.AddWithValue("@reportsAccess", reportsAccess);
                        insertCommand.Parameters.AddWithValue("@billingAccess", billingAccess);

                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Access permissions updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while setting access permissions: " + ex.Message);
            }
        }

        private void deselect_btn_Click(object sender, EventArgs e)
        {
            foreach (Control control in checkBoxContainer.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
        }
    }
}
