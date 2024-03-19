using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadizAutoShopManagementSystem.Components;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class SettingsForm : UserControl
    {
        private string userRole;

        public SettingsForm(string userRole)
        {
            InitializeComponent();
            this.userRole = userRole;
            UpdateButtonVisibility();
        }

        private void UpdateButtonVisibility()
        {
            if (userRole == "Employee")
            {
                adminAccount_btn.Enabled = false;
                personnelAccount_btn.Enabled = true;
                managePersonnel_btn.Enabled = false;
                personnelAccess_btn.Enabled = false;
            }
            else if (userRole == "Admin")
            {
                adminAccount_btn.Enabled = true;
                personnelAccount_btn.Enabled = false;
                managePersonnel_btn.Enabled = true;
                personnelAccess_btn.Enabled = true;
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelSettingsContainer.Controls.Clear();
            panelSettingsContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void adminAccount_btn_Click(object sender, EventArgs e)
        {
            EnterSecurityKeyForm enterSecurityKeyForm = new EnterSecurityKeyForm();

            if (enterSecurityKeyForm.ShowDialog() == DialogResult.OK)
            {
                AdminAccountSettingForm adminAccountSettingForm = new AdminAccountSettingForm();
                addUserControl(adminAccountSettingForm);
            }
            else
            {
                MessageBox.Show("Access denied. Please enter the correct security key.");
            }
        }

        private void managePersonnel_btn_Click(object sender, EventArgs e)
        {
            ManagePersonnelForm prsnlfrm = new ManagePersonnelForm();
            addUserControl(prsnlfrm);
        }

        private void personnelAccount_btn_Click(object sender, EventArgs e)
        {
            PersonnelAccountSettingsForm pasf = new PersonnelAccountSettingsForm();
            addUserControl(pasf);
        }

        private void personnelAccess_btn_Click(object sender, EventArgs e)
        {
            PersonnelAccessSettingsForm paccsetfrm = new PersonnelAccessSettingsForm();
            addUserControl(paccsetfrm);
        }
    }
}
