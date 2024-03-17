using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CadizAutoShopManagementSystem.Models;
using System.Security.Cryptography;
using CadizAutoShopManagementSystem.Configs;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class AdminAccountSettingForm : UserControl
    {

        public AdminAccountSettingForm()
        {
            InitializeComponent();
            DisplayLoggedInUserId();
            PopulateUserInfo();
            PopulateLoginHistory();
        }

        private void DisplayLoggedInUserId()
        {
            if (LoggedInUser.UserId != 0)
            {
                login_lbl.Text = LoggedInUser.UserId.ToString();
            }
            else
            {
                login_lbl.Text = "No user logged in";
            }
        }


        private void generate_btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int userId = rnd.Next(100000, 999999);
            id_txt.Text = userId.ToString();
        }

        private void PopulateUserInfo()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string usernameQuery = "SELECT username FROM users WHERE user_id = @userId";
                    using (MySqlCommand usernameCmd = new MySqlCommand(usernameQuery, connection))
                    {
                        usernameCmd.Parameters.AddWithValue("@userId", LoggedInUser.UserId);
                        object usernameResult = usernameCmd.ExecuteScalar();

                        if (usernameResult != null)
                        {
                            username_lbl.Text = usernameResult.ToString();
                            username_txt.Text = usernameResult.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Username not found for user ID: " + LoggedInUser.UserId);
                        }
                    }

                    string userInfoQuery = "SELECT * FROM users_information WHERE user_id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(userInfoQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", LoggedInUser.UserId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                id_txt.Text = reader["userInfo_id"].ToString();
                                adminId_lbl.Text = reader["userInfo_id"].ToString();

                                firstName_txt.Text = reader["firstName"].ToString();
                                middleName_txt.Text = reader["middleName"].ToString();
                                lastName_txt.Text = reader["lastName"].ToString();
                                string adminName = reader["firstName"].ToString() + " " + reader["middleName"].ToString() + " " + reader["lastName"].ToString();
                                adminName_lbl.Text = adminName;

                                contact_txt.Text = reader["contactNumber"].ToString();
                                adminPhone_lbl.Text = reader["contactNumber"].ToString();

                                address_txt.Text = reader["address"].ToString();
                                address_lbl.Text = reader["address"].ToString();

                                changedDate_lbl.Text = reader["wasChanged"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("User information not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user information: " + ex.Message);
            }
        }

        private void PopulateLoginHistory()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT date, TIME_FORMAT(time, '%h:%i:%s %p') AS time FROM user_login_history WHERE user_id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", LoggedInUser.UserId);

                        DataTable loginHistoryTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(loginHistoryTable);
                        }

                        loginHistoryDataGrid.DataSource = loginHistoryTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving login history: " + ex.Message);
            }
        }

        private void UpdatingBasicInformation()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE users_information SET userInfo_id = @userInfoID, firstName = @firstName, middleName = @middleName, lastName = @lastName, contactNumber = @contactNumber, address = @address, wasChanged = NOW() WHERE user_id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@userInfoID", id_txt.Text);
                        cmd.Parameters.AddWithValue("@firstName", firstName_txt.Text);
                        cmd.Parameters.AddWithValue("@middleName", middleName_txt.Text);
                        cmd.Parameters.AddWithValue("@lastName", lastName_txt.Text);
                        cmd.Parameters.AddWithValue("@contactNumber", contact_txt.Text);
                        cmd.Parameters.AddWithValue("@address", address_txt.Text);
                        cmd.Parameters.AddWithValue("@userId", LoggedInUser.UserId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User information updated successfully.");
                            PopulateUserInfo();
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user information: " + ex.Message);
            }
        }

        private void UpdatingSecurityKey()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string oldSecurityKey = oldSecurityKey_txt.Text;
                    string checkOldKeyQuery = "SELECT COUNT(*) FROM users_information WHERE user_id = @userId AND securityKey = @oldSecurityKey";
                    using (MySqlCommand checkOldKeyCmd = new MySqlCommand(checkOldKeyQuery, connection))
                    {
                        checkOldKeyCmd.Parameters.AddWithValue("@userId", LoggedInUser.UserId);
                        checkOldKeyCmd.Parameters.AddWithValue("@oldSecurityKey", oldSecurityKey);
                        int count = Convert.ToInt32(checkOldKeyCmd.ExecuteScalar());
                        if (count == 0)
                        {
                            MessageBox.Show("Old security key is incorrect. Please try again.");
                            return;
                        }
                    }

                    string newSecurityKey = newSecurityKey_txt.Text;
                    string confirmNewSecurityKey = confirmNewSecKey_txt.Text;
                    if (string.IsNullOrWhiteSpace(newSecurityKey))
                    {
                        MessageBox.Show("Please enter a new security key.");
                        return;
                    }
                    if (newSecurityKey != confirmNewSecurityKey)
                    {
                        MessageBox.Show("New security key and confirmation do not match. Please try again.");
                        return;
                    }

                    string updateQuery = "UPDATE users_information SET securityKey = @newSecurityKey WHERE user_id = @userId";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@userId", LoggedInUser.UserId);
                        updateCmd.Parameters.AddWithValue("@newSecurityKey", newSecurityKey);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Security key updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating security key: " + ex.Message);
            }
        }

        private void UpdatingLoginCredentials()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string oldPassword = oldPassword_txt.Text;
                    string newPassword = newPassword_txt.Text;
                    string confirmNewPassword = confirmNewPassword_txt.Text;

                    string checkOldPasswordQuery = "SELECT COUNT(*) FROM users WHERE user_id = @userId AND password = @oldPassword";
                    using (MySqlCommand checkOldPasswordCmd = new MySqlCommand(checkOldPasswordQuery, connection))
                    {
                        checkOldPasswordCmd.Parameters.AddWithValue("@userId", LoggedInUser.UserId);
                        checkOldPasswordCmd.Parameters.AddWithValue("@oldPassword", oldPassword);
                        int count = Convert.ToInt32(checkOldPasswordCmd.ExecuteScalar());
                        if (count == 0)
                        {
                            MessageBox.Show("Old password is incorrect. Please try again.");
                            return;
                        }
                    }

                    if (string.IsNullOrWhiteSpace(newPassword))
                    {
                        MessageBox.Show("Please enter a new password.");
                        return;
                    }
                    if (newPassword != confirmNewPassword)
                    {
                        MessageBox.Show("New password and confirmation do not match. Please try again.");
                        return;
                    }

                    string updateLoginCredentialsQuery = "UPDATE users SET username = @newUsername, password = @newPassword WHERE user_id = @userId";
                    using (MySqlCommand updateLoginCredentialsCmd = new MySqlCommand(updateLoginCredentialsQuery, connection))
                    {
                        updateLoginCredentialsCmd.Parameters.AddWithValue("@newUsername", username_txt.Text);
                        updateLoginCredentialsCmd.Parameters.AddWithValue("@newPassword", newPassword);
                        updateLoginCredentialsCmd.Parameters.AddWithValue("@userId", LoggedInUser.UserId);

                        int rowsAffected = updateLoginCredentialsCmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Failed to update login credentials.");
                            return;
                        }
                    }

                    MessageBox.Show("Login credentials updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating login credentials: " + ex.Message);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(oldPassword_txt.Text))
            {
                UpdatingLoginCredentials();
            }
            else if (!string.IsNullOrWhiteSpace(oldSecurityKey_txt.Text))
            {
                UpdatingSecurityKey();
            }
            else
            {
                UpdatingBasicInformation();
            }
        }

        private void TogglePasswordVisibility(TextBox textBox)
        {
            if (textBox.PasswordChar == '\0')
                textBox.PasswordChar = '•';
            else
                textBox.PasswordChar = '\0'; 
        }

        private void showSecurityChar_btn_btn_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(oldSecurityKey_txt);
            TogglePasswordVisibility(newSecurityKey_txt);
            TogglePasswordVisibility(confirmNewSecKey_txt);
        }

        private void showPasswordChar_btn_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(oldPassword_txt);
            TogglePasswordVisibility(newPassword_txt);
            TogglePasswordVisibility(confirmNewPassword_txt);
        }

        private void clearHistory_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM user_login_history WHERE user_id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", LoggedInUser.UserId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Login history cleared successfully.");
                            PopulateLoginHistory(); 
                        }
                        else
                        {
                            MessageBox.Show("No login history found to clear.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing login history: " + ex.Message);
            }
        }
    }
}
