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

        //NAVIGATE TO MECHANIC PAYOUT REPORTS
        private void mechanicRprt_btn_Click(object sender, EventArgs e)
        {
            MechanicPayoutReportsForm mchrprtfrm = new MechanicPayoutReportsForm();
            addUserControl(mchrprtfrm);
        }

        //NAVIGATE TO PARTS SALES REPORTS
        private void partsSalesReports_btn_Click(object sender, EventArgs e)
        {
            PartsSalesReportsForm prtsslsrprts = new PartsSalesReportsForm();
            addUserControl(prtsslsrprts);
        }

        //NAVIGATE TO LOCAL SERVICE REPORTS
        private void localServiceReports_btn_Click(object sender, EventArgs e)
        {
            LocalServiceBIllingReportsForm lclsrvcrprts = new LocalServiceBIllingReportsForm();
            addUserControl(lclsrvcrprts);
        }

        //NAVIGATE TO RESERVATION BILLING REPORTS
        private void reservationBillingReports_btn_Click(object sender, EventArgs e)
        {
            ReservationBillingReportsForm rsrvtnsbllng = new ReservationBillingReportsForm();
            addUserControl(rsrvtnsbllng);
        }

        //NAVIGATE TO PARTS RECORDS REPORTS
        private void partsRecords_btn_Click(object sender, EventArgs e)
        {
            PartsRecordsReportsForm prtsrcrdsfrm = new PartsRecordsReportsForm();
            addUserControl(prtsrcrdsfrm);
        }

        //NAVIGATE TO LOCAL SERVICE RECORDS REPORTS
        private void localServiceRecordsReports_btn_Click(object sender, EventArgs e)
        {
            LocalServiceRecordsReportsForm lclrprtsrcrds = new LocalServiceRecordsReportsForm();
            addUserControl(lclrprtsrcrds);
        }
    }
}
