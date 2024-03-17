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
using CadizAutoShopManagementSystem.Forms;

namespace CadizAutoShopManagementSystem.Forms
{
    public partial class LocalServicesMarkingForm : Form
    {
        private int localServiceId;
        public LocalServicesMarkingForm(int localServiceId)
        {
            InitializeComponent();
            this.localServiceId = localServiceId;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            UpdateLocalServiceStatus(localServiceId, "Cancelled");

            this.Close();
        }

        private void UpdateLocalServiceStatus(int localServiceId, string status)
        {
            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE local_service SET status = @Status WHERE localService_id = @LocalServiceId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@LocalServiceId", localServiceId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Local Service with ID: {localServiceId} has been cancelled");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update local service status.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating local service status: " + ex.Message);
                }
            }
        }

        private void progress_btn_Click(object sender, EventArgs e)
        {
            UpdateLocalServiceStatus2(localServiceId, "On-Progress");

            this.Close();
        }

        private void UpdateLocalServiceStatus2(int localServiceId, string status)
        {
            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE local_service SET status = @Status WHERE localService_id = @LocalServiceId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@LocalServiceId", localServiceId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Local Service with ID: {localServiceId} is now On-Progress!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update local service status.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating local service status: " + ex.Message);
                }
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            LocalServicesDoneForm doneForm = new LocalServicesDoneForm(localServiceId);
            doneForm.ShowDialog();
        }
    }
}
