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
using Excel = Microsoft.Office.Interop.Excel;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class PartsSalesReportsForm : UserControl
    {
        public PartsSalesReportsForm()
        {
            InitializeComponent();
            LoadPartsSalesReports();
            CalculateTotalSales();
        }

        private void CalculateTotalSales()
        {
            decimal totalSales = 0;

            foreach (DataGridViewRow row in partsSalesReportsDataGridView.Rows)
            {
                if (row.Cells["totalCostColumn"].Value != null)
                {
                    string costString = row.Cells["totalCostColumn"].Value.ToString();
                    costString = costString.Replace("₱", "").Replace(",", "");

                    if (decimal.TryParse(costString, out decimal cost))
                    {
                        totalSales += cost;
                    }
                }
            }

            totalSales_txt.Text = totalSales.ToString("C", new System.Globalization.CultureInfo("en-PH"));
        }

        private void LoadPartsSalesReports()
        {
            try
            {
                partsSalesReportsDataGridView.Rows.Clear();

                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT transaction_id, customerName, customerAddress, partsBought, totalCost, receipt_Image, created_at " +
                                   "FROM parts_billing_invoice";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            System.Data.DataTable dataTable = new System.Data.DataTable();
                            adapter.Fill(dataTable);

                            partsSalesReportsDataGridView.RowTemplate.Height = 200;

                            foreach (DataRow row in dataTable.Rows)
                            {
                                byte[] imageData = (byte[])row["receipt_Image"];
                                Image image = ByteArrayToImage(imageData);


                                Image resizedImage = ResizeImage(image, 170, 180);

                                int rowIndex = partsSalesReportsDataGridView.Rows.Add();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["transactionIdColumn"].Value = row["transaction_id"].ToString();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["customerNameColumn"].Value = row["customerName"].ToString();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["customerAddressColumn"].Value = row["customerAddress"].ToString();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["partsBoughtColumn"].Value = row["partsBought"].ToString();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["totalCostColumn"].Value = row["totalCost"].ToString();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["dateColumn"].Value = row["created_at"].ToString();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["receiptImageColumn"].Value = resizedImage;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading parts sales reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (var ms = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            return new Bitmap(image, new Size(width, height));
        }

        private void exportExcel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = true;

                Workbook workbook = excelApp.Workbooks.Add();

                Worksheet worksheet = workbook.Sheets[1];

                for (int i = 0; i < partsSalesReportsDataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = partsSalesReportsDataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < partsSalesReportsDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < partsSalesReportsDataGridView.Columns.Count; j++)
                    {
                        if (partsSalesReportsDataGridView.Rows[i].Cells[j].Value is Image)
                        {
                            Image image = (Image)partsSalesReportsDataGridView.Rows[i].Cells[j].Value;

                            Excel.Range range = (Excel.Range)worksheet.Cells[i + 2, j + 1];
                            range.RowHeight = image.Height * 0.75; 
                            range.ColumnWidth = 15;
                            Clipboard.SetDataObject(image, true);
                            worksheet.Paste(range, false);
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = partsSalesReportsDataGridView.Rows[i].Cells[j].Value?.ToString();
                        }
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
                saveFileDialog.FileName = "PartsSalesReport.xlsx";
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

        private void filterDate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = start_DatePicker.Value;
                DateTime endDate = end_DatePicker.Value;

                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT transaction_id, customerName, customerAddress, partsBought, totalCost, receipt_Image, created_at " +
                                   "FROM parts_billing_invoice " +
                                   "WHERE created_at BETWEEN @startDate AND @endDate";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            System.Data.DataTable dataTable = new System.Data.DataTable();
                            adapter.Fill(dataTable);

                            partsSalesReportsDataGridView.Rows.Clear();

                            partsSalesReportsDataGridView.RowTemplate.Height = 200;

                            foreach (DataRow row in dataTable.Rows)
                            {
                                byte[] imageData = (byte[])row["receipt_Image"];
                                Image image = ByteArrayToImage(imageData);

                                Image resizedImage = ResizeImage(image, 170, 180); 

                                int rowIndex = partsSalesReportsDataGridView.Rows.Add();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["transactionIdColumn"].Value = row["transaction_id"].ToString();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["customerNameColumn"].Value = row["customerName"].ToString();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["customerAddressColumn"].Value = row["customerAddress"].ToString();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["partsBoughtColumn"].Value = row["partsBought"].ToString();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["totalCostColumn"].Value = row["totalCost"].ToString();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["dateColumn"].Value = row["created_at"].ToString();
                                partsSalesReportsDataGridView.Rows[rowIndex].Cells["receiptImageColumn"].Value = resizedImage;
                            }
                        }
                    }
                }
                CalculateTotalSales();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering parts sales reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPartsSalesReports(); 
                CalculateTotalSales(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing all parts sales reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
