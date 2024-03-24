using CadizAutoShopManagementSystem.Components;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CadizAutoShopManagementSystem.UserControlForms.PartsBillingForm;

namespace CadizAutoShopManagementSystem.Forms
{
    public partial class PartsInvoiceForm : Form
    {
        private Panel panelToPrint;
        private LoadingStateForm loadingForm;

        public PartsInvoiceForm(string customerName, string customerAddress, string transactionId, string totalCost, List<PartsBillingInfo> partsData)
        {
            InitializeComponent();

            // DATA PASSED FROM PARTS BILLING FORM
            customerName_lbl.Text = customerName;
            customerAddress_lbl.Text = customerAddress;
            transactionId_lbl.Text = transactionId;
            totalCost_lbl.Text = totalCost;

            // PASSING AND INSERTING PARTS INTO DATAGRID
            foreach (var part in partsData)
            {
                partsDataGridView.Rows.Add(part.PartName, part.Quantity, part.TotalCost);
            }

            panelToPrint = panelPrint;
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

        // BITMAP PANEL TO IMAGE
        private void PrintPanelPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panelToPrint.Width, panelToPrint.Height);
            panelToPrint.DrawToBitmap(bmp, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

            e.Graphics.DrawImage(bmp, 0, 0);
        }

        // OPEN PREVIEW OF PANEL FOR PRINTING
        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPanelPage);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;
            printPreviewDialog.ShowDialog();
        }

        // BILLING FUNCTION AND SAVING TO DATABASE
        private void billing_button_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder partsBoughtBuilder = new StringBuilder();
                foreach (DataGridViewRow row in partsDataGridView.Rows)
                {
                    string partName = row.Cells["unit_Column"].Value != null ? row.Cells["unit_Column"].Value.ToString() : string.Empty;
                    int quantity = row.Cells["quantity_Column"].Value != null ? Convert.ToInt32(row.Cells["quantity_Column"].Value) : 0;
                    decimal totalCost = row.Cells["cost_Column"].Value != null ? Convert.ToDecimal(row.Cells["cost_Column"].Value) : 0;

                    partsBoughtBuilder.Append($"{quantity} x {partName} (₱{totalCost}), ");
                }

                string partsBought = partsBoughtBuilder.ToString().TrimEnd(' ', ',');

                MemoryStream ms = new MemoryStream();

                Bitmap bitmap = new Bitmap(panelToPrint.Width, panelToPrint.Height);
                panelToPrint.DrawToBitmap(bitmap, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] receiptImage = ms.ToArray();

                ShowLoadingForm();
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO parts_billing_invoice (transaction_id, customerName, customerAddress, partsBought, totalCost, receipt_Image) " +
                                         "VALUES (@TransactionId, @CustomerName, @CustomerAddress, @PartsBought, @TotalCost, @ReceiptImage); " +
                                         "SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        

                        cmd.Parameters.AddWithValue("@TransactionId", transactionId_lbl.Text);
                        cmd.Parameters.AddWithValue("@CustomerName", customerName_lbl.Text);
                        cmd.Parameters.AddWithValue("@CustomerAddress", customerAddress_lbl.Text);
                        cmd.Parameters.AddWithValue("@PartsBought", partsBought);
                        cmd.Parameters.AddWithValue("@TotalCost", totalCost_lbl.Text);
                        cmd.Parameters.AddWithValue("@ReceiptImage", receiptImage);

                        int generatedInvoiceId = Convert.ToInt32(cmd.ExecuteScalar());

                        string deleteQuery = "DELETE FROM parts_billing_queue WHERE transaction_id = @TransactionId";

                        using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@TransactionId", transactionId_lbl.Text);
                            deleteCmd.ExecuteNonQuery();
                        }
                    }
                }

                DialogResult printReceiptResult = MessageBox.Show("Transaction complete. Do you want to print the receipt?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (printReceiptResult == DialogResult.Yes)
                {
                    print_btn_Click(sender, e);
                }
                CloseLoadingForm();
                MessageBox.Show("TRANSACTION COMPLETE.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
