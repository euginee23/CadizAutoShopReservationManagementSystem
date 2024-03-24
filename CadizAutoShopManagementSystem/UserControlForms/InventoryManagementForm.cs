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

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class InventoryManagementForm : UserControl
    {
        public InventoryManagementForm()
        {
            InitializeComponent();
            PopulateCarPartsCategoriesComboBox();
            PopulateMakeComboBox();
            PopulateCategoryFilterCombobox();
        }

        private void InventoryManagementForm_Load(object sender, EventArgs e)
        {
            LoadPartsData();
        }

        private void PopulateMakeComboBox()
        {
            partModel_txt.Items.AddRange(new object[] { "Isuzu", "Mitsubishi", "Toyota", "Ford", "Hyundai", "Kia", "Mazda", "Nissan", "Honda", "Chevrolet", "Jeep" });
        }

        private void PopulateCarPartsCategoriesComboBox()
        {
            partCat_cmbx.Items.AddRange(new object[] { "Engine",
            "Transmission",
            "Suspension",
            "Brakes",
            "Electrical",
            "Interior",
            "Exterior",
            "Wheels and Tires",
            "Body",
            "Fuel System",
            "Exhaust System",
            "Cooling System",
            "Air Conditioning",
            "Ignition System",
            "Steering",
            "Drive Train",
            "Performance Upgrades", });
        }

        private void PopulateCategoryFilterCombobox()
        {
            filterCat_cmbx.Items.AddRange(new object[] { "Engine",
            "Transmission",
            "Suspension",
            "Brakes",
            "Electrical",
            "Interior",
            "Exterior",
            "Wheels and Tires",
            "Body",
            "Fuel System",
            "Exhaust System",
            "Cooling System",
            "Air Conditioning",
            "Ignition System",
            "Steering",
            "Drive Train",
            "Performance Upgrades", });
        }

        private void LoadPartsData()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT part_id, part_number, part_name, part_model, price, availability FROM parts_inventory";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        partsDataGrid.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadFilteredPartsData(string categoryFilter)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT part_id, part_number, part_name, part_model, price, availability FROM parts_inventory WHERE category = @Category";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@Category", categoryFilter);

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        partsDataGrid.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void filterCat_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = filterCat_cmbx.SelectedItem.ToString();
            LoadFilteredPartsData(selectedCategory);
        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomPartId = random.Next(9999, 99999);
            partId_txt.Text = randomPartId.ToString();
        }

        private void ClearFields()
        {
            partId_txt.Text = "";
            partCat_cmbx.Text = "";
            partNumber_txt.Text = "";
            partName_txt.Text = "";
            partModel_txt.Text = "";
            partPrice_txt.Text = "";
            partAvailability_txt.Text = "";
            description_txt.Text = "";
        }

        private void addButton_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "INSERT INTO parts_inventory (part_id, category, part_number, part_name, part_model, price, availability, description) " +
                                   "VALUES (@PartID, @Category, @PartNumber, @PartName, @MakeModel, @Price, @Availability, @Description)";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@PartID", partId_txt.Text);
                    cmd.Parameters.AddWithValue("@Category", partCat_cmbx.Text);
                    cmd.Parameters.AddWithValue("@PartNumber", partNumber_txt.Text);
                    cmd.Parameters.AddWithValue("@PartName", partName_txt.Text);
                    cmd.Parameters.AddWithValue("@MakeModel", partModel_txt.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(partPrice_txt.Text)); 
                    cmd.Parameters.AddWithValue("@Availability", Convert.ToInt32(partAvailability_txt.Text));
                    cmd.Parameters.AddWithValue("@Description", description_txt.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Part added successfully!");
                    LoadPartsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "UPDATE parts_inventory " +
                                   "SET category = @Category, " +
                                   "part_number = @PartNumber, " +
                                   "part_name = @PartName, " +
                                   "part_model = @MakeModel, " +
                                   "price = @Price, " +
                                   "availability = @Availability, " +
                                   "description = @Description " +
                                   "WHERE part_id = @PartID";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@Category", partCat_cmbx.Text);
                    cmd.Parameters.AddWithValue("@PartNumber", partNumber_txt.Text);
                    cmd.Parameters.AddWithValue("@PartName", partName_txt.Text);
                    cmd.Parameters.AddWithValue("@MakeModel", partModel_txt.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(partPrice_txt.Text));
                    cmd.Parameters.AddWithValue("@Availability", Convert.ToInt32(partAvailability_txt.Text));
                    cmd.Parameters.AddWithValue("@Description", description_txt.Text);
                    cmd.Parameters.AddWithValue("@PartID", partId_txt.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Part updated successfully!");
                        LoadPartsData();
                    }
                    else
                    {
                        MessageBox.Show("No part found with the specified Part ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void getPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = partsDataGrid.Rows[e.RowIndex];
                showId_txt.Text = row.Cells["Column_ID"].Value.ToString();
            }
        }

        private void getPartInfo_TextChanged(object sender, EventArgs e)
        {
            string partId = showId_txt.Text;

            if (!string.IsNullOrEmpty(partId))
            {
                try
                {
                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();

                        string query = "SELECT * FROM parts_inventory WHERE part_id = @PartID";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@PartID", partId);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    partId_txt.Text = reader["part_id"].ToString();
                                    partCat_cmbx.Text = reader["category"].ToString();
                                    partNumber_txt.Text = reader["part_number"].ToString();
                                    partName_txt.Text = reader["part_name"].ToString();
                                    partModel_txt.Text = reader["part_model"].ToString();
                                    partPrice_txt.Text = reader["price"].ToString();
                                    partAvailability_txt.Text = reader["availability"].ToString();
                                    description_txt.Text = reader["description"].ToString();
                                }
                                else
                                {
                                    ClearFields();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                ClearFields();
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void searchPart_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchKeyword = searchPart_txt.Text;

                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT part_id, part_number, part_name, part_model, price, availability FROM parts_inventory " +
                                   "WHERE part_id LIKE @searchKeyword OR part_number LIKE @searchKeyword OR part_name LIKE @searchKeyword OR part_model LIKE @searchKeyword";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@searchKeyword", $"%{searchKeyword}%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            partsDataGrid.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void removePart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == partsDataGrid.Columns["Remove"].Index)
                {
                    DataGridViewRow selectedRow = partsDataGrid.Rows[e.RowIndex];
                    string partIdToRemove = selectedRow.Cells["Column_ID"].Value.ToString();

                    if (MessageBox.Show("Are you sure you want to remove this part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (MySqlConnection connection = DatabaseManager.GetConnection())
                        {
                            connection.Open();

                            string deleteQuery = "DELETE FROM parts_inventory WHERE part_id = @partIdToRemove";

                            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@partIdToRemove", partIdToRemove);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Part removed successfully!");
                            LoadPartsData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            LoadPartsData();
        }
    }
}
