using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadizAutoShopManagementSystem.UserControlForms;

namespace CadizAutoShopManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += UpdateDateTime;
            timer.Start();
        }

        private void UpdateDateTime(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            datetxt.Text = now.ToLongDateString();
            timetxt.Text = "Time: " + now.ToLongTimeString();
        }

        private void addUserControl (UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void closeWindow(object sender, EventArgs e)
        {
            this.Close();
            LogIn lg = new LogIn();
            lg.Show();
        }

        private void minimizeWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Reservations_btn_Click(object sender, EventArgs e)
        {
            ReservationsForm uf = new ReservationsForm();
            addUserControl(uf);
        }

        private void MechanicReg_btn_Click(object sender, EventArgs e)
        {
            MechanicRegForm mr = new MechanicRegForm();
            addUserControl(mr);
        }

        private void InventoryMng_btn_Click(object sender, EventArgs e)
        {
            InventoryManagementForm im = new InventoryManagementForm();
            addUserControl(im);
        }

        private void ServicesMng_btn_Click(object sender, EventArgs e)
        {
            ServicesManagementForm sm = new ServicesManagementForm();
            addUserControl(sm);
        }

        private void Billing_btn_Click(object sender, EventArgs e)
        {
            BillingForm bill = new BillingForm();
            addUserControl(bill);
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            DashboardForm dash = new DashboardForm();
            addUserControl(dash);
        }

        private void mechanicProfile_btn_Click(object sender, EventArgs e)
        {
            MechanicProfileForm mechanicProf = new MechanicProfileForm();
            addUserControl(mechanicProf);
        }

        private void soldParts_btn_Click(object sender, EventArgs e)
        {
            SoldPartsForm soldParts = new SoldPartsForm();
            addUserControl(soldParts);
        }

        private void approvedReservations_btn_Click(object sender, EventArgs e)
        {
            ApprovedReservationsForm approveRes = new ApprovedReservationsForm();
            addUserControl(approveRes);
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            addUserControl(settings);
        }
    }
}
