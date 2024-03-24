using ClosedXML.Excel;
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
    public partial class MechanicPayoutReportsForm : UserControl
    {
        public MechanicPayoutReportsForm()
        {
            InitializeComponent();
            LoadPayoutReports();
            PopulateSpecializationComboBox();
        }

        private void PopulateSpecializationComboBox()
        {
            specialization_cmbx.Items.Add("Engine Repair");
            specialization_cmbx.Items.Add("Transmission Repair");
            specialization_cmbx.Items.Add("Brake System Repair");
            specialization_cmbx.Items.Add("Suspension and Steering");
            specialization_cmbx.Items.Add("Electrical Systems");
            specialization_cmbx.Items.Add("HVAC (Heating, Ventilation, and Air Conditioning)");
            specialization_cmbx.Items.Add("Diagnostic Technician");
            specialization_cmbx.Items.Add("Tire and Wheel Service");
            specialization_cmbx.Items.Add("Exhaust System Repair");
            specialization_cmbx.Items.Add("Auto Body Repair");
        }

        private void LoadPayoutReports()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT CONCAT(firstName, ' ', lastName, ' - ', specialization) AS MechanicInfo, contactNumber, address, pay_date, pay_amount " +
                                   "FROM mechanic_payout " +
                                   "INNER JOIN mechanic_info ON mechanic_payout.mechanic_id = mechanic_info.mechanic_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            payoutReportsDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payout reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterPayoutReportsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT CONCAT(firstName, ' ', lastName, ' - ', specialization) AS MechanicInfo, contactNumber, address, pay_date, pay_amount " +
                                   "FROM mechanic_payout " +
                                   "INNER JOIN mechanic_info ON mechanic_payout.mechanic_id = mechanic_info.mechanic_id " +
                                   "WHERE pay_date BETWEEN @startDate AND @endDate";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                        cmd.Parameters.AddWithValue("@endDate", endDate.Date);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            payoutReportsDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering payout reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterPayoutReportsBySpecialization(string specialization)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT CONCAT(firstName, ' ', lastName, ' - ', specialization) AS MechanicInfo, contactNumber, address, pay_date, pay_amount " +
                                   "FROM mechanic_payout " +
                                   "INNER JOIN mechanic_info ON mechanic_payout.mechanic_id = mechanic_info.mechanic_id " +
                                   "WHERE specialization = @specialization";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@specialization", specialization);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            payoutReportsDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering payout reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PayoutReportsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (payoutReportsDataGridView.Columns[e.ColumnIndex].Name == "pay_amount")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    decimal payAmount = Convert.ToDecimal(e.Value);
                    e.Value = payAmount.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
                }
            }

        }

        private void start_DatePicker_ValueChanged(object sender, EventArgs e)
        {
            FilterPayoutReportsByDateRange(start_DatePicker.Value.Date, end_DatePicker.Value.Date);
        }

        private void end_DatePicker_ValueChanged(object sender, EventArgs e)
        {
            FilterPayoutReportsByDateRange(start_DatePicker.Value.Date, end_DatePicker.Value.Date);
        }

        private void filterDate_btn_Click(object sender, EventArgs e)
        {
            DateTime startDate = start_DatePicker.Value.Date;
            DateTime endDate = end_DatePicker.Value.Date;

            FilterPayoutReportsByDateRange(startDate, endDate);
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            LoadPayoutReports();
        }

        private void specialization_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpecialization = specialization_cmbx.SelectedItem.ToString();
            FilterPayoutReportsBySpecialization(selectedSpecialization);
        }

        private void exportExcel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)payoutReportsDataGridView.DataSource;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "Mechanic Payout Report";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            IXLWorksheet worksheet = workbook.Worksheets.Add(dataTable, "CompletedReservations");

                            worksheet.Columns().AdjustToContents();

                            workbook.SaveAs(saveFileDialog.FileName);

                            MessageBox.Show("Data exported to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
