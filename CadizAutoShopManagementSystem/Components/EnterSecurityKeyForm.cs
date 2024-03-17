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

namespace CadizAutoShopManagementSystem.Components
{
    public partial class EnterSecurityKeyForm : Form
    {
        public EnterSecurityKeyForm()
        {
            InitializeComponent();

            securityKey_txt.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    continue_btn_Click(sender, e);
                }
            };
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            string enteredKey = securityKey_txt.Text;
            string storedKey = RetrieveSecurityKeyFromDatabase(LoggedInUser.UserId);

            if (enteredKey == storedKey)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid security key. Please try again.");
            }
        }

        private string RetrieveSecurityKeyFromDatabase(int userId)
        {
            string securityKey = null;
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT securityKey FROM users_information WHERE user_id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        securityKey = cmd.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving security key: " + ex.Message);
            }
            return securityKey;
        }
    }
}
