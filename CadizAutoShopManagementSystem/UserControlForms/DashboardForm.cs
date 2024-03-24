using CadizAutoShopManagementSystem.Components;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class DashboardForm : UserControl
    {
        private LoadingStateForm loadingForm;

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            ShowLoadingForm();
            LoadReservationData();
            LoadPartsData();
            LoadMechanicData();
            LoadReservationStatusData();
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

        //SERVICES ON RESERVATION CHART
        private void LoadReservationData()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT s.serviceType, COUNT(r.reservation_id) AS reservation_count " +
                                   "FROM services s " +
                                   "LEFT JOIN reservations r ON s.service_id = r.service_id " +
                                   "GROUP BY s.service_id, s.serviceType";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        reservationChart.Series.Clear();
                        reservationChart.ChartAreas.Clear();

                        ChartArea chartArea = new ChartArea();
                        reservationChart.ChartAreas.Add(chartArea);

                        Series series = new Series("Reservations");
                        series.ChartType = SeriesChartType.Column;

                        series.Points.DataBind(dataTable.AsEnumerable(), "serviceType", "reservation_count", "");

                        reservationChart.Series.Add(series);

                        chartArea.AxisX.Title = "Services";
                        chartArea.AxisY.Title = "Reservation Count";
                        chartArea.AxisX.Interval = 1; 

                        series.IsValueShownAsLabel = true;

                        reservationChart.Invalidate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //PARTS CHART
        private void LoadPartsData()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT part_name, SUM(availability) AS total_availability " +
                                   "FROM parts_inventory " +
                                   "GROUP BY part_name";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        partsChart.Series.Clear();
                        partsChart.ChartAreas.Clear();

                        ChartArea chartArea = new ChartArea();
                        partsChart.ChartAreas.Add(chartArea);

                        Series series = new Series("Parts Availability");
                        series.ChartType = SeriesChartType.Line;

                        series.Color = Color.Orange;

                        series.Points.DataBind(dataTable.AsEnumerable(), "part_name", "total_availability", "");

                        foreach (DataPoint point in series.Points)
                        {
                            point.Color = Color.Orange;
                        }

                        partsChart.Series.Add(series);

                        chartArea.AxisX.Title = "Parts";
                        chartArea.AxisY.Title = "Total Availability";
                        chartArea.AxisX.Interval = 1;

                        series.IsValueShownAsLabel = true;

                        partsChart.Invalidate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //MECHANICS WORKING CHART
        private void LoadMechanicData()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT CONCAT(firstName, ' ', lastName) AS mechanicName, COUNT(r.reservation_id) AS reservation_count " +
                                   "FROM reservations r " +
                                   "LEFT JOIN mechanic_info m ON r.assigned_mechanic = m.mechanic_id " +
                                   "GROUP BY m.mechanic_id, mechanicName";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        mechanicChart.Series.Clear();
                        mechanicChart.ChartAreas.Clear();

                        ChartArea chartArea = new ChartArea();
                        mechanicChart.ChartAreas.Add(chartArea);

                        Series series = new Series("Reservation Count");
                        series.ChartType = SeriesChartType.Column;

                        series.Color = Color.Blue;

                        series.Points.DataBind(dataTable.AsEnumerable(), "mechanicName", "reservation_count", "");

                        foreach (DataPoint point in series.Points)
                        {
                            point.Color = Color.Blue;
                        }

                        mechanicChart.Series.Add(series);

                        chartArea.AxisX.Title = "Mechanics";
                        chartArea.AxisY.Title = "Reservation Count";
                        chartArea.AxisX.Interval = 1; 

                        series.IsValueShownAsLabel = true;

                        mechanicChart.Invalidate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //RESERVATION STATUS CHART
        private void LoadReservationStatusData()
        {
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT status, COUNT(reservation_id) AS reservation_count " +
                                   "FROM reservations " +
                                   "GROUP BY status";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        statusChart.Series.Clear();
                        statusChart.ChartAreas.Clear();

                        ChartArea chartArea = new ChartArea();
                        statusChart.ChartAreas.Add(chartArea);

                        Series series = new Series("Reservation Status");
                        series.ChartType = SeriesChartType.Pie;

                        series.Palette = ChartColorPalette.Excel;

                        series.Points.DataBind(dataTable.AsEnumerable(), "status", "reservation_count", "");

                        statusChart.Series.Add(series);

                        chartArea.AxisX.Title = "Reservation Status";
                        chartArea.AxisY.Title = "Reservation Count";

                        series.IsValueShownAsLabel = true;

                        statusChart.Invalidate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
