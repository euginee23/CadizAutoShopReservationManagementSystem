using AdminRegistration.UserControlForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminRegistration
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void registration_btn_Click(object sender, EventArgs e)
        {
            UC_Registration rgstr = new UC_Registration();
            addUserControl(rgstr);
        }

        private void list_btn_Click(object sender, EventArgs e)
        {
            UC_List lst = new UC_List();
            addUserControl(lst);
        }
    }
}
