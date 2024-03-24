using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadizAutoShopManagementSystem.Components;
using CadizAutoShopManagementSystem.Forms;
using MySql.Data.MySqlClient;

namespace CadizAutoShopManagementSystem.UserControlForms
{
    public partial class LocalService : UserControl
    {
        private LoadingStateForm loadingForm;

        public LocalService()
        {
            InitializeComponent();
            LoadMechanics();
        }

        private void LocalService_Load(object sender, EventArgs e)
        {
            ShowLoadingForm();
            LoadStatusFilter();
            LoadMechanics();
            LoadServices();

            LoadLocalServiceData();

            PopulateMakeComboBox();
            PopulateFuelComboBox();
            PopulateVehicleTypeComboBox();
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


        private void GetDataForLocalService(int localServiceId)
        {
            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    ls.localService_id, 
                    ci.firstName AS customerFirstName, 
                    ci.middleName AS customerMiddleName, 
                    ci.lastName AS customerLastName, 
                    ci.email, 
                    ci.address, 
                    ci.contactNumber, 
                    s.serviceType, 
                    cv.make, 
                    cv.model, 
                    cv.year, 
                    cv.mileage, 
                    cv.fuel_type, 
                    cv.vehicle_type, 
                    cv.plate_number, 
                    CONCAT(m.firstName, ' ', m.lastName, ' (', m.specialization, ')') AS mechanicInfo,
                    ls.problem_description
                FROM 
                    local_service ls
                INNER JOIN 
                    customer_info ci ON ls.customer_id = ci.customer_id
                INNER JOIN 
                    services s ON ls.service_id = s.service_id
                INNER JOIN 
                    customer_vehicles cv ON ls.vehicle_id = cv.vehicle_id
                INNER JOIN 
                    mechanic_info m ON ls.assigned_mechanic = m.mechanic_id
                WHERE 
                    ls.localService_id = @LocalServiceId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalServiceId", localServiceId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string customerFirstName = reader.GetString("customerFirstName");
                                string customerMiddleName = reader.GetString("customerMiddleName");
                                string customerLastName = reader.GetString("customerLastName");
                                string email = reader.GetString("email");
                                string address = reader.GetString("address");
                                string contactNumber = reader.GetString("contactNumber");
                                string serviceName = reader.GetString("serviceType");
                                string make = reader.GetString("make");
                                string model = reader.GetString("model");
                                string year = reader.GetString("year");
                                string mileage = reader.GetString("mileage");
                                string fuelType = reader.GetString("fuel_type");
                                string vehicleType = reader.GetString("vehicle_type");
                                string plateNumber = reader.GetString("plate_number");
                                string mechanicInfo = reader.GetString("mechanicInfo");
                                string problemDescription = reader.GetString("problem_description");

                                firstName_txt.Text = customerFirstName;
                                middleName_txt.Text = customerMiddleName;
                                lastName_txt.Text = customerLastName;
                                email_txt.Text = email;
                                address_txt.Text = address;
                                contact_txt.Text = contactNumber;
                                serviceType_cmbx.Text = serviceName;
                                make_cmbx.Text = make;
                                model_txt.Text = model;
                                year_txt.Text = year;
                                mileage_txt.Text = mileage;
                                fuel_cmbx.Text = fuelType;
                                vehicleType_cmbx.Text = vehicleType;
                                plate_txt.Text = plateNumber;
                                selectMechanic_cmbx.Text = mechanicInfo;
                                problem_txt.Text = problemDescription;
                            }
                            else
                            {
                                MessageBox.Show("No data found for the provided local service ID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
                }
            }
        }

        private void LoadLocalServiceData()
        {
             localService_dgv.Rows.Clear();

             using (MySqlConnection connection = DatabaseManager.GetConnection())
             {
                 try
                 {
                     connection.Open();

                     string query = @"SELECT ls.localService_id, 
                                 CONCAT(ci.firstName, ' ', ci.lastName) AS CustomerName, 
                                 s.serviceType AS ServiceType, 
                                 CONCAT(cv.make, ' ', cv.model) AS VehicleDetails,
                                 ls.status,
                                 ls.problem_description AS ProblemDescription, 
                                 ls.created_at AS Date
                          FROM local_service ls
                          INNER JOIN customer_info ci ON ls.customer_id = ci.customer_id
                          INNER JOIN customer_vehicles cv ON ls.vehicle_id = cv.vehicle_id
                          INNER JOIN services s ON ls.service_id = s.service_id";

                     using (MySqlCommand command = new MySqlCommand(query, connection))
                     {
                         using (MySqlDataReader reader = command.ExecuteReader())
                         {
                             while (reader.Read())
                             {
                                 int localServiceId = reader.GetInt32("localService_id");
                                 string customerName = reader.GetString("customerName");
                                 string serviceType = reader.GetString("serviceType");
                                 string vehicleDetails = reader.GetString("vehicleDetails");
                                 string problemDescription = reader.GetString("problemDescription");
                                 string status = reader.GetString("status");
                                 DateTime date = reader.GetDateTime("date");

                                 localService_dgv.Rows.Add(localServiceId, customerName, serviceType, vehicleDetails, problemDescription, date, status);
                             }
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("An error occurred while loading local services: " + ex.Message);
                 }
             }
         }

        public class MechanicItem
        {
            public int MechanicId { get; }
            public string DisplayText { get; }
            public int Id { get; internal set; }

            public MechanicItem(int mechanicId, string displayText)
            {
                MechanicId = mechanicId;
                DisplayText = displayText;
            }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        public class ServiceItem
        {
            public int ServiceId { get; }
            public string ServiceType { get; }

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

        private void LoadMechanics()
        {
            selectMechanic_cmbx.Items.Clear();
            filterMechanic_cmbx.Items.Clear();

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT mechanic_id, firstName, lastName, specialization FROM mechanic_info";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int mechanicId = reader.GetInt32("mechanic_id");
                                string firstName = reader.GetString("firstName");
                                string lastName = reader.GetString("lastName");
                                string specialization = reader.GetString("specialization");

                                string displayText = $"{firstName} {lastName} ({specialization})";

                                MechanicItem mechanicItem = new MechanicItem(mechanicId, displayText);

                                selectMechanic_cmbx.Items.Add(mechanicItem);
                                filterMechanic_cmbx.Items.Add(mechanicItem);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading mechanics: " + ex.Message);
                }
            }
        }

        private void LoadServices()
        {
            serviceType_cmbx.Items.Clear();
            filterService_cmbx.Items.Clear();

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
                                filterService_cmbx.Items.Add(serviceItem);
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

        private void LoadStatusFilter()
        {
            filterStatus_cmbx.Items.Clear();

            filterStatus_cmbx.Items.Add("Pending");
            filterStatus_cmbx.Items.Add("On-Progress");
            filterStatus_cmbx.Items.Add("Done");
            filterStatus_cmbx.Items.Add("Completed");
            filterStatus_cmbx.SelectedIndex = 0;
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
            selectMechanic_cmbx.SelectedIndex = -1;
            serviceType_cmbx.SelectedIndex = -1;
        }

        private void PopulateMakeComboBox()
        {
            make_cmbx.Items.AddRange(new object[]{"Isuzu", "Mitsubishi", "Toyota", "Ford", "Hyundai", "Kia", "Mazda", "Nissan", "Honda", "Chevrolet", "Mercedes-Benz", "Jeep"});
        }

        private void PopulateFuelComboBox()
        {
            fuel_cmbx.Items.AddRange(new object[] { "Diesel", "Petrol" });
        }

        private void PopulateVehicleTypeComboBox()
        {
            vehicleType_cmbx.Items.AddRange(new object[] { "Sedan", "Hatchback", "SUV", "Crossover", "Commercial Truck", "Commercial Van", "Passenger Van", "Jeep" });
        }


        private void Add_btn_Click(object sender, EventArgs e)
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
            MechanicItem selectedMechanic = selectMechanic_cmbx.SelectedItem as MechanicItem;
            ServiceItem selectedService = serviceType_cmbx.SelectedItem as ServiceItem;

            if (selectedMechanic == null)
            {
                MessageBox.Show("Please select a mechanic.");
                return;
            }

            if (selectedService == null)
            {
                MessageBox.Show("Please select a service.");
                return;
            }

            int mechanicId = selectedMechanic.MechanicId;
            int serviceId = selectedService.ServiceId;

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
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

                            string localServiceQuery = "INSERT INTO local_service (customer_id, vehicle_id, assigned_mechanic, problem_description, service_id, status) VALUES (@CustomerId, @VehicleId, @AssignedMechanic, @ProblemDescription, @ServiceId, 'Pending');";

                            using (MySqlCommand serviceCommand = new MySqlCommand(localServiceQuery, connection))
                            {
                                serviceCommand.Parameters.AddWithValue("@CustomerId", customerId);
                                serviceCommand.Parameters.AddWithValue("@VehicleId", vehicleId);
                                serviceCommand.Parameters.AddWithValue("@AssignedMechanic", mechanicId);
                                serviceCommand.Parameters.AddWithValue("@ProblemDescription", problemDescription);
                                serviceCommand.Parameters.AddWithValue("@ServiceId", serviceId);

                                int rowsAffected = serviceCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Customer, vehicle, and service added successfully.");
                                    ClearTextBoxes();
                                    LoadLocalServiceData();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add customer, vehicle, and service.");
                                }
                            }
                        }
                    }
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

        private void LocalService_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < localService_dgv.Rows.Count)
            {
                DataGridViewRow selectedRow = localService_dgv.Rows[e.RowIndex];
                int localServiceId = Convert.ToInt32(selectedRow.Cells["id_column"].Value);

                localServiceId_txt.Text = localServiceId.ToString();
            }
        }

        private void localServiceId_txt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(localServiceId_txt.Text))
            {
                int localServiceId;
                if (int.TryParse(localServiceId_txt.Text, out localServiceId))
                {
                    GetDataForLocalService(localServiceId);
                }
                else
                {
                    MessageBox.Show("Invalid local service ID. Please enter a valid integer.");
                }
            }
        }

        private void filterMechanic_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            MechanicItem selectedMechanic = filterMechanic_cmbx.SelectedItem as MechanicItem;

            if (selectedMechanic != null)
            {
                int mechanicId = selectedMechanic.MechanicId;

                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = @"
                    SELECT 
                        ls.localService_id, 
                        CONCAT(ci.firstName, ' ', ci.lastName) AS CustomerName, 
                        s.serviceType AS ServiceType, 
                        CONCAT(cv.make, ' ', cv.model) AS VehicleDetails,
                        ls.status,
                        ls.problem_description AS ProblemDescription, 
                        ls.created_at AS Date
                    FROM 
                        local_service ls
                    INNER JOIN 
                        customer_info ci ON ls.customer_id = ci.customer_id
                    INNER JOIN 
                        customer_vehicles cv ON ls.vehicle_id = cv.vehicle_id
                    INNER JOIN 
                        services s ON ls.service_id = s.service_id
                    WHERE 
                        ls.assigned_mechanic = @MechanicId";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MechanicId", mechanicId);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                localService_dgv.Rows.Clear();

                                while (reader.Read())
                                {
                                    int localServiceId = reader.GetInt32("localService_id");
                                    string customerName = reader.GetString("CustomerName");
                                    string serviceType = reader.GetString("ServiceType");
                                    string vehicleDetails = reader.GetString("VehicleDetails");
                                    string problemDescription = reader.GetString("ProblemDescription");
                                    string status = reader.GetString("status");
                                    DateTime date = reader.GetDateTime("Date");

                                    localService_dgv.Rows.Add(localServiceId, customerName, serviceType, vehicleDetails, problemDescription, date, status);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while filtering data: " + ex.Message);
                    }
                }
            }
        }

        private void filterService_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceItem selectedService = filterService_cmbx.SelectedItem as ServiceItem;

            if (selectedService != null)
            {
                int serviceId = selectedService.ServiceId;

                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = @"
                    SELECT 
                        ls.localService_id, 
                        CONCAT(ci.firstName, ' ', ci.lastName) AS CustomerName, 
                        s.serviceType AS ServiceType, 
                        CONCAT(cv.make, ' ', cv.model) AS VehicleDetails,
                        ls.status,
                        ls.problem_description AS ProblemDescription, 
                        ls.created_at AS Date
                    FROM 
                        local_service ls
                    INNER JOIN 
                        customer_info ci ON ls.customer_id = ci.customer_id
                    INNER JOIN 
                        customer_vehicles cv ON ls.vehicle_id = cv.vehicle_id
                    INNER JOIN 
                        services s ON ls.service_id = s.service_id
                    WHERE 
                        ls.service_id = @ServiceId";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ServiceId", serviceId);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                localService_dgv.Rows.Clear();

                                while (reader.Read())
                                {
                                    int localServiceId = reader.GetInt32("localService_id");
                                    string customerName = reader.GetString("CustomerName");
                                    string serviceType = reader.GetString("ServiceType");
                                    string vehicleDetails = reader.GetString("VehicleDetails");
                                    string problemDescription = reader.GetString("ProblemDescription");
                                    string status = reader.GetString("status");
                                    DateTime date = reader.GetDateTime("Date");

                                    localService_dgv.Rows.Add(localServiceId, customerName, serviceType, vehicleDetails, problemDescription, date, status);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while filtering data: " + ex.Message);
                    }
                }
            }
        }

        private void filterStatus_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = filterStatus_cmbx.SelectedItem.ToString();

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    ls.localService_id, 
                    CONCAT(ci.firstName, ' ', ci.lastName) AS CustomerName, 
                    s.serviceType AS ServiceType, 
                    CONCAT(cv.make, ' ', cv.model) AS VehicleDetails,
                    ls.status,
                    ls.problem_description AS ProblemDescription, 
                    ls.created_at AS Date
                FROM 
                    local_service ls
                INNER JOIN 
                    customer_info ci ON ls.customer_id = ci.customer_id
                INNER JOIN 
                    customer_vehicles cv ON ls.vehicle_id = cv.vehicle_id
                INNER JOIN 
                    services s ON ls.service_id = s.service_id
                WHERE 
                    ls.status = @Status";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", selectedStatus);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            localService_dgv.Rows.Clear();

                            while (reader.Read())
                            {
                                int localServiceId = reader.GetInt32("localService_id");
                                string customerName = reader.GetString("CustomerName");
                                string serviceType = reader.GetString("ServiceType");
                                string vehicleDetails = reader.GetString("VehicleDetails");
                                string problemDescription = reader.GetString("ProblemDescription");
                                string status = reader.GetString("status");
                                DateTime date = reader.GetDateTime("Date");

                                localService_dgv.Rows.Add(localServiceId, customerName, serviceType, vehicleDetails, problemDescription, date, status);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while filtering data: " + ex.Message);
                }
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = search_txt.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = @"
                    SELECT 
                        ls.localService_id, 
                        CONCAT(ci.firstName, ' ', ci.lastName) AS CustomerName, 
                        s.serviceType AS ServiceType, 
                        CONCAT(cv.make, ' ', cv.model) AS VehicleDetails,
                        ls.status,
                        ls.problem_description AS ProblemDescription, 
                        ls.created_at AS Date
                    FROM 
                        local_service ls
                    INNER JOIN 
                        customer_info ci ON ls.customer_id = ci.customer_id
                    INNER JOIN 
                        customer_vehicles cv ON ls.vehicle_id = cv.vehicle_id
                    INNER JOIN 
                        services s ON ls.service_id = s.service_id
                    WHERE 
                        ci.firstName LIKE @SearchTerm OR
                        ci.lastName LIKE @SearchTerm OR
                        cv.make LIKE @SearchTerm OR
                        cv.model LIKE @SearchTerm";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                localService_dgv.Rows.Clear();

                                while (reader.Read())
                                {
                                    int localServiceId = reader.GetInt32("localService_id");
                                    string customerName = reader.GetString("CustomerName");
                                    string serviceType = reader.GetString("ServiceType");
                                    string vehicleDetails = reader.GetString("VehicleDetails");
                                    string problemDescription = reader.GetString("ProblemDescription");
                                    string status = reader.GetString("status");
                                    DateTime date = reader.GetDateTime("Date");

                                    localService_dgv.Rows.Add(localServiceId, customerName, serviceType, vehicleDetails, problemDescription, date, status);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while searching: " + ex.Message);
                    }
                }
            }
            else
            {
                LoadLocalServiceData();
            }
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            search_txt.Clear();
            LoadLocalServiceData();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(localServiceId_txt.Text, out int localServiceId))
            {
                MessageBox.Show("Invalid local service ID. Please select a local service.");
                return;
            }

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
            MechanicItem selectedMechanic = selectMechanic_cmbx.SelectedItem as MechanicItem;
            ServiceItem selectedService = serviceType_cmbx.SelectedItem as ServiceItem;

            if (selectedMechanic == null)
            {
                MessageBox.Show("Please select a mechanic.");
                return;
            }

            if (selectedService == null)
            {
                MessageBox.Show("Please select a service.");
                return;
            }

            int mechanicId = selectedMechanic.MechanicId;
            int serviceId = selectedService.ServiceId;

            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();

                    string updateQuery = @"
                UPDATE customer_info 
                SET 
                    firstName = @FirstName, 
                    middleName = @MiddleName, 
                    lastName = @LastName, 
                    email = @Email, 
                    address = @Address, 
                    contactNumber = @ContactNumber 
                WHERE 
                    customer_id = (
                        SELECT customer_id 
                        FROM local_service 
                        WHERE localService_id = @LocalServiceId
                    );

                UPDATE customer_vehicles 
                SET 
                    make = @Make, 
                    model = @Model, 
                    year = @Year, 
                    mileage = @Mileage, 
                    fuel_type = @FuelType, 
                    vehicle_type = @VehicleType, 
                    plate_number = @PlateNumber 
                WHERE 
                    vehicle_id = (
                        SELECT vehicle_id 
                        FROM local_service 
                        WHERE localService_id = @LocalServiceId
                    );

                UPDATE local_service 
                SET 
                    assigned_mechanic = @AssignedMechanic, 
                    problem_description = @ProblemDescription, 
                    service_id = @ServiceId
                WHERE 
                    localService_id = @LocalServiceId";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@LocalServiceId", localServiceId);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@MiddleName", middleName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        command.Parameters.AddWithValue("@Make", make);
                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@Mileage", mileage);
                        command.Parameters.AddWithValue("@FuelType", fuelType);
                        command.Parameters.AddWithValue("@VehicleType", vehicleType);
                        command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                        command.Parameters.AddWithValue("@ProblemDescription", problemDescription);
                        command.Parameters.AddWithValue("@AssignedMechanic", mechanicId);
                        command.Parameters.AddWithValue("@ServiceId", serviceId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Local service updated successfully.");
                            LoadLocalServiceData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update local service.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating local service: " + ex.Message);
                }
            }
        }

        private void DeleteLocalService(int localServiceId)
        {
            using (MySqlConnection connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM local_service WHERE localService_id = @LocalServiceId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalServiceId", localServiceId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Local service deleted successfully.");
                            LoadLocalServiceData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete local service.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting local service: " + ex.Message);
                }
            }
        }

        private void localService_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (localService_dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    if (e.ColumnIndex == markBtn_Column.Index)
                    {
                        int localServiceId = Convert.ToInt32(localService_dgv.Rows[e.RowIndex].Cells["id_column"].Value);

                        LocalServicesMarkingForm markingForm = new LocalServicesMarkingForm(localServiceId);
                        markingForm.ShowDialog();
                    }
                    else if (e.ColumnIndex == deleteBtn_column.Index)
                    {
                        int localServiceId = Convert.ToInt32(localService_dgv.Rows[e.RowIndex].Cells["id_column"].Value);

                        DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            DeleteLocalService(localServiceId);
                        }
                    }
                }
            }
        }
    }
}
