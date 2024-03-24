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
using System.Globalization;
using CadizAutoShopManagementSystem.Components;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class ServicesManagementForm : UserControl
    {
        private LoadingStateForm loadingForm;

        public ServicesManagementForm()
        {
            ShowLoadingForm();
            InitializeComponent();
            LoadServicesData();
            CloseLoadingForm();
        }

        private void ServicesManagementForm_Load(object sender, EventArgs e)
        {
            LoadServicesData();
            ClearFields();
        }

        private void ShowLoadingForm()
        {
            loadingForm = new LoadingStateForm();
            loadingForm.StartPosition = FormStartPosition.CenterScreen;
            loadingForm.TopMost = true;
            loadingForm.Show();
            Application.DoEvents();
        }

        private void CloseLoadingForm()
        {
            loadingForm.Close();
        }

        private void LoadServicesData()
        {
            string query = "SELECT * FROM Services";

            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        servicesDataGrid.RowTemplate.Height = 50;
                        servicesDataGrid.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(serviceType_txt.Text) || string.IsNullOrWhiteSpace(description_txt.Text) || string.IsNullOrWhiteSpace(laborCost_txt.Text))
            {
                MessageBox.Show("Please enter values for all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO services (serviceType, serviceDescription, laborCost) " +
                           "VALUES (@serviceType, @description, @laborCost)";

            try
            {
                ShowLoadingForm();
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@serviceType", serviceType_txt.Text);
                        cmd.Parameters.AddWithValue("@description", description_txt.Text);
                        decimal laborCost = Convert.ToDecimal(laborCost_txt.Text);
                        string formattedLaborCost = laborCost.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
                        cmd.Parameters.AddWithValue("@laborCost", formattedLaborCost);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Service added successfully!");
                        LoadServicesData();
                        ClearFields();
                    }
                }
                CloseLoadingForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(serviceId_txt.Text))
            {
                MessageBox.Show("Please select a service to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(serviceId_txt.Text, out int serviceId))
            {
                try
                {
                    ShowLoadingForm();
                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string query = "UPDATE services SET serviceType = @serviceType, " +
                                       "serviceDescription = @description, laborCost = @laborCost " +
                                       "WHERE service_id = @serviceId";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@serviceId", serviceId);
                            cmd.Parameters.AddWithValue("@serviceType", serviceType_txt.Text);
                            cmd.Parameters.AddWithValue("@description", description_txt.Text);
                            cmd.Parameters.AddWithValue("@laborCost", Convert.ToDecimal(laborCost_txt.Text));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Service updated successfully!");
                            LoadServicesData();
                            ClearFields();
                        }
                    }
                    CloseLoadingForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void selectService(object sender, EventArgs e)
        {
            if (servicesDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = servicesDataGrid.SelectedRows[0];
                serviceId_txt.Text = selectedRow.Cells["serviceId_column"].Value.ToString();
            }
        }

        private void getServicesTextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(serviceId_txt.Text, out int serviceId))
            {
                try
                {
                    ShowLoadingForm();
                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string query = "SELECT serviceType, serviceDescription, laborCost FROM services WHERE service_id = @serviceId";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@serviceId", serviceId);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    serviceType_txt.Text = reader["serviceType"].ToString();
                                    description_txt.Text = reader["serviceDescription"].ToString();
                                    decimal laborCost = Convert.ToDecimal(reader["laborCost"]);
                                    string formattedLaborCost = laborCost.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
                                    laborCost_txt.Text = formattedLaborCost;
                                }
                            }
                        }
                    }
                    CloseLoadingForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void searchServicesTextChanged(object sender, EventArgs e)
        {
            string searchTerm = search_txt.Text.Trim();

            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM Services WHERE serviceType LIKE @searchTerm";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            servicesDataGrid.RowTemplate.Height = 50;
                            servicesDataGrid.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            serviceId_txt.Text = "";
            serviceType_txt.Text = "";
            description_txt.Text = "";
            laborCost_txt.Text = "";
        }

        private void deleteService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == deleteColumn.Index)
            {
                if (servicesDataGrid.Rows[e.RowIndex].Cells["serviceId_column"].Value is int serviceId)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this service?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            ShowLoadingForm();
                            using (MySqlConnection connection = DatabaseManager.GetConnection())
                            {
                                connection.Open();

                                string deleteQuery = "DELETE FROM services WHERE service_id = @serviceId";

                                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                                {
                                    cmd.Parameters.AddWithValue("@serviceId", serviceId);
                                    cmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Service deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoadServicesData();
                                ClearFields();
                            }
                            CloseLoadingForm();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void servicesDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (servicesDataGrid.Columns[e.ColumnIndex].Name == "laborCost_column" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal laborCost))
                {
                    e.Value = laborCost.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
