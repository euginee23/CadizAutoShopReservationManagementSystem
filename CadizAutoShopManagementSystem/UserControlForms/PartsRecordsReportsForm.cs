using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class PartsRecordsReportsForm : UserControl
    {
        public PartsRecordsReportsForm()
        {
            InitializeComponent();
            PopulatePartsInventory();
            PopulateCategoryFilterCombobox();
            PopulateCarPartsCategoriesComboBox();
        }

        private void PopulateCarPartsCategoriesComboBox()
        {
            category_cmbx.Items.AddRange(new object[] { "Engine", "Transmission", "Suspension", "Brakes", "Electrical", "Interior", "Exterior", "Wheels and Tires", "Body", "Fuel System", "Exhaust System", "Cooling System", "Air Conditioning", "Ignition System", "Steering", "Drive Train", "Performance Upgrades" });
        }

        private void PopulateCategoryFilterCombobox()
        {
            make_cmbx.Items.AddRange(new object[] { "Engine", "Transmission", "Suspension", "Brakes", "Electrical", "Interior", "Exterior", "Wheels and Tires", "Body", "Fuel System", "Exhaust System", "Cooling System", "Air Conditioning", "Ignition System", "Steering", "Drive Train", "Performance Upgrades" });
        }

        private void PopulatePartsInventory()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT part_number, part_name, part_model, price, availability, category, description, created_at 
                                     FROM parts_inventory";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        DataTable partsTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(partsTable);
                        }

                        CultureInfo phCulture = new CultureInfo("en-PH");

                        foreach (DataRow row in partsTable.Rows)
                        {
                            decimal price = Convert.ToDecimal(row["price"]);
                            row["price"] = price.ToString("C", phCulture);
                        }

                        partsDataGridView.DataSource = partsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving parts inventory data: " + ex.Message);
            }
        }

        private void FilterPartsByCategory(string category)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT part_number, part_name, part_model, price, availability, category, description, created_at 
                                     FROM parts_inventory
                                     WHERE category = @category";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@category", category);

                        DataTable filteredPartsTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(filteredPartsTable);
                        }

                        CultureInfo phCulture = new CultureInfo("en-PH");

                        foreach (DataRow row in filteredPartsTable.Rows)
                        {
                            decimal price = Convert.ToDecimal(row["price"]);
                            row["price"] = price.ToString("C", phCulture);
                        }

                        partsDataGridView.DataSource = filteredPartsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering parts by category: " + ex.Message);
            }
        }

        private void FilterPartsByModel(string model)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT part_number, part_name, part_model, price, availability, category, description, created_at 
                                     FROM parts_inventory
                                     WHERE part_model = @model";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@model", model);

                        DataTable filteredPartsTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(filteredPartsTable);
                        }

                        CultureInfo phCulture = new CultureInfo("en-PH");

                        foreach (DataRow row in filteredPartsTable.Rows)
                        {
                            decimal price = Convert.ToDecimal(row["price"]);
                            row["price"] = price.ToString("C", phCulture);
                        }

                        partsDataGridView.DataSource = filteredPartsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering parts by model: " + ex.Message);
            }
        }

        private void FilterPartsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT part_number, part_name, part_model, price, availability, category, description, created_at 
                             FROM parts_inventory
                             WHERE created_at BETWEEN @startDate AND @endDate";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                        cmd.Parameters.AddWithValue("@endDate", endDate.Date.AddDays(1).AddSeconds(-1));

                        DataTable filteredPartsTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(filteredPartsTable);
                        }

                        CultureInfo phCulture = new CultureInfo("en-PH");

                        foreach (DataRow row in filteredPartsTable.Rows)
                        {
                            decimal price = Convert.ToDecimal(row["price"]);
                            row["price"] = price.ToString("C", phCulture);
                        }

                        partsDataGridView.DataSource = filteredPartsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering parts by date range: " + ex.Message);
            }
        }

        private void category_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = category_cmbx.SelectedItem.ToString();

            FilterPartsByCategory(selectedCategory);
        }

        private void make_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModel = make_cmbx.SelectedItem.ToString();

            FilterPartsByModel(selectedModel);
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            PopulatePartsInventory();
        }

        private void filterDate_btn_Click(object sender, EventArgs e)
        {
            DateTime startDate = start_DatePicker.Value.Date;
            DateTime endDate = end_DatePicker.Value.Date;

            FilterPartsByDateRange(startDate, endDate);
        }

        private void exportExcel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)partsDataGridView.DataSource;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "Parts Records";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            IXLWorksheet worksheet = workbook.Worksheets.Add(dataTable, "PartsRecords");

                            worksheet.Columns().AdjustToContents();

                            workbook.SaveAs(saveFileDialog.FileName);

                            MessageBox.Show("Data exported to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
