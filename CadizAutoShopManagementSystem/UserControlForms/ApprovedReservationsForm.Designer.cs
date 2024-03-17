
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class ApprovedReservationsForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showAll_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.customerId_txt = new System.Windows.Forms.TextBox();
            this.customerEmail_txt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.customerAddress_txt = new System.Windows.Forms.TextBox();
            this.customerContact_txt = new System.Windows.Forms.TextBox();
            this.customerName_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.searchByCustomerName_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.filterByMechanic_cmbx = new System.Windows.Forms.ComboBox();
            this.filterByServiceType_cmbx = new System.Windows.Forms.ComboBox();
            this.approvedReservationsDataGrid = new System.Windows.Forms.DataGridView();
            this.reservationId_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerId_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleId_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoneColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CancelColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mechanicAssigned_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.problemDescription_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceType_txt = new System.Windows.Forms.TextBox();
            this.reservationId_txt = new System.Windows.Forms.TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vehiclePlateNumber_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.vehicleType_txt = new System.Windows.Forms.TextBox();
            this.vehicleYear_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vehicleModel_txt = new System.Windows.Forms.TextBox();
            this.vehicleMake_txt = new System.Windows.Forms.TextBox();
            this.vehicleId_txt = new System.Windows.Forms.TextBox();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approvedReservationsDataGrid)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // showAll_btn
            // 
            this.showAll_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showAll_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showAll_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAll_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showAll_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showAll_btn.ForeColor = System.Drawing.Color.White;
            this.showAll_btn.Location = new System.Drawing.Point(1156, 364);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(107, 21);
            this.showAll_btn.TabIndex = 52;
            this.showAll_btn.Text = "SHOW ALL";
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox3.Controls.Add(this.label15);
            this.guna2GroupBox3.Controls.Add(this.customerId_txt);
            this.guna2GroupBox3.Controls.Add(this.customerEmail_txt);
            this.guna2GroupBox3.Controls.Add(this.label17);
            this.guna2GroupBox3.Controls.Add(this.label18);
            this.guna2GroupBox3.Controls.Add(this.label19);
            this.guna2GroupBox3.Controls.Add(this.label20);
            this.guna2GroupBox3.Controls.Add(this.customerAddress_txt);
            this.guna2GroupBox3.Controls.Add(this.customerContact_txt);
            this.guna2GroupBox3.Controls.Add(this.customerName_txt);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(866, 22);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(397, 283);
            this.guna2GroupBox3.TabIndex = 53;
            this.guna2GroupBox3.Text = "Customer Information";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Customer ID:";
            // 
            // customerId_txt
            // 
            this.customerId_txt.Location = new System.Drawing.Point(85, 55);
            this.customerId_txt.Name = "customerId_txt";
            this.customerId_txt.ReadOnly = true;
            this.customerId_txt.Size = new System.Drawing.Size(301, 23);
            this.customerId_txt.TabIndex = 17;
            // 
            // customerEmail_txt
            // 
            this.customerEmail_txt.Location = new System.Drawing.Point(85, 219);
            this.customerEmail_txt.Name = "customerEmail_txt";
            this.customerEmail_txt.ReadOnly = true;
            this.customerEmail_txt.Size = new System.Drawing.Size(301, 23);
            this.customerEmail_txt.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 15);
            this.label17.TabIndex = 15;
            this.label17.Text = "Email:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 13;
            this.label18.Text = "Address:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 15);
            this.label19.TabIndex = 12;
            this.label19.Text = "Contact #:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(37, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "Name:";
            // 
            // customerAddress_txt
            // 
            this.customerAddress_txt.Location = new System.Drawing.Point(85, 142);
            this.customerAddress_txt.Multiline = true;
            this.customerAddress_txt.Name = "customerAddress_txt";
            this.customerAddress_txt.ReadOnly = true;
            this.customerAddress_txt.Size = new System.Drawing.Size(301, 71);
            this.customerAddress_txt.TabIndex = 10;
            // 
            // customerContact_txt
            // 
            this.customerContact_txt.Location = new System.Drawing.Point(85, 113);
            this.customerContact_txt.Name = "customerContact_txt";
            this.customerContact_txt.ReadOnly = true;
            this.customerContact_txt.Size = new System.Drawing.Size(301, 23);
            this.customerContact_txt.TabIndex = 9;
            // 
            // customerName_txt
            // 
            this.customerName_txt.Location = new System.Drawing.Point(85, 84);
            this.customerName_txt.Name = "customerName_txt";
            this.customerName_txt.ReadOnly = true;
            this.customerName_txt.Size = new System.Drawing.Size(301, 23);
            this.customerName_txt.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Search by Customer Name:";
            // 
            // searchByCustomerName_txt
            // 
            this.searchByCustomerName_txt.Location = new System.Drawing.Point(161, 363);
            this.searchByCustomerName_txt.Name = "searchByCustomerName_txt";
            this.searchByCustomerName_txt.Size = new System.Drawing.Size(253, 20);
            this.searchByCustomerName_txt.TabIndex = 50;
            this.searchByCustomerName_txt.TextChanged += new System.EventHandler(this.searchCustomer);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(810, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Filter by Mechanic Assigned:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(839, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Filter By Service Type:";
            // 
            // filterByMechanic_cmbx
            // 
            this.filterByMechanic_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterByMechanic_cmbx.FormattingEnabled = true;
            this.filterByMechanic_cmbx.Location = new System.Drawing.Point(958, 311);
            this.filterByMechanic_cmbx.Name = "filterByMechanic_cmbx";
            this.filterByMechanic_cmbx.Size = new System.Drawing.Size(305, 21);
            this.filterByMechanic_cmbx.TabIndex = 47;
            this.filterByMechanic_cmbx.SelectedIndexChanged += new System.EventHandler(this.filterByMechanicAssignedIndexChanged);
            // 
            // filterByServiceType_cmbx
            // 
            this.filterByServiceType_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterByServiceType_cmbx.FormattingEnabled = true;
            this.filterByServiceType_cmbx.Location = new System.Drawing.Point(958, 338);
            this.filterByServiceType_cmbx.Name = "filterByServiceType_cmbx";
            this.filterByServiceType_cmbx.Size = new System.Drawing.Size(305, 21);
            this.filterByServiceType_cmbx.TabIndex = 46;
            this.filterByServiceType_cmbx.SelectedIndexChanged += new System.EventHandler(this.filterByServiceTypeIndexChanged);
            // 
            // approvedReservationsDataGrid
            // 
            this.approvedReservationsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.approvedReservationsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationId_column,
            this.customerId_column,
            this.Column3,
            this.vehicleId_column,
            this.Column5,
            this.DoneColumn,
            this.CancelColumn});
            this.approvedReservationsDataGrid.Location = new System.Drawing.Point(18, 389);
            this.approvedReservationsDataGrid.Name = "approvedReservationsDataGrid";
            this.approvedReservationsDataGrid.RowHeadersVisible = false;
            this.approvedReservationsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.approvedReservationsDataGrid.ShowCellErrors = false;
            this.approvedReservationsDataGrid.ShowCellToolTips = false;
            this.approvedReservationsDataGrid.ShowEditingIcon = false;
            this.approvedReservationsDataGrid.ShowRowErrors = false;
            this.approvedReservationsDataGrid.Size = new System.Drawing.Size(1245, 321);
            this.approvedReservationsDataGrid.TabIndex = 43;
            this.approvedReservationsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.approvedReservationsDataGrid_CellClick);
            this.approvedReservationsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buttonClick);
            // 
            // reservationId_column
            // 
            this.reservationId_column.DataPropertyName = "reservation_id";
            this.reservationId_column.HeaderText = "Reservation ID";
            this.reservationId_column.Name = "reservationId_column";
            this.reservationId_column.Width = 120;
            // 
            // customerId_column
            // 
            this.customerId_column.DataPropertyName = "customerName";
            this.customerId_column.HeaderText = "CUSTOMER NAME";
            this.customerId_column.Name = "customerId_column";
            this.customerId_column.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "serviceType";
            this.Column3.HeaderText = "SERVICE TYPE";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // vehicleId_column
            // 
            this.vehicleId_column.DataPropertyName = "vehicleName";
            this.vehicleId_column.HeaderText = "UNIT";
            this.vehicleId_column.Name = "vehicleId_column";
            this.vehicleId_column.Width = 250;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "mechanicName";
            this.Column5.HeaderText = "ASSIGNED MECHANIC";
            this.Column5.Name = "Column5";
            this.Column5.Width = 172;
            // 
            // DoneColumn
            // 
            this.DoneColumn.HeaderText = "ACTION";
            this.DoneColumn.Name = "DoneColumn";
            this.DoneColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DoneColumn.Text = "DONE";
            this.DoneColumn.UseColumnTextForButtonValue = true;
            // 
            // CancelColumn
            // 
            this.CancelColumn.HeaderText = "ACTION";
            this.CancelColumn.Name = "CancelColumn";
            this.CancelColumn.Text = "CANCEL";
            this.CancelColumn.UseColumnTextForButtonValue = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.mechanicAssigned_txt);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.problemDescription_txt);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.serviceType_txt);
            this.guna2GroupBox1.Controls.Add(this.reservationId_txt);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(18, 22);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(448, 283);
            this.guna2GroupBox1.TabIndex = 44;
            this.guna2GroupBox1.Text = "Reservation Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Mechanic Assigned:";
            // 
            // mechanicAssigned_txt
            // 
            this.mechanicAssigned_txt.Location = new System.Drawing.Point(139, 200);
            this.mechanicAssigned_txt.Name = "mechanicAssigned_txt";
            this.mechanicAssigned_txt.ReadOnly = true;
            this.mechanicAssigned_txt.Size = new System.Drawing.Size(300, 23);
            this.mechanicAssigned_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Problem Description:";
            // 
            // problemDescription_txt
            // 
            this.problemDescription_txt.Location = new System.Drawing.Point(139, 112);
            this.problemDescription_txt.Multiline = true;
            this.problemDescription_txt.Name = "problemDescription_txt";
            this.problemDescription_txt.ReadOnly = true;
            this.problemDescription_txt.Size = new System.Drawing.Size(300, 82);
            this.problemDescription_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Service Needed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reservation ID:";
            // 
            // serviceType_txt
            // 
            this.serviceType_txt.Location = new System.Drawing.Point(139, 83);
            this.serviceType_txt.Name = "serviceType_txt";
            this.serviceType_txt.ReadOnly = true;
            this.serviceType_txt.Size = new System.Drawing.Size(300, 23);
            this.serviceType_txt.TabIndex = 2;
            // 
            // reservationId_txt
            // 
            this.reservationId_txt.Location = new System.Drawing.Point(139, 54);
            this.reservationId_txt.Name = "reservationId_txt";
            this.reservationId_txt.ReadOnly = true;
            this.reservationId_txt.Size = new System.Drawing.Size(300, 23);
            this.reservationId_txt.TabIndex = 0;
            this.reservationId_txt.TextChanged += new System.EventHandler(this.getReservationVehicleCustomer_Textchanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Controls.Add(this.label10);
            this.guna2GroupBox2.Controls.Add(this.vehiclePlateNumber_txt);
            this.guna2GroupBox2.Controls.Add(this.label9);
            this.guna2GroupBox2.Controls.Add(this.vehicleType_txt);
            this.guna2GroupBox2.Controls.Add(this.vehicleYear_txt);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.label7);
            this.guna2GroupBox2.Controls.Add(this.label8);
            this.guna2GroupBox2.Controls.Add(this.vehicleModel_txt);
            this.guna2GroupBox2.Controls.Add(this.vehicleMake_txt);
            this.guna2GroupBox2.Controls.Add(this.vehicleId_txt);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(472, 22);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(388, 283);
            this.guna2GroupBox2.TabIndex = 45;
            this.guna2GroupBox2.Text = "Vehicle Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Plate Number:";
            // 
            // vehiclePlateNumber_txt
            // 
            this.vehiclePlateNumber_txt.Location = new System.Drawing.Point(94, 200);
            this.vehiclePlateNumber_txt.Name = "vehiclePlateNumber_txt";
            this.vehiclePlateNumber_txt.ReadOnly = true;
            this.vehiclePlateNumber_txt.Size = new System.Drawing.Size(282, 23);
            this.vehiclePlateNumber_txt.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Vehicle Type:";
            // 
            // vehicleType_txt
            // 
            this.vehicleType_txt.Location = new System.Drawing.Point(94, 171);
            this.vehicleType_txt.Name = "vehicleType_txt";
            this.vehicleType_txt.ReadOnly = true;
            this.vehicleType_txt.Size = new System.Drawing.Size(282, 23);
            this.vehicleType_txt.TabIndex = 17;
            // 
            // vehicleYear_txt
            // 
            this.vehicleYear_txt.Location = new System.Drawing.Point(94, 142);
            this.vehicleYear_txt.Name = "vehicleYear_txt";
            this.vehicleYear_txt.ReadOnly = true;
            this.vehicleYear_txt.Size = new System.Drawing.Size(282, 23);
            this.vehicleYear_txt.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Make:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Vehicle ID:";
            // 
            // vehicleModel_txt
            // 
            this.vehicleModel_txt.Location = new System.Drawing.Point(94, 113);
            this.vehicleModel_txt.Name = "vehicleModel_txt";
            this.vehicleModel_txt.ReadOnly = true;
            this.vehicleModel_txt.Size = new System.Drawing.Size(282, 23);
            this.vehicleModel_txt.TabIndex = 10;
            // 
            // vehicleMake_txt
            // 
            this.vehicleMake_txt.Location = new System.Drawing.Point(94, 84);
            this.vehicleMake_txt.Name = "vehicleMake_txt";
            this.vehicleMake_txt.ReadOnly = true;
            this.vehicleMake_txt.Size = new System.Drawing.Size(282, 23);
            this.vehicleMake_txt.TabIndex = 9;
            // 
            // vehicleId_txt
            // 
            this.vehicleId_txt.Location = new System.Drawing.Point(94, 55);
            this.vehicleId_txt.Name = "vehicleId_txt";
            this.vehicleId_txt.ReadOnly = true;
            this.vehicleId_txt.Size = new System.Drawing.Size(282, 23);
            this.vehicleId_txt.TabIndex = 8;
            // 
            // ApprovedReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showAll_btn);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.searchByCustomerName_txt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.filterByMechanic_cmbx);
            this.Controls.Add(this.filterByServiceType_cmbx);
            this.Controls.Add(this.approvedReservationsDataGrid);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Name = "ApprovedReservationsForm";
            this.Size = new System.Drawing.Size(1717, 909);
            this.Load += new System.EventHandler(this.ApprovedReservationsForm_Load);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approvedReservationsDataGrid)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button showAll_btn;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox customerId_txt;
        private System.Windows.Forms.TextBox customerEmail_txt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox customerAddress_txt;
        private System.Windows.Forms.TextBox customerContact_txt;
        private System.Windows.Forms.TextBox customerName_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox searchByCustomerName_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox filterByMechanic_cmbx;
        private System.Windows.Forms.ComboBox filterByServiceType_cmbx;
        private System.Windows.Forms.DataGridView approvedReservationsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationId_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleId_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn DoneColumn;
        private System.Windows.Forms.DataGridViewButtonColumn CancelColumn;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox mechanicAssigned_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox problemDescription_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serviceType_txt;
        private System.Windows.Forms.TextBox reservationId_txt;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox vehiclePlateNumber_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vehicleType_txt;
        private System.Windows.Forms.TextBox vehicleYear_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vehicleModel_txt;
        private System.Windows.Forms.TextBox vehicleMake_txt;
        private System.Windows.Forms.TextBox vehicleId_txt;
    }
}
