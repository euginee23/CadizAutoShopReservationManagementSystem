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
    public partial class UC_Registration : UserControl
    {
        private LoadingStateForm loadingForm;

        public UC_Registration()
        {
            InitializeComponent();
            random_id();
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

        private void random_id()
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

        private void save_information()
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

                ShowLoadingForm();
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string insertUserQuery = "INSERT INTO users (username, password, userRole) VALUES (@username, @password, 'Admin'); SELECT LAST_INSERT_ID();";
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

                    CloseLoadingForm();
                    MessageBox.Show("ADMIN REGISTERED.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving user information: " + ex.Message);
            }
        }

        private void clear_click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            save_information();
        }
    }
}
