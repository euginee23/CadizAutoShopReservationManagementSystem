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

        private void reservationBilling_btn_Click(object sender, EventArgs e)
        {
            ReservationBillingForm rsvtnbllng = new ReservationBillingForm();
            addUserControl(rsvtnbllng);
        }
    }
}
