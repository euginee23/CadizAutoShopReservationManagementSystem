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
    public partial class ReservationBillingForm : UserControl
    {
        private LoadingStateForm loadingForm;

        public ReservationBillingForm()
        {
            InitializeComponent();
        }

        private void ReservationBillingForm_Load(object sender, EventArgs e)
        {
            ShowLoadingForm();
            LoadReservationsBillingQueueData();
            PopulateServiceTypeComboBox();
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

        private void PopulateServiceTypeComboBox()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT serviceType FROM services";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string serviceType = reader["serviceType"].ToString();
                                serviceType_cmbx.Items.Add(serviceType);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating service type combo box: " + ex.Message);
            }
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

        private void serviceSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (serviceType_cmbx.Focused)
                {
                    string selectedService = serviceType_cmbx.SelectedItem?.ToString();

                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string selectQuery = "SELECT b.billing_id, b.reservation_id, " +
                                             "CONCAT(c.firstName, ' ', c.lastName) AS customer_name, " +
                                             "s.serviceType, " +
                                             "b.extraExpense_reason, b.extraExpense_cost, b.total_cost " +
                                             "FROM billing_queue b " +
                                             "INNER JOIN reservations r ON b.reservation_id = r.reservation_id " +
                                             "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                             "INNER JOIN services s ON r.service_id = s.service_id";

                        if (!string.IsNullOrEmpty(selectedService))
                        {
                            selectQuery += " AND s.serviceType = @selectedService";
                        }

                        using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                        {
                            if (!string.IsNullOrEmpty(selectedService))
                            {
                                cmd.Parameters.AddWithValue("@selectedService", selectedService);
                            }

                            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable filteredDataTable = new DataTable();
                                dataAdapter.Fill(filteredDataTable);

                                reservationBillingDataGridView.DataSource = filteredDataTable;
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

        private void searchTextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = searchTextbox.Text.Trim();

                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT b.billing_id, b.reservation_id, " +
                                         "CONCAT(c.firstName, ' ', c.lastName) AS customer_name, " +
                                         "s.serviceType, " +
                                         "b.extraExpense_reason, b.extraExpense_cost, b.total_cost " +
                                         "FROM billing_queue b " +
                                         "INNER JOIN reservations r ON b.reservation_id = r.reservation_id " +
                                         "INNER JOIN customer_info c ON r.customer_id = c.customer_id " +
                                         "INNER JOIN services s ON r.service_id = s.service_id " +
                                         "WHERE CONCAT(c.firstName, ' ', c.lastName) LIKE @searchText " +
                                         "OR s.serviceType LIKE @searchText";

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable filteredDataTable = new DataTable();
                            dataAdapter.Fill(filteredDataTable);

                            reservationBillingDataGridView.DataSource = filteredDataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
