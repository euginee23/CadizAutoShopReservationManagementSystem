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
    public partial class DecliningReservationForm : Form
    {
        private int reservationId;

        public DecliningReservationForm(int reservationId)
        {
            InitializeComponent();

            this.reservationId = reservationId;
            reservationId_txt.Text = reservationId.ToString();
            PopulateReservationDetails(reservationId);
        }

        private void PopulateReservationDetails(int reservationId)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT r.reservation_id, r.problem_description, r.date, r.time, " +
                                         "CONCAT(c.firstName, ' ', c.lastName) AS customerName, " +
                                         "s.serviceType AS serviceType, " +
                                         "CONCAT(v.make, ' ', v.model, ' ', v.year) AS vehicleName " +
                                         "FROM reservations r " +
                                         "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                         "INNER JOIN services s ON r.service_id = s.service_id " +
                                         "INNER JOIN customer_vehicles v ON r.vehicle_id = v.vehicle_id " +
                                         "WHERE r.reservation_id = @reservationId";

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@reservationId", reservationId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                customerName_txt.Text = reader["customerName"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Reservation not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void declining_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();
                    string updateQuery = "UPDATE reservations SET status = 'Declined', message = @declineReason WHERE reservation_id = @reservationId";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@reservationId", reservationId);
                        cmd.Parameters.AddWithValue("@declineReason", declineReason_txt.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Reservation declined successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
