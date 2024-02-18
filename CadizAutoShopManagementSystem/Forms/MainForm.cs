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
        private string userRole;

        public MainForm(string userRole)
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += UpdateDateTime;
            timer.Start();

            this.userRole = userRole;
            UpdateButtonVisibility();
        }

        private void UpdateButtonVisibility()
        {
            if (userRole == "Employee")
            {
                dashboard_btn.Enabled = false;
                reservations_btn.Enabled = true;
                mechanicReg_btn.Enabled = false;
                servicesMng_btn.Enabled = false;
                inventoryMng_btn.Enabled = true;
                soldParts_btn.Enabled = true;
                billing_btn.Enabled = true;
                settings_btn.Enabled = false;
            }
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

        private void soldParts_btn_Click(object sender, EventArgs e)
        {
            SoldPartsForm soldParts = new SoldPartsForm();
            addUserControl(soldParts);
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            addUserControl(settings);
        }
    }
}
