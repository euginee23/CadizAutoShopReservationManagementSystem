using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        public PartsInvoiceForm(string customerName, string customerAddress, string transactionId, string totalCost, List<PartsBillingInfo> partsData)
        {
            InitializeComponent();

            customerName_lbl.Text = customerName;
            customerAddress_lbl.Text = customerAddress;
            transactionId_lbl.Text = transactionId;
            totalCost_lbl.Text = totalCost;

            foreach (var part in partsData)
            {
                partsDataGridView.Rows.Add(part.PartName, part.Quantity, part.TotalCost);
            }

            panelToPrint = panelPrint;
        }
        private void PrintPanelPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panelToPrint.Width, panelToPrint.Height);
            panelToPrint.DrawToBitmap(bmp, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPanelPage);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;
            printPreviewDialog.ShowDialog();
        }

        private void billing_button_Click(object sender, EventArgs e)
        {

        }
    }
}
