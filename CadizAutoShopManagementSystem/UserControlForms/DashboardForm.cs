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
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadReservationData();
            LoadPartsData();
            LoadMechanicData();
            LoadReservationStatusData();
        }

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

                        // Clear existing data in the chart
                        reservationChart.Series.Clear();
                        reservationChart.ChartAreas.Clear();

                        // Add a new chart area
                        ChartArea chartArea = new ChartArea();
                        reservationChart.ChartAreas.Add(chartArea);

                        // Add a new series (column chart)
                        Series series = new Series("Reservations");
                        series.ChartType = SeriesChartType.Column;

                        // Bind the series to the data table
                        series.Points.DataBind(dataTable.AsEnumerable(), "serviceType", "reservation_count", "");

                        // Add the series to the chart
                        reservationChart.Series.Add(series);

                        // Customize chart appearance
                        chartArea.AxisX.Title = "Services";
                        chartArea.AxisY.Title = "Reservation Count";
                        chartArea.AxisX.Interval = 1; // Display every data point on the X-axis

                        // Show data point labels
                        series.IsValueShownAsLabel = true;

                        // Refresh the chart
                        reservationChart.Invalidate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

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

                        // Clear existing data in the chart
                        partsChart.Series.Clear();
                        partsChart.ChartAreas.Clear();

                        // Add a new chart area
                        ChartArea chartArea = new ChartArea();
                        partsChart.ChartAreas.Add(chartArea);

                        // Add a new series (line chart)
                        Series series = new Series("Parts Availability");
                        series.ChartType = SeriesChartType.Line;

                        // Set the series color to orange
                        series.Color = Color.Orange;

                        // Bind the series to the data table
                        series.Points.DataBind(dataTable.AsEnumerable(), "part_name", "total_availability", "");

                        // Set the data point color to orange
                        foreach (DataPoint point in series.Points)
                        {
                            point.Color = Color.Orange;
                        }

                        // Add the series to the chart
                        partsChart.Series.Add(series);

                        // Customize chart appearance
                        chartArea.AxisX.Title = "Parts";
                        chartArea.AxisY.Title = "Total Availability";
                        chartArea.AxisX.Interval = 1; // Display every data point on the X-axis

                        // Show data point labels
                        series.IsValueShownAsLabel = true;

                        // Refresh the chart
                        partsChart.Invalidate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

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

                        // Clear existing data in the chart
                        mechanicChart.Series.Clear();
                        mechanicChart.ChartAreas.Clear();

                        // Add a new chart area
                        ChartArea chartArea = new ChartArea();
                        mechanicChart.ChartAreas.Add(chartArea);

                        // Add a new series (column chart)
                        Series series = new Series("Reservation Count");
                        series.ChartType = SeriesChartType.Column;

                        // Set the series color to blue (you can change it to your desired color)
                        series.Color = Color.Blue;

                        // Bind the series to the data table
                        series.Points.DataBind(dataTable.AsEnumerable(), "mechanicName", "reservation_count", "");

                        // Set the data point color to blue
                        foreach (DataPoint point in series.Points)
                        {
                            point.Color = Color.Blue;
                        }

                        // Add the series to the chart
                        mechanicChart.Series.Add(series);

                        // Customize chart appearance
                        chartArea.AxisX.Title = "Mechanics";
                        chartArea.AxisY.Title = "Reservation Count";
                        chartArea.AxisX.Interval = 1; // Display every data point on the X-axis

                        // Show data point labels
                        series.IsValueShownAsLabel = true;

                        // Refresh the chart
                        mechanicChart.Invalidate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

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

                        // Clear existing data in the chart
                        statusChart.Series.Clear();
                        statusChart.ChartAreas.Clear();

                        // Add a new chart area
                        ChartArea chartArea = new ChartArea();
                        statusChart.ChartAreas.Add(chartArea);

                        // Add a new series (pie chart)
                        Series series = new Series("Reservation Status");
                        series.ChartType = SeriesChartType.Pie;

                        // Set the series color palette to a custom color palette
                        series.Palette = ChartColorPalette.Excel;

                        // Bind the series to the data table
                        series.Points.DataBind(dataTable.AsEnumerable(), "status", "reservation_count", "");

                        // Add the series to the chart
                        statusChart.Series.Add(series);

                        // Customize chart appearance
                        chartArea.AxisX.Title = "Reservation Status";
                        chartArea.AxisY.Title = "Reservation Count";

                        // Show data point labels
                        series.IsValueShownAsLabel = true;

                        // Refresh the chart
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
