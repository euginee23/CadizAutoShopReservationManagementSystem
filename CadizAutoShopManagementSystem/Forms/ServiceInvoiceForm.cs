﻿using CadizAutoShopManagementSystem.Components;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadizAutoShopManagementSystem.Forms
{
    public partial class ServiceInvoiceForm : Form
    {
        private Panel panelToPrint;
        private LoadingStateForm loadingForm;

        public ServiceInvoiceForm(string serviceId, string billingId, string customerName, string serviceType, string extraExpenseReason, string extraExpenseCost, string totalCost)
        {
            InitializeComponent();
            panelToPrint = panelPrint;

            // DATA PASSED FROM SERVICE BILLING FORM
            localServiceId_lbl.Text = serviceId;
            billingId_lbl.Text = billingId;
            customerName_lbl.Text = customerName;
            serviceType_lbl.Text = serviceType;
            extraExpenseReason_lbl.Text = extraExpenseReason;
            extraExpenseCost_lbl.Text = extraExpenseCost;
            totalCost_lbl.Text = totalCost;
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
        private void print_Click(object sender, EventArgs e)
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
                MemoryStream ms = new MemoryStream();

                Bitmap bitmap = new Bitmap(panelToPrint.Width, panelToPrint.Height);
                panelToPrint.DrawToBitmap(bitmap, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] receiptImage = ms.ToArray();

                ShowLoadingForm();
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO local_service_billing_invoice (billing_id, localService_id, customerName, serviceDone, extraCost_Reason, extraCost, totalCost, receipt_Image, created_at) " +
                                         "VALUES (@BillingId, @localServiceId, @CustomerName, @ServiceDone, @ExtraCostReason, @ExtraCost, @TotalCost, @ReceiptImage, NOW()); " +
                                         "SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@BillingId", billingId_lbl.Text);
                        cmd.Parameters.AddWithValue("@localServiceId", localServiceId_lbl.Text);
                        cmd.Parameters.AddWithValue("@CustomerName", customerName_lbl.Text);
                        cmd.Parameters.AddWithValue("@ServiceDone", serviceType_lbl.Text);
                        cmd.Parameters.AddWithValue("@ExtraCostReason", extraExpenseReason_lbl.Text);
                        cmd.Parameters.AddWithValue("@ExtraCost", extraExpenseCost_lbl.Text);
                        cmd.Parameters.AddWithValue("@TotalCost", totalCost_lbl.Text);
                        cmd.Parameters.AddWithValue("@ReceiptImage", receiptImage);

                        int generatedInvoiceId = Convert.ToInt32(cmd.ExecuteScalar());

                        string deleteQuery = "DELETE FROM local_service_billing_queue WHERE billing_id = @BillingId";

                        using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@BillingId", billingId_lbl.Text);
                            deleteCmd.ExecuteNonQuery();
                        }

                        string updateStatusQuery = "UPDATE local_service SET status = 'Completed' WHERE localService_id = @localServiceId";

                        using (MySqlCommand updateCmd = new MySqlCommand(updateStatusQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@localServiceId", localServiceId_lbl.Text);
                            updateCmd.ExecuteNonQuery();
                        }

                        DialogResult printReceiptResult = MessageBox.Show("Transaction complete. Do you want to print the receipt?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (printReceiptResult == DialogResult.Yes)
                        {
                            print_Click(sender, e);
                        }
                        CloseLoadingForm();
                        MessageBox.Show("TRANSACTION COMPLETE.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
