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
using CadizAutoShopManagementSystem.Components;

namespace CadizAutoShopManagementSystem.Forms
{
    public partial class AssignNewMechanicForm : Form
    {
        private LoadingStateForm loadingForm;
        private int reservationId;

        public AssignNewMechanicForm(int reservationId)
        {
            InitializeComponent();
            this.reservationId = reservationId;
            reservationId_txt.Text = reservationId.ToString();
            PopulateReservationDetails(reservationId);
            PopulateMechanicComboBox();
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

        public class MechanicItem
        {
            public int MechanicId { get; }
            public string DisplayText { get; }
            public int Id { get; internal set; }

            public MechanicItem(int mechanicId, string displayText)
            {
                MechanicId = mechanicId;
                DisplayText = displayText;
            }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void PopulateMechanicComboBox()
        {
            selectMechanic_cmbx.Items.Clear();

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT mechanic_id, firstName, lastName, specialization FROM mechanic_info";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int mechanicId = reader.GetInt32("mechanic_id");
                                string firstName = reader.GetString("firstName");
                                string lastName = reader.GetString("lastName");
                                string specialization = reader.GetString("specialization");

                                string displayText = $"{firstName} {lastName} ({specialization})";

                                MechanicItem mechanicItem = new MechanicItem(mechanicId, displayText);

                                selectMechanic_cmbx.Items.Add(mechanicItem);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading mechanics: " + ex.Message);
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ShowLoadingForm();
                MechanicItem selectedMechanic = selectMechanic_cmbx.SelectedItem as MechanicItem;

                if (selectedMechanic == null)
                {
                    MessageBox.Show("Please select a mechanic.");
                    return;
                }

                int mechanicId = selectedMechanic.MechanicId;

                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string updateStatusQuery = "UPDATE reservations SET status = 'Approved', assigned_mechanic = @mechanicId WHERE reservation_id = @reservationId";

                    using (MySqlCommand statusCmd = new MySqlCommand(updateStatusQuery, connection))
                    {
                        statusCmd.Parameters.AddWithValue("@reservationId", reservationId);
                        statusCmd.Parameters.AddWithValue("@mechanicId", mechanicId);
                        statusCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Reservation approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                CloseLoadingForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
