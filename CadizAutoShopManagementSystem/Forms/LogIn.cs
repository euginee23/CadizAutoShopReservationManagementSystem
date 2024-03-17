using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadizAutoShopManagementSystem.Configs;
using MySql.Data.MySqlClient;

namespace CadizAutoShopManagementSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

            //IF ENTER KEY IS PRESSED PERFORM LOG IN
            password_txt.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Login_btn_Click(sender, e);
                }
            };
        }

        //RETRIEVING THE USER ROLE UPON LOGIN
        private string GetUserRole(string username, string password)
        {
            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT userRole FROM users WHERE username = @username AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();

                        return result?.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }

        // RETRIEVING THE USER ID UPON LOGIN
        private int GetUserId(string username, string password)
        {
            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT user_id FROM users WHERE username = @username AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();

                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return -1;
                }
            }
        }

        //ADDING A LOG-IN HISTORY
        private void LogUserLogin(int userId)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO user_login_history (user_id, date, time) VALUES (@userId, @date, @time)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("HH:mm:ss"));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging user login: " + ex.Message);
            }
        }

        //LOG IN AND PASSING THE USER ROLE TO THE MAIN FORM
        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = password_txt.Text;

            int userId = GetUserId(username, password);

            if (userId != -1)
            {
                LoggedInUser.UserId = userId;

                LogUserLogin(userId); // Log user login

                string userRole = GetUserRole(username, password);

                if (userRole != null)
                {
                    MessageBox.Show("Login successful!");

                    MainForm mainForm = new MainForm(userRole);
                    mainForm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        // CLOSE THE APPLICATION PROPERLY WHEN CLOSING THE LOGIN FORM
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}
