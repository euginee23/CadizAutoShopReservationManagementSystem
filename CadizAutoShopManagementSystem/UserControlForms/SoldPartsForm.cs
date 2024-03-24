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
using CadizAutoShopManagementSystem.Components;
using MySql.Data.MySqlClient;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class SoldPartsForm : UserControl
    {
        private LoadingStateForm loadingForm;

        public SoldPartsForm()
        {
            InitializeComponent();
        }

        private void SoldPartsForm_Load(object sender, EventArgs e)
        {
            ShowLoadingForm();
            LoadPartsData();
            transactionId_txt.Text = GenerateTransactionId();
            quantity_txt.Text = "1";
            PopulateCarModelsComboBox();
            CloseLoadingForm();
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

        // FILL THE DATA GRID WITH PARTS FROM THE INVENTORY
        private void LoadPartsData()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT part_id, part_number, part_name, part_model, price, availability FROM parts_inventory";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        partsDataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // DATAGRID CLICK FUNCTION TEXTBOX POPULATE
        private void getPartClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = partsDataGridView.Rows[e.RowIndex];

                partId_txt.Text = selectedRow.Cells["PartIdColumn"].Value.ToString();
                partNumber_txt.Text = selectedRow.Cells["PartNumberColumn"].Value.ToString();
                partName_txt.Text = selectedRow.Cells["PartNameColumn"].Value.ToString();
                partModel_txt.Text = selectedRow.Cells["PartModelColumn"].Value.ToString();
                partPrice_txt.Text = selectedRow.Cells["PriceColumn"].Value.ToString();
                partAvailability_txt.Text = selectedRow.Cells["AvailabilityColumn"].Value.ToString();
            }
        }

        // ADD TO CART BUTTON CLICK
        private void addToCart_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(partId_txt.Text))
            {
                MessageBox.Show("Please select a part before adding to the cart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(quantity_txt.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int availability = int.Parse(partAvailability_txt.Text);

            if (quantity > availability)
            {
                MessageBox.Show("Quantity exceeds availability.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int partId = int.Parse(partId_txt.Text);
            decimal partPrice = decimal.Parse(partPrice_txt.Text, CultureInfo.GetCultureInfo("en-PH"));
            decimal totalCost = partPrice * quantity;

            DataGridViewRow existingRow = null;

            foreach (DataGridViewRow row in cartDataGridView.Rows)
            {
                if (row.Tag != null && (int)row.Tag == partId)
                {
                    existingRow = row;
                    break;
                }
            }

            if (existingRow != null)
            {
                int existingQuantity = (int)existingRow.Cells["Quantity"].Value;
                decimal existingTotalCost = (decimal)existingRow.Cells["TotalCost"].Value;

                if (existingQuantity + quantity > availability)
                {
                    MessageBox.Show("Maximum quantity reached.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                existingRow.Cells["Quantity"].Value = existingQuantity + quantity;
                existingRow.Cells["TotalCost"].Value = existingTotalCost + totalCost;
            }
            else
            {
                if (quantity > availability)
                {
                    MessageBox.Show("Maximum quantity reached.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow cartRow = new DataGridViewRow();
                cartRow.CreateCells(cartDataGridView, partName_txt.Text, quantity, totalCost);
                cartRow.Tag = partId;
                cartDataGridView.Rows.Add(cartRow);
            }

            UpdateTotalCost();
        }

        // TOTAL COST CALCULATION
        private void UpdateTotalCost()
        {
            decimal totalCost = 0;

            foreach (DataGridViewRow row in cartDataGridView.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    totalCost += Convert.ToDecimal(row.Cells[2].Value);
                }
            }

            totalPrice_txt.Text = totalCost.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
        }

        // TRANSACTION ID GENERATION
        private string GenerateTransactionId()
        {
            Random rand = new Random();
            return rand.Next(100000000, 999999999).ToString();
        }

        // ADD TO BILLING QUEUE BUTTON CLICK
        private void billingQueue_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(totalPrice_txt.Text))
                {
                    MessageBox.Show("Please add parts to the cart before proceeding to billing queue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string transactionId = GenerateTransactionId();

                    foreach (DataGridViewRow row in cartDataGridView.Rows)
                    {
                        if (row.Tag != null && row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                        {
                            int partId = Convert.ToInt32(row.Tag);
                            string partName = row.Cells[0].Value.ToString();
                            int quantity = Convert.ToInt32(row.Cells[1].Value);
                            decimal totalCost = Convert.ToDecimal(row.Cells[2].Value);

                            string insertQuery = "INSERT INTO parts_billing_queue (transaction_id, part_id, part_name, quantity, total_cost) " +
                                                 "VALUES (@transactionId, @partId, @partName, @quantity, @totalCost)";

                            using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@transactionId", transactionId);
                                cmd.Parameters.AddWithValue("@partId", partId);
                                cmd.Parameters.AddWithValue("@partName", partName);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.Parameters.AddWithValue("@totalCost", totalCost);

                                cmd.ExecuteNonQuery();
                            }

                            string updateAvailabilityQuery = "UPDATE parts_inventory " +
                                                             "SET availability = availability - @quantity " +
                                                             "WHERE part_id = @partId";

                            using (MySqlCommand updateCmd = new MySqlCommand(updateAvailabilityQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@partId", partId);
                                updateCmd.Parameters.AddWithValue("@quantity", quantity);

                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Parts added to billing queue successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving parts to billing queue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SEARCH FUNCTION
        private void searchPart_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchPart_txt.Text.Trim();

            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT part_id, part_number, part_name, part_model, price, availability " +
                                   "FROM parts_inventory " +
                                   "WHERE part_number LIKE @searchTerm OR " +
                                   "part_name LIKE @searchTerm OR " +
                                   "part_model LIKE @searchTerm";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            partsDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // COMBOBOX POPULATION
        private void PopulateCarModelsComboBox()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT DISTINCT part_model FROM parts_inventory";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string carModel = reader["part_model"].ToString();
                            filterPart_cmbx.Items.Add(carModel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating car models: {ex.Message}");
            }
        }

        // FILTER BY MODEL FUNCTION
        private void filterPart_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModel = filterPart_cmbx.SelectedItem?.ToString();

            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT part_id, part_number, part_name, part_model, price, availability " +
                                   "FROM parts_inventory " +
                                   "WHERE part_model = @selectedModel";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@selectedModel", selectedModel);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            partsDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering parts by model: {ex.Message}");
            }
        }

        // SHOW ALL PARTS BUTTON CLICK
        private void showAll_btn_Click(object sender, EventArgs e)
        {
            LoadPartsData();
        }

        // DELETE PART ON CART FUNCTION
        private void deletePart_ContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cartDeleteColumn.Index && e.RowIndex >= 0)
            {
                cartDataGridView.Rows.RemoveAt(e.RowIndex);
                UpdateTotalCost();
            }
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(quantity_txt.Text, out int quantity))
            {
                quantity++;
                quantity_txt.Text = quantity.ToString();
                UpdateTotalCost();
            }
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(quantity_txt.Text, out int quantity) && quantity > 1)
            {
                quantity--;
                quantity_txt.Text = quantity.ToString();
                UpdateTotalCost();
            }
        }
    }
}
