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
    public partial class InvoiceForm : Form
    {
        private Panel panelToPrint;

        public InvoiceForm(string reservationId, string billingId, string customerName, string serviceType, string extraExpenseReason, string extraExpenseCost, string totalCost)
        {
            InitializeComponent();
            panelToPrint = panelPrint;

            reservationId_lbl.Text = reservationId;
            billingId_lbl.Text = billingId;
            customerName_lbl.Text = customerName;
            serviceType_lbl.Text = serviceType;
            extraExpenseReason_lbl.Text = extraExpenseReason;
            extraExpenseCost_lbl.Text = extraExpenseCost;
            totalCost_lbl.Text = totalCost;
        }

        private void PrintPanelPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panelToPrint.Width, panelToPrint.Height);
            panelToPrint.DrawToBitmap(bmp, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

            e.Graphics.DrawImage(bmp, 0, 0);

            // Save the image directly to the database
            SaveImageToDatabase(bmp);

        }

        private void ViewPrintPanelPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panelToPrint.Width, panelToPrint.Height);
            panelToPrint.DrawToBitmap(bmp, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void SaveImageToDatabase(Bitmap image)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    // Convert the Bitmap to bytes
                    image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageBytes = stream.ToArray();

                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        // Assuming you have a table named 'reservation_billing_invoice'
                        string insertQuery = "INSERT INTO reservation_billing_invoice (ImageContent) VALUES (@imageContent)";

                        using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@imageContent", imageBytes);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Billing information saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ViewPrintPanelPage);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;
            printPreviewDialog.ShowDialog();
        }

        private void billing_button_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPanelPage);

            Bitmap bmp = new Bitmap(panelToPrint.Width, panelToPrint.Height);

            pd.PrintPage += (s, ev) =>
            {
                panelToPrint.DrawToBitmap(bmp, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));
                ev.Graphics.DrawImage(bmp, 0, 0);
            };

            SaveImageToDatabase(bmp);
        }
    }
}
