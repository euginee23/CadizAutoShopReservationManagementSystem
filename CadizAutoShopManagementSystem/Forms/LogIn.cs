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

        //LOG IN AND PASSING THE USER ROLE TO THE MAIN FORM
        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = password_txt.Text;

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

        //CLOSE THE APPLICATION PROPERLY WHEN CLOSING THE LOGIN FORM
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}
