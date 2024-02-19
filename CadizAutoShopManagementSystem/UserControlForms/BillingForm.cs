using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using CadizAutoShopManagementSystem.Forms;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class BillingForm : UserControl
    {
        public BillingForm()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            billingPanelContainer.Controls.Clear();
            billingPanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void partsBilling_btn_Click(object sender, EventArgs e)
        {
            PartsBillingForm partsBill = new PartsBillingForm();
            addUserControl(partsBill);
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            LoadReservationsBillingQueueData();
        }

        private void LoadReservationsBillingQueueData()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT b.billing_id, b.reservation_id, " +
                                   "CONCAT(c.firstName, ' ', c.lastName) AS customer_name, " +
                                   "s.serviceType, " +
                                   "b.extraExpense_reason, b.extraExpense_cost, b.total_cost " +
                                   "FROM billing_queue b " +
                                   "INNER JOIN reservations r ON b.reservation_id = r.reservation_id " +
                                   "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                   "INNER JOIN services s ON r.service_id = s.service_id";


                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        reservationBillingDataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservation billing data: {ex.Message}");
            }
        }

        private void getBillingInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = reservationBillingDataGridView.Rows[e.RowIndex];

                reservationId_txt.Text = selectedRow.Cells["reservation_id"].Value.ToString();
                billingId_txt.Text = selectedRow.Cells["billing_id"].Value.ToString();
                customerName_txt.Text = selectedRow.Cells["customer_name"].Value.ToString();
                serviceType_txt.Text = selectedRow.Cells["serviceType"].Value.ToString();
                extraExpenseReason_txt.Text = selectedRow.Cells["extraExpense_reason"].Value.ToString();
                extraExpenseCost_txt.Text = selectedRow.Cells["extraExpense_cost"].Value.ToString();
                totalCost_txt.Text = Convert.ToDecimal(selectedRow.Cells["total_cost"].Value).ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            }
        }

        private void invoice_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(reservationId_txt.Text) ||
                string.IsNullOrEmpty(billingId_txt.Text) ||
                string.IsNullOrEmpty(customerName_txt.Text) ||
                string.IsNullOrEmpty(serviceType_txt.Text) ||
                string.IsNullOrEmpty(totalCost_txt.Text))
            {
                MessageBox.Show("Please select billing information before generating the invoice.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reservationId = reservationId_txt.Text;
            string billingId = billingId_txt.Text;
            string customerName = customerName_txt.Text;
            string serviceType = serviceType_txt.Text;
            string extraExpenseReason = extraExpenseReason_txt.Text;
            string extraExpenseCost = extraExpenseCost_txt.Text;
            string totalCost = totalCost_txt.Text;

            InvoiceForm invoiceFrm = new InvoiceForm(reservationId, billingId, customerName, serviceType, extraExpenseReason, extraExpenseCost, totalCost);
            invoiceFrm.ShowDialog();
            LoadReservationsBillingQueueData();
        }
    }
}
