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

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class LocalReservationForm : UserControl
    {
        private LoadingStateForm loadingForm;

        public LocalReservationForm()
        {
            ShowLoadingForm();
            InitializeComponent();

            dateTime_picker.Format = DateTimePickerFormat.Custom;
            dateTime_picker.CustomFormat = "MM/dd/yyyy hh:mm tt";

            PopulateMakeComboBox();
            PopulateFuelComboBox();
            PopulateVehicleTypeComboBox();

            LoadServices();
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

        private void PopulateMakeComboBox()
        {
            make_cmbx.Items.AddRange(new object[] { "Isuzu", "Mitsubishi", "Toyota", "Ford", "Hyundai", "Kia", "Mazda", "Nissan", "Honda", "Chevrolet", "Mercedes-Benz", "Jeep" });
        }

        private void PopulateFuelComboBox()
        {
            fuel_cmbx.Items.AddRange(new object[] { "Diesel", "Petrol" });
        }

        private void PopulateVehicleTypeComboBox()
        {
            vehicleType_cmbx.Items.AddRange(new object[] { "Sedan", "Hatchback", "SUV", "Crossover", "Commercial Truck", "Commercial Van", "Passenger Van", "Jeep" });
        }

        public class ServiceItem
        {
            public int ServiceId { get; set; }
            public string ServiceType { get; set; }

            public ServiceItem(int serviceId, string serviceType)
            {
                ServiceId = serviceId;
                ServiceType = serviceType;
            }

            public override string ToString()
            {
                return ServiceType;
            }
        }

        private void LoadServices()
        {
            serviceType_cmbx.Items.Clear();

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT service_id, serviceType FROM services";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int serviceId = reader.GetInt32("service_id");
                                string serviceType = reader.GetString("serviceType");

                                ServiceItem serviceItem = new ServiceItem(serviceId, serviceType);

                                serviceType_cmbx.Items.Add(serviceItem);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading services: " + ex.Message);
                }
            }
        }

        private void ClearTextBoxes()
        {
            firstName_txt.Clear();
            middleName_txt.Clear();
            lastName_txt.Clear();
            email_txt.Clear();
            address_txt.Clear();
            contact_txt.Clear();
            make_cmbx.SelectedIndex = -1;
            model_txt.Clear();
            year_txt.Clear();
            mileage_txt.Clear();
            fuel_cmbx.SelectedIndex = -1;
            vehicleType_cmbx.SelectedIndex = -1;
            plate_txt.Clear();
            problem_txt.Clear();
            serviceType_cmbx.SelectedIndex = -1;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string firstName = firstName_txt.Text;
            string middleName = middleName_txt.Text;
            string lastName = lastName_txt.Text;
            string email = email_txt.Text;
            string address = address_txt.Text;
            string contactNumber = contact_txt.Text;

            string make = make_cmbx.Text;
            string model = model_txt.Text;
            string year = year_txt.Text;
            string mileage = mileage_txt.Text;
            string fuelType = fuel_cmbx.Text;
            string vehicleType = vehicleType_cmbx.Text;
            string plateNumber = plate_txt.Text;

            string problemDescription = problem_txt.Text;
            ServiceItem selectedService = serviceType_cmbx.SelectedItem as ServiceItem;
            DateTime reservationDateTime = dateTime_picker.Value;

            if (selectedService == null)
            {
                MessageBox.Show("Please select a service.");
                return;
            }

            int serviceId = selectedService.ServiceId;

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    ShowLoadingForm();
                    connection.Open();

                    string customerInfoQuery = "INSERT INTO customer_info (firstName, middleName, lastName, email, address, contactNumber) VALUES (@FirstName, @MiddleName, @LastName, @Email, @Address, @ContactNumber); SELECT LAST_INSERT_ID();";

                    using (MySqlCommand command = new MySqlCommand(customerInfoQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@MiddleName", middleName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@ContactNumber", contactNumber);

                        int customerId = Convert.ToInt32(command.ExecuteScalar());

                        string customerVehiclesQuery = "INSERT INTO customer_vehicles (customer_id, make, model, year, mileage, fuel_type, vehicle_type, plate_number) VALUES (@CustomerId, @Make, @Model, @Year, @Mileage, @FuelType, @VehicleType, @PlateNumber); SELECT LAST_INSERT_ID();";

                        using (MySqlCommand vehicleCommand = new MySqlCommand(customerVehiclesQuery, connection))
                        {
                            vehicleCommand.Parameters.AddWithValue("@CustomerId", customerId);
                            vehicleCommand.Parameters.AddWithValue("@Make", make);
                            vehicleCommand.Parameters.AddWithValue("@Model", model);
                            vehicleCommand.Parameters.AddWithValue("@Year", year);
                            vehicleCommand.Parameters.AddWithValue("@Mileage", mileage);
                            vehicleCommand.Parameters.AddWithValue("@FuelType", fuelType);
                            vehicleCommand.Parameters.AddWithValue("@VehicleType", vehicleType);
                            vehicleCommand.Parameters.AddWithValue("@PlateNumber", plateNumber);

                            int vehicleId = Convert.ToInt32(vehicleCommand.ExecuteScalar());

                            string reservationQuery = "INSERT INTO reservations (customer_id, service_id, vehicle_id, problem_description, date, time) VALUES (@CustomerId, @ServiceId, @VehicleId, @ProblemDescription, @Date, @Time);";

                            using (MySqlCommand reservationCommand = new MySqlCommand(reservationQuery, connection))
                            {
                                reservationCommand.Parameters.AddWithValue("@CustomerId", customerId);
                                reservationCommand.Parameters.AddWithValue("@ServiceId", serviceId);
                                reservationCommand.Parameters.AddWithValue("@VehicleId", vehicleId);
                                reservationCommand.Parameters.AddWithValue("@ProblemDescription", problemDescription);
                                reservationCommand.Parameters.AddWithValue("@Date", reservationDateTime.Date);
                                reservationCommand.Parameters.AddWithValue("@Time", reservationDateTime.TimeOfDay);

                                int rowsAffected = reservationCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Reservation added successfully.");
                                    ClearTextBoxes();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add reservation.");
                                }
                            }
                        }
                    }
                    CloseLoadingForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
