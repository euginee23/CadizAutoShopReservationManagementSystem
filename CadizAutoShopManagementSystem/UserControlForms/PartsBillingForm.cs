using CadizAutoShopManagementSystem.Components;
using CadizAutoShopManagementSystem.Forms;
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

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class PartsBillingForm : UserControl
    {
        private LoadingStateForm loadingForm;

        public PartsBillingForm()
        {
            ShowLoadingForm();
            InitializeComponent();
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

        public class PartsBillingInfo
        {
            public int PartId { get; set; }
            public string PartName { get; set; }
            public int Quantity { get; set; }
            public decimal TotalCost { get; set; }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            billingPanelContainer.Controls.Clear();
            billingPanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void billingPanelContainer_Paint(object sender, PaintEventArgs e)
        {
            DataGridFillTransaction();
        }

        private void DataGridFillTransaction()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT DISTINCT transaction_id FROM parts_billing_queue";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable transactionTable = new DataTable();
                        adapter.Fill(transactionTable);

                        transactionSelectDataGrid.DataSource = transactionTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transaction IDs: {ex.Message}");
            }

        }

        private void getTransactionID_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = transactionSelectDataGrid.Rows[e.RowIndex];
                string selectedTransactionId = selectedRow.Cells["transaction_idColumn"].Value.ToString();
                transactionId_txt.Text = selectedTransactionId;

                getPartsByTransactionID(sender, e);
            }
        }

        private void getPartsByTransactionID(object sender, EventArgs e)
        {
            List<PartsBillingInfo> mergedPartsList = new List<PartsBillingInfo>();
            mergedPartsList.Clear();
            string transactionId = transactionId_txt.Text;

            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT part_id, part_name, quantity, total_cost FROM parts_billing_queue WHERE transaction_id = @transactionId";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int partId = reader.GetInt32("part_id");
                                string partName = reader.GetString("part_name");
                                int quantity = reader.GetInt32("quantity");
                                decimal totalCost = reader.GetDecimal("total_cost");

                                PartsBillingInfo existingPart = mergedPartsList.FirstOrDefault(p => p.PartId == partId);

                                if (existingPart != null)
                                {
                                    existingPart.Quantity += quantity;
                                    existingPart.TotalCost += totalCost;
                                }
                                else
                                {
                                    mergedPartsList.Add(new PartsBillingInfo
                                    {
                                        PartId = partId,
                                        PartName = partName,
                                        Quantity = quantity,
                                        TotalCost = totalCost
                                    });
                                }
                            }
                        }
                    }
                }

                TotalCostForParts();
                partsBillingDataGrid.DataSource = mergedPartsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading parts billing data: {ex.Message}");
            }
        }
        private void TotalCostForParts()
        {
            decimal totalCost = 0;

            foreach (DataGridViewRow row in partsBillingDataGrid.Rows)
            {
                if (row.Cells["total_costColumn"].Value != null && decimal.TryParse(row.Cells["total_costColumn"].Value.ToString(), out decimal partCost))
                {
                    totalCost += partCost;
                }
            }

            totalCost_txt.Text = totalCost.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
        }

        private List<PartsBillingInfo> GetPartsData()
        {
            List<PartsBillingInfo> partsData = new List<PartsBillingInfo>();

            foreach (DataGridViewRow row in partsBillingDataGrid.Rows)
            {
                if (row.Cells["partNameColumn"].Value != null &&
                    row.Cells["quantityColumn"].Value != null &&
                    row.Cells["total_costColumn"].Value != null)
                {
                    string partName = row.Cells["partNameColumn"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["quantityColumn"].Value);
                    decimal totalCost = Convert.ToDecimal(row.Cells["total_costColumn"].Value);

                    partsData.Add(new PartsBillingInfo { PartName = partName, Quantity = quantity, TotalCost = totalCost });
                }
            }

            return partsData;
        }

        private void invoice_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstName_txt.Text) ||
                string.IsNullOrEmpty(lastName_txt.Text) ||
                string.IsNullOrEmpty(address_txt.Text) ||
                string.IsNullOrEmpty(transactionId_txt.Text) ||
                string.IsNullOrEmpty(totalCost_txt.Text))
                    {
                MessageBox.Show("Please select a transaction and ensure all required fields are filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the necessary data
            string customerName = $"{firstName_txt.Text} {lastName_txt.Text}";
            string customerAddress = address_txt.Text;
            string transactionId = transactionId_txt.Text;
            string totalCost = totalCost_txt.Text;

            // Create an instance of PartsInvoiceForm and pass the data
            PartsInvoiceForm partsInvoiceForm = new PartsInvoiceForm(customerName, customerAddress, transactionId, totalCost, GetPartsData());

            // Show the PartsInvoiceForm
            partsInvoiceForm.ShowDialog();
        }
    }
}
