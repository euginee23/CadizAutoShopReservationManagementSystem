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
using CadizAutoShopManagementSystem.UserControlForms;

namespace CadizAutoShopManagementSystem.Forms
{
    public partial class ApprovingReservationForm : Form
    {
        private int reservationId;
        public int SelectedMechanicId { get; private set; }
        public ApprovingReservationForm(int reservationId)
        {
            InitializeComponent();
            this.reservationId = reservationId;
            reservationId_txt.Text = reservationId.ToString();
            PopulateReservationDetails(reservationId);
            PopulateMechanicComboBox();
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
                                serviceType_txt.Text = reader["serviceType"].ToString();
                                vehicleDetails_txt.Text = reader["vehicleName"].ToString();
                                problemDescription_txt.Text = reader["problem_description"].ToString();
                                date_txt.Text = Convert.ToDateTime(reader["date"]).ToString("yyyy-MM-dd");
                                time_txt.Text = ((TimeSpan)reader["time"]).ToString();
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

        private void PopulateMechanicComboBox()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT mechanic_id, CONCAT(firstName, ' ', lastName) AS mechanicName, CONCAT ('(', specialization, ')') AS mechanicSpecialization FROM mechanic_info";

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<string> mechanicOptions = new List<string>();

                            while (reader.Read())
                            {
                                int mechanicId = Convert.ToInt32(reader["mechanic_id"]);
                                string mechanicName = reader["mechanicName"].ToString();
                                string mechanicSpecizalization = reader["mechanicSpecialization"].ToString();

                                mechanicOptions.Add(mechanicName + ' ' + mechanicSpecizalization);

                                selectMechanic_cmbx.Tag = mechanicId;
                            }

                            selectMechanic_cmbx.DataSource = mechanicOptions;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void approve_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string updateStatusQuery = "UPDATE reservations SET status = 'Approved' WHERE reservation_id = @reservationId";

                    using (MySqlCommand statusCmd = new MySqlCommand(updateStatusQuery, connection))
                    {
                        statusCmd.Parameters.AddWithValue("@reservationId", reservationId);
                        statusCmd.ExecuteNonQuery();
                    }

                    if (selectMechanic_cmbx.Tag is int selectedMechanicId)
                    {
                        string updateMechanicQuery = "UPDATE reservations SET assigned_mechanic = @mechanicId WHERE reservation_id = @reservationId";

                        using (MySqlCommand mechanicCmd = new MySqlCommand(updateMechanicQuery, connection))
                        {
                            mechanicCmd.Parameters.AddWithValue("@reservationId", reservationId);
                            mechanicCmd.Parameters.AddWithValue("@mechanicId", selectedMechanicId);
                            mechanicCmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Reservation approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
