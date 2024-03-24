using CadizAutoShopManagementSystem.Components;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;
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
    public partial class LogInReportsForm : UserControl
    {
        private LoadingStateForm loadingForm;
        public LogInReportsForm()
        {
            ShowLoadingForm();
            InitializeComponent();
            PopulateLoginHistory();
            CloseLoadingForm();
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

        private void PopulateLoginHistory()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT u.user_id, u.firstName, u.lastName, ur.userRole, h.date, TIME_FORMAT(h.time, '%h:%i:%s %p') AS time
                                     FROM user_login_history AS h
                                     INNER JOIN users_information AS u ON h.user_id = u.user_id
                                     INNER JOIN users AS ur ON h.user_id = ur.user_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        DataTable loginHistoryTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(loginHistoryTable);
                        }

                        loginHistoryDataGrid.DataSource = loginHistoryTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving login history: " + ex.Message);
            }
        }

        private void ClearLoginHistory()
        {
            try
            {
                ShowLoadingForm();
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM user_login_history";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Login history cleared successfully.");
                            PopulateLoginHistory();
                        }
                        else
                        {
                            MessageBox.Show("No login history found to clear.");
                        }
                    }
                }
                CloseLoadingForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing login history: " + ex.Message);
            }
        }

        private void PopulateLoginHistory(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT u.user_id, u.firstName, u.lastName, ur.userRole, h.date, TIME_FORMAT(h.time, '%h:%i:%s %p') AS time
                             FROM user_login_history AS h
                             INNER JOIN users_information AS u ON h.user_id = u.user_id
                             INNER JOIN users AS ur ON h.user_id = ur.user_id
                             WHERE h.date BETWEEN @startDate AND @endDate";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                        cmd.Parameters.AddWithValue("@endDate", endDate.Date.AddDays(1).AddSeconds(-1));

                        DataTable loginHistoryTable = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(loginHistoryTable);
                        }

                        loginHistoryDataGrid.DataSource = loginHistoryTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving login history: " + ex.Message);
            }
        }

        private void clearData_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear all login history?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ClearLoginHistory();
            }
        }

        private void exportExcel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)loginHistoryDataGrid.DataSource;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "Log-In History Report";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            IXLWorksheet worksheet = workbook.Worksheets.Add(dataTable, "CompletedReservations");

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

        private void filterDate_btn_Click(object sender, EventArgs e)
        {
            DateTime startDate = start_DatePicker.Value.Date;
            DateTime endDate = end_DatePicker.Value.Date;

            PopulateLoginHistory(startDate, endDate);
        }
    }
}
