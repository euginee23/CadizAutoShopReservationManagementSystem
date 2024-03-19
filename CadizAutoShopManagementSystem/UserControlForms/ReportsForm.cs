using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class ReportsForm : UserControl
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        //USER CONTROL PANEL NAVIGATION
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            reportsPanelContainer.Controls.Clear();
            reportsPanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //NAVIGATE TO RESERVATION REPORTS
        private void reservationsReport_Click(object sender, EventArgs e)
        {
            ReservationReportsForm rsvtnsrprtsfrm = new ReservationReportsForm();
            addUserControl(rsvtnsrprtsfrm);
        }

        //NAVIGATE TO LOG-IN REPORTS
        private void log_in_reports_btn_Click(object sender, EventArgs e)
        {
            LogInReportsForm lgnrprts = new LogInReportsForm();
            addUserControl(lgnrprts);
        }
    }
}
