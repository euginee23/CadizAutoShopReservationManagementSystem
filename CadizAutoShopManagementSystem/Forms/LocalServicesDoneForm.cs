using MySql.Data.MySqlClient;
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


namespace CadizAutoShopManagementSystem.Forms
{
    public partial class LocalServicesDoneForm : Form
    {
        private decimal laborCost;
        private int localServiceId;
        private decimal extraExpenses = 0;

        public LocalServicesDoneForm(int localServiceId)
        {
            InitializeComponent();
            this.localServiceId = localServiceId;
            RetrieveServiceDetails();
            CalculateTotalPrice();
        }

        private void RetrieveServiceDetails()
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
                                         "FROM local_service r " +
                                         "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                         "INNER JOIN services s ON r.service_id = s.service_id " +
                                         "INNER JOIN customer_vehicles v ON r.vehicle_id = v.vehicle_id " +
                                         "INNER JOIN mechanic_info m ON r.assigned_mechanic = m.mechanic_id " +
                                         "WHERE r.localService_id = @localServiceId";

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@localServiceId", localServiceId);

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
                    string selectMechanicIdQuery = "SELECT assigned_mechanic FROM local_service WHERE localService_id = @localServiceId";
                    using (MySqlCommand cmdMechanicId = new MySqlCommand(selectMechanicIdQuery, connection))
                    {
                        cmdMechanicId.Parameters.AddWithValue("@localServiceId", localServiceId);

                        object result = cmdMechanicId.ExecuteScalar();
                        if (result != null)
                        {
                            mechanicId = Convert.ToInt32(result);
                        }
                    }

                    // Calculate mechanic payout (60% of the totalCost)
                    decimal mechanicPayout = 0.6m * totalCost;

                    // Insert billing information into billing_queue table
                    string insertQuery = "INSERT INTO local_service_billing_queue (localService_id, extraExpense_reason, extraExpense_cost, total_cost) " +
                                         "VALUES (@localServiceId, @extraExpenseReason, @extraExpenseCost, @totalCost)";

                    using (MySqlCommand cmdInsert = new MySqlCommand(insertQuery, connection))
                    {
                        cmdInsert.Parameters.AddWithValue("@localServiceId", localServiceId);
                        cmdInsert.Parameters.AddWithValue("@extraExpenseReason", extraExpenseReason);
                        cmdInsert.Parameters.AddWithValue("@extraExpenseCost", extraExpenseCost);
                        cmdInsert.Parameters.AddWithValue("@totalCost", totalCost);

                        cmdInsert.ExecuteNonQuery();
                    }

                    // Insert mechanic payout information into mechanic_work_history table
                    string insertPayoutQuery = "INSERT INTO mechanic_work_history (mechanic_id, workType, totalCost, payAmount) " +
                                               "VALUES (@mechanicId, 'Local Service', @totalCost, @payoutAmount)";

                    using (MySqlCommand cmdInsertPayout = new MySqlCommand(insertPayoutQuery, connection))
                    {
                        cmdInsertPayout.Parameters.AddWithValue("@mechanicId", mechanicId);
                        cmdInsertPayout.Parameters.AddWithValue("@totalCost", totalCost);
                        cmdInsertPayout.Parameters.AddWithValue("@payoutAmount", mechanicPayout);

                        cmdInsertPayout.ExecuteNonQuery();
                    }

                    // Update reservation status to 'Done'
                    string updateStatusQuery = "UPDATE local_service SET status = 'Done' WHERE localService_id = @localServiceId";

                    using (MySqlCommand cmdUpdateStatus = new MySqlCommand(updateStatusQuery, connection))
                    {
                        cmdUpdateStatus.Parameters.AddWithValue("@localServiceId", localServiceId);
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
