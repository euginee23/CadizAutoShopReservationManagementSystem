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
    public partial class ServiceBillingForm : UserControl
    {
        private LoadingStateForm loadingForm;

        public ServiceBillingForm()
        {
            ShowLoadingForm();
            InitializeComponent();
            LoadServiceBillingQueueData();
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

        private void LoadServiceBillingQueueData()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT b.billing_id, b.localService_id, " +
                                   "CONCAT(c.firstName, ' ', c.lastName) AS customer_name, " +
                                   "s.serviceType, " +
                                   "b.extraExpense_reason, b.extraExpense_cost, b.total_cost " +
                                   "FROM local_service_billing_queue b " +
                                   "INNER JOIN local_service r ON b.localService_id = r.localService_id " +
                                   "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                   "INNER JOIN services s ON r.service_id = s.service_id";


                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        serviceBillingDataGridView.DataSource = dataTable;
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
                DataGridViewRow selectedRow = serviceBillingDataGridView.Rows[e.RowIndex];

                serviceId_txt.Text = selectedRow.Cells["reservation_id"].Value.ToString();
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
            if (string.IsNullOrEmpty(serviceId_txt.Text) ||
                string.IsNullOrEmpty(billingId_txt.Text) ||
                string.IsNullOrEmpty(customerName_txt.Text) ||
                string.IsNullOrEmpty(serviceType_txt.Text) ||
                string.IsNullOrEmpty(totalCost_txt.Text))
            {
                MessageBox.Show("Please select billing information before generating the invoice.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string serviceId = serviceId_txt.Text;
            string billingId = billingId_txt.Text;
            string customerName = customerName_txt.Text;
            string serviceType = serviceType_txt.Text;
            string extraExpenseReason = extraExpenseReason_txt.Text;
            string extraExpenseCost = extraExpenseCost_txt.Text;
            string totalCost = totalCost_txt.Text;

            ServiceInvoiceForm invoiceFrm = new ServiceInvoiceForm(serviceId, billingId, customerName, serviceType, extraExpenseReason, extraExpenseCost, totalCost);
            invoiceFrm.ShowDialog();
            LoadServiceBillingQueueData();
        }
    }
}
