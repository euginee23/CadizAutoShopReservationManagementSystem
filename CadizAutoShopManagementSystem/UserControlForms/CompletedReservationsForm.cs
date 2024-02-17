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
    public partial class CompletedReservationsForm : UserControl
    {
        public CompletedReservationsForm()
        {
            InitializeComponent();
        }

        //USER CONTROL PANEL NAVIGATION
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //NAVIGATE TO APPROVED RESERVATIONS
        private void approvedReservation_btn_Click(object sender, EventArgs e)
        {
            ApprovedReservationsForm approvedRes = new ApprovedReservationsForm();
            addUserControl(approvedRes);
        }

        //NAVIGATE TO PENDING RESERVATIONS
        private void pendingReservation_btn_Click(object sender, EventArgs e)
        {
            ReservationsForm pendingRes = new ReservationsForm();
            addUserControl(pendingRes);
        }
    }
}
