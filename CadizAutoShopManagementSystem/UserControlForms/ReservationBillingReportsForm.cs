using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class ReservationBillingReportsForm : UserControl
    {
        public ReservationBillingReportsForm()
        {
            InitializeComponent();
            LoadReservationBillingReports();
        }

        private void LoadReservationBillingReports()
        {
            try
            {
                reservationBillingDataGridView.Rows.Clear();
                decimal totalMechanicPayout = 0;
                decimal totalServiceCost = 0;

                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT billing_id, customerName, serviceDone, extraCost_Reason, extraCost, totalCost, created_at, receipt_Image " +
                                   "FROM billing_invoice";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            System.Data.DataTable dataTable = new System.Data.DataTable();
                            adapter.Fill(dataTable);

                            reservationBillingDataGridView.RowTemplate.Height = 200;

                            foreach (DataRow row in dataTable.Rows)
                            {
                                byte[] imageData = (byte[])row["receipt_Image"];
                                Image image = ConvertByteArrayToImage(imageData);

                                Image resizedImage = ResizeImage(image, 170, 180);

                                int rowIndex = reservationBillingDataGridView.Rows.Add();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["billing_idColumn"].Value = row["billing_id"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["customerNameColumn"].Value = row["customerName"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["serviceDoneColumn"].Value = row["serviceDone"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["extraCostReasonColumn"].Value = row["extraCost_Reason"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["extraCostColumn"].Value = row["extraCost"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["totalCostColumn"].Value = row["totalCost"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["created_atColumn"].Value = row["created_at"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["receiptImageColumn"].Value = resizedImage;

                                string totalCostString = row["totalCost"].ToString();
                                totalCostString = totalCostString.Replace("₱", "");
                                totalCostString = totalCostString.Replace(",", "");
                                decimal totalCost = decimal.Parse(totalCostString);
                                reservationBillingDataGridView.Rows[rowIndex].Cells["totalCostColumn"].Value = totalCost.ToString("C", new System.Globalization.CultureInfo("en-PH"));

                                decimal mechanicAmount = totalCost * 0.6m;
                                reservationBillingDataGridView.Rows[rowIndex].Cells["mechanicAmountColumn"].Value = mechanicAmount.ToString("C", new System.Globalization.CultureInfo("en-PH"));

                                totalMechanicPayout += mechanicAmount;

                                totalServiceCost += totalCost;
                            }
                        }
                    }
                }
                payOut_txt.Text = totalMechanicPayout.ToString("C", new System.Globalization.CultureInfo("en-PH"));

                decimal totalNetIncome = totalServiceCost - totalMechanicPayout;
                totalNetIncome_txt.Text = totalNetIncome.ToString("C", new System.Globalization.CultureInfo("en-PH"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservation billing reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            return new Bitmap(image, new Size(width, height));
        }

        private void filterDate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = start_DatePicker.Value;
                DateTime endDate = end_DatePicker.Value;

                reservationBillingDataGridView.Rows.Clear();
                decimal totalMechanicPayout = 0;
                decimal totalServiceCost = 0;

                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT billing_id, customerName, serviceDone, extraCost_Reason, extraCost, totalCost, created_at, receipt_Image " +
                                   "FROM billing_invoice " +
                                   "WHERE created_at BETWEEN @startDate AND @endDate";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            System.Data.DataTable dataTable = new System.Data.DataTable();
                            adapter.Fill(dataTable);

                            reservationBillingDataGridView.RowTemplate.Height = 200;

                            foreach (DataRow row in dataTable.Rows)
                            {
                                byte[] imageData = (byte[])row["receipt_Image"];
                                Image image = ConvertByteArrayToImage(imageData);

                                Image resizedImage = ResizeImage(image, 170, 180);

                                int rowIndex = reservationBillingDataGridView.Rows.Add();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["billing_idColumn"].Value = row["billing_id"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["customerNameColumn"].Value = row["customerName"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["serviceDoneColumn"].Value = row["serviceDone"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["extraCostReasonColumn"].Value = row["extraCost_Reason"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["extraCostColumn"].Value = row["extraCost"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["totalCostColumn"].Value = row["totalCost"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["created_atColumn"].Value = row["created_at"].ToString();
                                reservationBillingDataGridView.Rows[rowIndex].Cells["receiptImageColumn"].Value = resizedImage;

                                string totalCostString = row["totalCost"].ToString();
                                totalCostString = totalCostString.Replace("₱", "");
                                totalCostString = totalCostString.Replace(",", "");
                                decimal totalCost = decimal.Parse(totalCostString);
                                reservationBillingDataGridView.Rows[rowIndex].Cells["totalCostColumn"].Value = totalCost.ToString("C", new System.Globalization.CultureInfo("en-PH"));

                                decimal mechanicAmount = totalCost * 0.6m;
                                reservationBillingDataGridView.Rows[rowIndex].Cells["mechanicAmountColumn"].Value = mechanicAmount.ToString("C", new System.Globalization.CultureInfo("en-PH"));

                                totalMechanicPayout += mechanicAmount;

                                totalServiceCost += totalCost;
                            }
                        }
                    }
                }

                payOut_txt.Text = totalMechanicPayout.ToString("C", new System.Globalization.CultureInfo("en-PH"));
                decimal totalNetIncome = totalServiceCost - totalMechanicPayout;
                totalNetIncome_txt.Text = totalNetIncome.ToString("C", new System.Globalization.CultureInfo("en-PH"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering reservation billing reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportExcel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = true;

                Workbook workbook = excelApp.Workbooks.Add();

                Worksheet worksheet = workbook.Sheets[1];

                for (int i = 0; i < reservationBillingDataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = reservationBillingDataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < reservationBillingDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < reservationBillingDataGridView.Columns.Count; j++)
                    {
                        if (reservationBillingDataGridView.Rows[i].Cells[j].Value is Image)
                        {
                            Image image = (Image)reservationBillingDataGridView.Rows[i].Cells[j].Value;

                            Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i + 2, j + 1];
                            range.RowHeight = image.Height * 0.75;
                            range.ColumnWidth = 15;
                            Clipboard.SetDataObject(image, true);
                            worksheet.Paste(range, false);
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = reservationBillingDataGridView.Rows[i].Cells[j].Value?.ToString();
                        }
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
                saveFileDialog.FileName = "ReservationeBillingReport.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                }

                workbook.Close();
                excelApp.Quit();
                releaseObject(worksheet);
                releaseObject(workbook);
                releaseObject(excelApp);

                MessageBox.Show("Export to Excel completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show($"Error releasing COM object: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            try
            {
                LoadReservationBillingReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing all local service billing reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
