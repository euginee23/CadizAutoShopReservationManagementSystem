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
    public partial class MechanicRegForm : UserControl
    {
        private MySqlConnection connection;

        public MechanicRegForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
            LoadMechanicData();
            PopulateSpecializationComboBox();
        }

        private void LoadMechanicData()
        {
            try
            {
                string query = "SELECT mechanic_id, CONCAT(firstName, ' ', lastName) AS mechanicName, address, contactNumber, specialization FROM mechanic_info";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                mechanicDataGrid.RowTemplate.Height = 50;
                mechanicDataGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PopulateSpecializationComboBox()
        {
            specialization_cmbx.Items.Add("Engine Repair");
            specialization_cmbx.Items.Add("Transmission Repair");
            specialization_cmbx.Items.Add("Brake System Repair");
            specialization_cmbx.Items.Add("Suspension and Steering");
            specialization_cmbx.Items.Add("Electrical Systems");
            specialization_cmbx.Items.Add("HVAC (Heating, Ventilation, and Air Conditioning)");
            specialization_cmbx.Items.Add("Diagnostic Technician");
            specialization_cmbx.Items.Add("Tire and Wheel Service");
            specialization_cmbx.Items.Add("Exhaust System Repair");
            specialization_cmbx.Items.Add("Auto Body Repair");

            filter_cmbx.Items.Add("Engine Repair");
            filter_cmbx.Items.Add("Transmission Repair");
            filter_cmbx.Items.Add("Brake System Repair");
            filter_cmbx.Items.Add("Suspension and Steering");
            filter_cmbx.Items.Add("Electrical Systems");
            filter_cmbx.Items.Add("HVAC (Heating, Ventilation, and Air Conditioning)");
            filter_cmbx.Items.Add("Diagnostic Technician");
            filter_cmbx.Items.Add("Tire and Wheel Service");
            filter_cmbx.Items.Add("Exhaust System Repair");
            filter_cmbx.Items.Add("Auto Body Repair");
        }


        private void register_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mechanicFnametxt.Text) || string.IsNullOrWhiteSpace(mechanicLnametxt.Text) ||
                string.IsNullOrWhiteSpace(mechanicAddresstxt.Text) || string.IsNullOrWhiteSpace(mechanicContacttxt.Text) ||
                specialization_cmbx.SelectedItem == null)
            {
                MessageBox.Show("Please input all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO mechanic_info (firstName, lastName, address, contactNumber, specialization) " +
                                         "VALUES (@firstName, @lastName, @address, @contactNumber, @specialization)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@firstName", mechanicFnametxt.Text);
                        cmd.Parameters.AddWithValue("@lastName", mechanicLnametxt.Text);
                        cmd.Parameters.AddWithValue("@address", mechanicAddresstxt.Text);
                        cmd.Parameters.AddWithValue("@contactNumber", mechanicContacttxt.Text);
                        cmd.Parameters.AddWithValue("@specialization", specialization_cmbx.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Mechanic registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMechanicData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void selectMechanicChanged(object sender, EventArgs e)
        {
            if (mechanicDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = mechanicDataGrid.SelectedRows[0];
                mechanicId_txt.Text = selectedRow.Cells["mechanicId_column"].Value.ToString();
            }
        }


        private void getMechanicTextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(mechanicId_txt.Text, out int mechanicId))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                        string query = "SELECT mechanic_id, firstName, lastName, address, contactNumber, specialization FROM mechanic_info WHERE mechanic_id = @mechanicId";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@mechanicId", mechanicId);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    mechanicFnametxt.Text = reader["firstName"].ToString();
                                    mechanicLnametxt.Text = reader["lastName"].ToString();
                                    mechanicAddresstxt.Text = reader["address"].ToString();
                                    mechanicContacttxt.Text = reader["contactNumber"].ToString();
                                    specialization_cmbx.Text = reader["specialization"].ToString();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mechanicId_txt.Text))
            {
                MessageBox.Show("Please select a mechanic to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(mechanicId_txt.Text, out int mechanicId))
            {
                try
                {
                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string updateQuery = "UPDATE mechanic_info SET firstName = @firstName, lastName = @lastName, " +
                                             "address = @address, contactNumber = @contactNumber, " +
                                             "specialization = @specialization WHERE mechanic_id = @mechanicId";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@mechanicId", mechanicId);
                            cmd.Parameters.AddWithValue("@firstName", mechanicFnametxt.Text);
                            cmd.Parameters.AddWithValue("@lastName", mechanicLnametxt.Text);
                            cmd.Parameters.AddWithValue("@address", mechanicAddresstxt.Text);
                            cmd.Parameters.AddWithValue("@contactNumber", mechanicContacttxt.Text);
                            cmd.Parameters.AddWithValue("@specialization", specialization_cmbx.SelectedItem?.ToString());

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Mechanic information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadMechanicData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void ClearMechanicFields()
        {
            mechanicFnametxt.Clear();
            mechanicLnametxt.Clear();
            mechanicAddresstxt.Clear();
            mechanicContacttxt.Clear();
            specialization_cmbx.SelectedIndex = -1;
            mechanicId_txt.Clear();
        }

        private void filterBySpecialization(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT mechanic_id, CONCAT(firstName, ' ', lastName) AS mechanicName, address, contactNumber, specialization FROM mechanic_info";

                if (filter_cmbx.SelectedIndex >= 0)
                {
                    string selectedSpecialization = filter_cmbx.SelectedItem.ToString();
                    query += $" WHERE specialization = '{selectedSpecialization}'";
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                mechanicDataGrid.RowTemplate.Height = 50;
                mechanicDataGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            LoadMechanicData();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearMechanicFields();
        }

        private void MechanicRegForm_Load(object sender, EventArgs e)
        {
            ClearMechanicFields();
        }

        private void action_cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DeleteColumn.Index)
                {
                    if (mechanicDataGrid.Rows[e.RowIndex].Cells["mechanicId_column"].Value is int mechanicId)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this mechanic?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                using (MySqlConnection connection = DatabaseManager.GetConnection())
                                {
                                    connection.Open();

                                    string deleteQuery = "DELETE FROM mechanic_info WHERE mechanic_id = @mechanicId";

                                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                                    {
                                        cmd.Parameters.AddWithValue("@mechanicId", mechanicId);
                                        cmd.ExecuteNonQuery();
                                    }

                                    MessageBox.Show("Mechanic deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoadMechanicData();
                                    ClearMechanicFields();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error: {ex.Message}");
                            }
                        }
                    }
                }
                else if (e.ColumnIndex == ViewColumn.Index)
                {
                    if (mechanicDataGrid.Rows[e.RowIndex].Cells["mechanicId_column"].Value is int mechanicId)
                    {
                        MechanicProfileForm mechanicProfileForm = new MechanicProfileForm(mechanicId);
                        mechanicProfileForm.ShowDialog();
                    }
                }
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = search_txt.Text.Trim();

            try
            {
                string query = "SELECT mechanic_id, CONCAT(firstName, ' ', lastName) AS mechanicName, address, contactNumber, specialization FROM mechanic_info WHERE CONCAT(firstName, ' ', lastName) LIKE @searchTerm OR specialization LIKE @searchTerm";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                mechanicDataGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
