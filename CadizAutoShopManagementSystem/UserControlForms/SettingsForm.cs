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

        public SettingsForm()
        {
            InitializeComponent();
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
    }
}
