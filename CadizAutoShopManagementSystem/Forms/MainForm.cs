using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadizAutoShopManagementSystem.Configs;
using CadizAutoShopManagementSystem.UserControlForms;
using MySql.Data.MySqlClient;

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
            if (userRole == "Admin")
            {
                dashboard_btn.Enabled = true;
                reservations_btn.Enabled = true;
                mechanicReg_btn.Enabled = true;
                servicesMng_btn.Enabled = true;
                inventoryMng_btn.Enabled = true;
                soldParts_btn.Enabled = true;
                localService_btn.Enabled = true;
                localReservation_btn.Enabled = true;
                report_btn.Enabled = true;
                billing_btn.Enabled = true;
                settings_btn.Enabled = true;
            }
            else
            {
                try
                {
                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string query = "SELECT * FROM user_access WHERE user_id = @userId";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@userId", LoggedInUser.UserId);
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            dashboard_btn.Enabled = Convert.ToBoolean(reader["dashboard"]);
                            reservations_btn.Enabled = Convert.ToBoolean(reader["reservations"]);
                            mechanicReg_btn.Enabled = Convert.ToBoolean(reader["manage_mechanics"]);
                            servicesMng_btn.Enabled = Convert.ToBoolean(reader["manage_services"]);
                            inventoryMng_btn.Enabled = Convert.ToBoolean(reader["manage_inventory"]);
                            soldParts_btn.Enabled = Convert.ToBoolean(reader["sell_parts"]);
                            localService_btn.Enabled = Convert.ToBoolean(reader["local_service"]);
                            localReservation_btn.Enabled = Convert.ToBoolean(reader["local_reservation"]);
                            report_btn.Enabled = Convert.ToBoolean(reader["reports"]);
                            billing_btn.Enabled = Convert.ToBoolean(reader["billing"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving user access permissions: " + ex.Message);
                }
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
            SettingsForm settings = new SettingsForm(userRole);
            addUserControl(settings);
        }

        private void localService_btn_Click(object sender, EventArgs e)
        {
            LocalService lcl = new LocalService();
            addUserControl(lcl);
        }

        private void localReservation_btn_Click(object sender, EventArgs e)
        {
            LocalReservationForm lclRes = new LocalReservationForm();
            addUserControl(lclRes);
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            ReportsForm rprtsfrm = new ReportsForm();
            addUserControl(rprtsfrm);
        }
    }
}
