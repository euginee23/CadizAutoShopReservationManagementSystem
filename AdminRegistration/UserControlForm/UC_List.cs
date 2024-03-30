using CadizAutoShopManagementSystem;
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

namespace AdminRegistration.UserControlForm
{
    public partial class UC_List : UserControl
    {
        private LoadingStateForm loadingForm;

        public UC_List()
        {
            ShowLoadingForm();
            InitializeComponent();
            DisplayUserInformation();
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

        private void DisplayUserInformation()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT ui.userInfo_id, ui.firstName, ui.lastName, ui.contactNumber, ui.address " +
                                   "FROM users_information ui " +
                                   "JOIN users u ON ui.user_id = u.user_id " +
                                   "WHERE u.userRole = 'Admin'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    adminInfoDataGrid.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving user information: " + ex.Message);
            }
        }

        private bool DeleteUserInfo(int userInfoId)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string deleteQuery = "DELETE ui, u FROM users_information ui " +
                                         "JOIN users u ON ui.user_id = u.user_id " +
                                         "WHERE ui.userInfo_id = @userInfoId";
                    MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@userInfoId", userInfoId);

                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting user information: " + ex.Message);
                return false;
            }
        }

        private void adminInfoDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == adminInfoDataGrid.Columns["RemoveColumn"].Index && e.RowIndex >= 0)
            {
                int userInfoId = Convert.ToInt32(adminInfoDataGrid.Rows[e.RowIndex].Cells["userInfo_id"].Value);

                if (DeleteUserInfo(userInfoId))
                {
                    DisplayUserInformation();
                    MessageBox.Show("User information removed successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to remove user information.");
                }
            }
        }
    }
}
