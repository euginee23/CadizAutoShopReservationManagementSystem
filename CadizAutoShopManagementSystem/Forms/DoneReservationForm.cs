using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadizAutoShopManagementSystem.Forms
{
    public partial class DoneReservationForm : Form
    {
        private int reservationId;
        private decimal laborCost;
        private decimal extraExpenses = 0;

        public DoneReservationForm(int reservationId)
        {
            InitializeComponent();
            this.reservationId = reservationId;
        }

        private void DoneReservationForm_Load(object sender, EventArgs e)
        {
            RetrieveReservationDetails();
            CalculateTotalPrice();
        }

        // RETRIEVAL OF RESERVATION DETAILS
        private void RetrieveReservationDetails()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT s.laborCost, " +
                                         "c.customer_id, c.firstName AS customerFirstName, c.lastName AS customerLastName, " +
                                         "s.serviceType, " +
                                         "v.vehicle_id, v.make, v.model, v.year, v.vehicle_type, v.plate_number, " +
                                         "m.mechanic_id, m.firstName AS mechanicFirstName, m.lastName AS mechanicLastName " +
                                         "FROM reservations r " +
                                         "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                         "INNER JOIN services s ON r.service_id = s.service_id " +
                                         "INNER JOIN customer_vehicles v ON r.vehicle_id = v.vehicle_id " +
                                         "INNER JOIN mechanic_info m ON r.assigned_mechanic = m.mechanic_id " +
                                         "WHERE r.reservation_id = @reservationId";

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@reservationId", reservationId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                laborCost = Convert.ToDecimal(reader["laborCost"]);

                                int customerId = Convert.ToInt32(reader["customer_id"]);
                                string customerFirstName = reader["customerFirstName"].ToString();
                                string customerLastName = reader["customerLastName"].ToString();

                                int mechanicId = Convert.ToInt32(reader["mechanic_id"]);
                                string mechanicFirstName = reader["mechanicFirstName"].ToString();
                                string mechanicLastName = reader["mechanicLastName"].ToString();

                                laborCostTextBox.Text = laborCost.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
                                customerTextBox.Text = $"{customerFirstName} {customerLastName}";
                                serviceTypeTextBox.Text = reader["serviceType"].ToString();
                                vehicleTextBox.Text = $"{reader["make"]} {reader["model"]} {reader["year"]}";
                                mechanicTextBox.Text = $"{mechanicFirstName} {mechanicLastName}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving reservation details: {ex.Message}");
            }
        }

        // CALCULATION OF TOTAL PRICE
        private void CalculateTotalPrice()
        {
            try
            {
                decimal totalPrice = laborCost + extraExpenses;
                totalPriceTextBox.Text = totalPrice.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total price: {ex.Message}");
            }
        }

        // NUMERIC UP AND DOWN TEXT CHANGED
        private void extraExpensesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            extraExpenses = extraExpensesNumericUpDown.Value;
            CalculateTotalPrice();
        }

        // ADD TO BILLING QUEUE AND UPDATE RESERVATION STATUS TO DONE
        private void addToBilling_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string extraExpenseReason = extraExpenseReason_txt.Text;
                    decimal extraExpenseCost = extraExpensesNumericUpDown.Value;

                    decimal totalCost = laborCost + extraExpenseCost;

                    // Retrieve mechanic_id
                    int mechanicId = 0;
                    string selectMechanicIdQuery = "SELECT assigned_mechanic FROM reservations WHERE reservation_id = @reservationId";
                    using (MySqlCommand cmdMechanicId = new MySqlCommand(selectMechanicIdQuery, connection))
                    {
                        cmdMechanicId.Parameters.AddWithValue("@reservationId", reservationId);

                        object result = cmdMechanicId.ExecuteScalar();
                        if (result != null)
                        {
                            mechanicId = Convert.ToInt32(result);
                        }
                    }

                    // Calculate mechanic payout (60% of the totalCost)
                    decimal mechanicPayout = 0.6m * totalCost;

                    // Insert billing information into billing_queue table
                    string insertQuery = "INSERT INTO billing_queue (reservation_id, extraExpense_reason, extraExpense_cost, total_cost) " +
                                         "VALUES (@reservationId, @extraExpenseReason, @extraExpenseCost, @totalCost)";

                    using (MySqlCommand cmdInsert = new MySqlCommand(insertQuery, connection))
                    {
                        cmdInsert.Parameters.AddWithValue("@reservationId", reservationId);
                        cmdInsert.Parameters.AddWithValue("@extraExpenseReason", extraExpenseReason);
                        cmdInsert.Parameters.AddWithValue("@extraExpenseCost", extraExpenseCost);
                        cmdInsert.Parameters.AddWithValue("@totalCost", totalCost);

                        cmdInsert.ExecuteNonQuery();
                    }

                    // Insert mechanic payout information into mechanic_work_history table
                    string insertPayoutQuery = "INSERT INTO mechanic_work_history (mechanic_id, totalCost, payAmount) " +
                                               "VALUES (@mechanicId, @totalCost, @payoutAmount)";

                    using (MySqlCommand cmdInsertPayout = new MySqlCommand(insertPayoutQuery, connection))
                    {
                        cmdInsertPayout.Parameters.AddWithValue("@mechanicId", mechanicId);
                        cmdInsertPayout.Parameters.AddWithValue("@totalCost", totalCost);
                        cmdInsertPayout.Parameters.AddWithValue("@payoutAmount", mechanicPayout);
                        
                        cmdInsertPayout.ExecuteNonQuery();
                    }

                    // Update reservation status to 'Done'
                    string updateStatusQuery = "UPDATE reservations SET status = 'Done' WHERE reservation_id = @reservationId";

                    using (MySqlCommand cmdUpdateStatus = new MySqlCommand(updateStatusQuery, connection))
                    {
                        cmdUpdateStatus.Parameters.AddWithValue("@reservationId", reservationId);
                        cmdUpdateStatus.ExecuteNonQuery();
                    }

                    MessageBox.Show("Billing information added to queue successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding billing information to queue: {ex.Message}");
            }
        }
    }
}
