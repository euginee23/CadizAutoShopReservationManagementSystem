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
    public partial class MechanicProfileForm : Form
    {
        private int mechanic_Id;
        private decimal totalPayoutAmount = 0;

        public MechanicProfileForm(int mechanicId)
        {
            InitializeComponent();
            this.mechanic_Id = mechanicId;

            mechanicId_lbl.Text = mechanic_Id.ToString();
        }

        private void MechanicProfileForm_Load(object sender, EventArgs e)
        {
            RetrieveMechanicInfo();
            RetrieveWorkHistory();
        }

        private void RetrieveMechanicInfo()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT firstName, lastName, address, contactNumber, specialization " +
                                         "FROM mechanic_info " +
                                         "WHERE mechanic_id = @mechanicId";

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@mechanicId", mechanic_Id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["firstName"].ToString();
                                string lastName = reader["lastName"].ToString();
                                string address = reader["address"].ToString();
                                string contactNumber = reader["contactNumber"].ToString();
                                string specialization = reader["specialization"].ToString();

                                mechanicName_lbl.Text = $"{firstName} {lastName}";
                                addressPhone_lbl.Text = $"{address}, {contactNumber}";
                                specialization_lbl.Text = specialization;
                            }
                            else
                            {
                                MessageBox.Show("Mechanic not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close(); 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving mechanic information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RetrieveWorkHistory()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT created_at, workType, CONCAT('₱ ', totalCost) AS totalCost, CONCAT('₱ ', payAmount) AS payAmount " +
                                         "FROM mechanic_work_history " +
                                         "WHERE mechanic_id = @mechanicId";

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@mechanicId", mechanic_Id);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            workHistoryDataGrid.DataSource = dataTable;

                            totalPayoutAmount = dataTable.AsEnumerable()
                                .Sum(row => Convert.ToDecimal(row["payAmount"].ToString().Substring(1)));

                            totalPayout_lbl.Text = totalPayoutAmount.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving work history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PayOut(decimal payAmount)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO mechanic_payout (mechanic_id, pay_date, pay_amount) " +
                                         "VALUES (@mechanicId, @payDate, @payAmount)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@mechanicId", mechanic_Id);
                        cmd.Parameters.AddWithValue("@payDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@payAmount", payAmount);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Payout successfully recorded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    string deleteQuery = "DELETE FROM mechanic_work_history WHERE mechanic_id = @mechanicId";

                    using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@mechanicId", mechanic_Id);
                        deleteCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recording payout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void billing_button_Click(object sender, EventArgs e)
        {
            PayOut(totalPayoutAmount);

            RetrieveMechanicInfo();
            RetrieveWorkHistory();
        }
    }
}

