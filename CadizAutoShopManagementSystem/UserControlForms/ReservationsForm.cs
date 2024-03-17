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
using CadizAutoShopManagementSystem.Forms;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class ReservationsForm : UserControl
    {
        private MySqlConnection connection;

        public ReservationsForm()
        {
            InitializeComponent();
        }

        //USER CONTROL PANEL NAVIGATION
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            reservationPanel.Controls.Clear();
            reservationPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //NAVIGATE TO COMPLETED RESERVATIONS
        private void completedReservations_btn_Click_1(object sender, EventArgs e)
        {
            CompletedReservationsForm completedRes = new CompletedReservationsForm();
            addUserControl(completedRes);
        }

        //NAVIGATE TO APPROVED RESERVATIONS
        private void approvedReservation_btn_Click_Click(object sender, EventArgs e)
        {
            ApprovedReservationsForm approvedRes = new ApprovedReservationsForm();
            addUserControl(approvedRes);
        }

        //NAVIGATE TO PENDING RESERVATIONS
        private void pendingReservation_btn_Click_Click(object sender, EventArgs e)
        {
            PendingReservationsForms pendingRes = new PendingReservationsForms();
            addUserControl(pendingRes);
        }
    }
}
