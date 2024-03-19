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
    public partial class ManagePersonnelForm : UserControl
    {
        public ManagePersonnelForm()
        {
            InitializeComponent();
            DisplayUserInformation();
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

        private void personnelInfoDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == personnelInfoDataGrid.Columns["RemoveColumn"].Index && e.RowIndex >= 0)
            {
                int userInfoId = Convert.ToInt32(personnelInfoDataGrid.Rows[e.RowIndex].Cells["userInfo_id"].Value);

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

        private void generate_btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int userId = rnd.Next(100000, 999999);
            id_txt.Text = userId.ToString();
        }

        private void TogglePasswordVisibility(TextBox textBox)
        {
            if (textBox.PasswordChar == '\0')
                textBox.PasswordChar = '•';
            else
                textBox.PasswordChar = '\0';
        }

        private void showPasswordChar_btn_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(password_txt); 
            TogglePasswordVisibility(confirmPassword_txt);
        }

        private void ClearTextFields()
        {
            id_txt.Clear();
            firstName_txt.Clear();
            middleName_txt.Clear();
            lastName_txt.Clear();
            contact_txt.Clear();
            address_txt.Clear();
            username_txt.Clear();
            password_txt.Clear();
            confirmPassword_txt.Clear();
        }

        private void SaveUserInformation()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username_txt.Text) ||
                    string.IsNullOrWhiteSpace(password_txt.Text) ||
                    string.IsNullOrWhiteSpace(confirmPassword_txt.Text) ||
                    string.IsNullOrWhiteSpace(id_txt.Text) ||
                    string.IsNullOrWhiteSpace(firstName_txt.Text) ||
                    string.IsNullOrWhiteSpace(lastName_txt.Text) ||
                    string.IsNullOrWhiteSpace(contact_txt.Text) ||
                    string.IsNullOrWhiteSpace(address_txt.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (password_txt.Text != confirmPassword_txt.Text)
                {
                    MessageBox.Show("Password and confirm password do not match.");
                    return;
                }

                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string insertUserQuery = "INSERT INTO users (username, password, userRole) VALUES (@username, @password, 'Employee'); SELECT LAST_INSERT_ID();";
                    MySqlCommand insertUserCommand = new MySqlCommand(insertUserQuery, connection);
                    insertUserCommand.Parameters.AddWithValue("@username", username_txt.Text);
                    insertUserCommand.Parameters.AddWithValue("@password", password_txt.Text);
                    int userId = Convert.ToInt32(insertUserCommand.ExecuteScalar());

                    string insertUserInfoQuery = "INSERT INTO users_information (userInfo_id, user_id, firstName, middleName, lastName, contactNumber, address, wasChanged) " +
                                                 "VALUES (@userInfo_id, @user_id, @firstName, @middleName, @lastName, @contactNumber, @address, NOW());";
                    MySqlCommand insertUserInfoCommand = new MySqlCommand(insertUserInfoQuery, connection);

                    insertUserInfoCommand.Parameters.AddWithValue("@userInfo_id", id_txt.Text);
                    insertUserInfoCommand.Parameters.AddWithValue("@user_id", userId);
                    insertUserInfoCommand.Parameters.AddWithValue("@firstName", firstName_txt.Text);
                    insertUserInfoCommand.Parameters.AddWithValue("@middleName", middleName_txt.Text);
                    insertUserInfoCommand.Parameters.AddWithValue("@lastName", lastName_txt.Text);
                    insertUserInfoCommand.Parameters.AddWithValue("@contactNumber", contact_txt.Text);
                    insertUserInfoCommand.Parameters.AddWithValue("@address", address_txt.Text);
                    insertUserInfoCommand.ExecuteNonQuery();

                    MessageBox.Show("PERSONNEL REGISTERED.");
                    DisplayUserInformation();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving user information: " + ex.Message);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveUserInformation();
        }
    }
}
