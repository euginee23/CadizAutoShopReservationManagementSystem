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
    }
}
