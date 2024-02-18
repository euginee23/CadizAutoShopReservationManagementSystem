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

namespace CadizAutoShopManagementSystem.Forms
{
    public partial class CancelReservationForm : Form
    {
        private int reservationId;

        public CancelReservationForm(int reservationId)
        {
            InitializeComponent();
            this.reservationId = reservationId;
            reservationId_txt.Text = reservationId.ToString();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            string cancelReason = cancelReason_txt.Text.Trim();

            if (string.IsNullOrEmpty(cancelReason))
            {
                MessageBox.Show("Please provide a cancel reason.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string updateReservationQuery = "UPDATE reservations " +
                                                    "SET status = 'Cancelled', message = @cancelReason " +
                                                    "WHERE reservation_id = @reservationId";

                    using (MySqlCommand cmd = new MySqlCommand(updateReservationQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@reservationId", reservationId);
                        cmd.Parameters.AddWithValue("@cancelReason", cancelReason);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Reservation has been cancelled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

