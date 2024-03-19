
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class PersonnelAccessSettingsForm
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
            this.personnelInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInfo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxContainer = new System.Windows.Forms.Panel();
            this.manageInventory_chckbx = new Guna.UI2.WinForms.Guna2CheckBox();
            this.manageServices_chckbx = new Guna.UI2.WinForms.Guna2CheckBox();
            this.dashboard_chckbx = new Guna.UI2.WinForms.Guna2CheckBox();
            this.localService_chckbx = new Guna.UI2.WinForms.Guna2CheckBox();
            this.reservations_chckbx = new Guna.UI2.WinForms.Guna2CheckBox();
            this.sellParts_chckbx = new Guna.UI2.WinForms.Guna2CheckBox();
            this.billing_chckbx = new Guna.UI2.WinForms.Guna2CheckBox();
            this.localReservation_chckbx = new Guna.UI2.WinForms.Guna2CheckBox();
            this.manageMechanics_chckbx = new Guna.UI2.WinForms.Guna2CheckBox();
            this.reports_chckbx = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deselect_btn = new Guna.UI2.WinForms.Guna2Button();
            this.setAccess_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userId_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.personnelInfoDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.checkBoxContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // personnelInfoDataGrid
            // 
            this.personnelInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personnelInfoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.userInfo_id,
            this.firstName,
            this.lastName,
            this.Column4,
            this.Column5});
            this.personnelInfoDataGrid.Location = new System.Drawing.Point(17, 50);
            this.personnelInfoDataGrid.Name = "personnelInfoDataGrid";
            this.personnelInfoDataGrid.ReadOnly = true;
            this.personnelInfoDataGrid.RowHeadersVisible = false;
            this.personnelInfoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personnelInfoDataGrid.Size = new System.Drawing.Size(885, 805);
            this.personnelInfoDataGrid.TabIndex = 66;
            this.personnelInfoDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personnelInfoDataGrid_CellClick);
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "LOG-IN ID";
            this.user_id.Name = "user_id";
            // 
            // userInfo_id
            // 
            this.userInfo_id.DataPropertyName = "userInfo_id";
            this.userInfo_id.HeaderText = "USER ID";
            this.userInfo_id.Name = "userInfo_id";
            this.userInfo_id.Width = 80;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "firstName";
            this.firstName.HeaderText = "FIRST NAME";
            this.firstName.Name = "firstName";
            this.firstName.Width = 150;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "lastName";
            this.lastName.HeaderText = "LAST NAME";
            this.lastName.Name = "lastName";
            this.lastName.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "contactNumber";
            this.Column4.HeaderText = "CONTACT #";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "address";
            this.Column5.HeaderText = "ADDRESS";
            this.Column5.Name = "Column5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxContainer);
            this.panel1.Location = new System.Drawing.Point(1035, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 692);
            this.panel1.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 37);
            this.label1.TabIndex = 77;
            this.label1.Text = "SELECT PERSONNEL ACCESS";
            // 
            // checkBoxContainer
            // 
            this.checkBoxContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxContainer.Controls.Add(this.manageInventory_chckbx);
            this.checkBoxContainer.Controls.Add(this.manageServices_chckbx);
            this.checkBoxContainer.Controls.Add(this.dashboard_chckbx);
            this.checkBoxContainer.Controls.Add(this.localService_chckbx);
            this.checkBoxContainer.Controls.Add(this.reservations_chckbx);
            this.checkBoxContainer.Controls.Add(this.sellParts_chckbx);
            this.checkBoxContainer.Controls.Add(this.billing_chckbx);
            this.checkBoxContainer.Controls.Add(this.localReservation_chckbx);
            this.checkBoxContainer.Controls.Add(this.manageMechanics_chckbx);
            this.checkBoxContainer.Controls.Add(this.reports_chckbx);
            this.checkBoxContainer.Location = new System.Drawing.Point(21, 40);
            this.checkBoxContainer.Name = "checkBoxContainer";
            this.checkBoxContainer.Size = new System.Drawing.Size(369, 633);
            this.checkBoxContainer.TabIndex = 78;
            // 
            // manageInventory_chckbx
            // 
            this.manageInventory_chckbx.AutoSize = true;
            this.manageInventory_chckbx.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.manageInventory_chckbx.CheckedState.BorderRadius = 0;
            this.manageInventory_chckbx.CheckedState.BorderThickness = 0;
            this.manageInventory_chckbx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.manageInventory_chckbx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.manageInventory_chckbx.Location = new System.Drawing.Point(65, 261);
            this.manageInventory_chckbx.Name = "manageInventory_chckbx";
            this.manageInventory_chckbx.Size = new System.Drawing.Size(253, 28);
            this.manageInventory_chckbx.TabIndex = 89;
            this.manageInventory_chckbx.Text = "MANAGE INVENTORY";
            this.manageInventory_chckbx.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.manageInventory_chckbx.UncheckedState.BorderRadius = 0;
            this.manageInventory_chckbx.UncheckedState.BorderThickness = 0;
            this.manageInventory_chckbx.UncheckedState.FillColor = System.Drawing.Color.DimGray;
            // 
            // manageServices_chckbx
            // 
            this.manageServices_chckbx.AutoSize = true;
            this.manageServices_chckbx.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.manageServices_chckbx.CheckedState.BorderRadius = 0;
            this.manageServices_chckbx.CheckedState.BorderThickness = 0;
            this.manageServices_chckbx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.manageServices_chckbx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.manageServices_chckbx.Location = new System.Drawing.Point(65, 204);
            this.manageServices_chckbx.Name = "manageServices_chckbx";
            this.manageServices_chckbx.Size = new System.Drawing.Size(236, 28);
            this.manageServices_chckbx.TabIndex = 88;
            this.manageServices_chckbx.Text = "MANAGE SERVICES";
            this.manageServices_chckbx.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.manageServices_chckbx.UncheckedState.BorderRadius = 0;
            this.manageServices_chckbx.UncheckedState.BorderThickness = 0;
            this.manageServices_chckbx.UncheckedState.FillColor = System.Drawing.Color.DimGray;
            // 
            // dashboard_chckbx
            // 
            this.dashboard_chckbx.AutoSize = true;
            this.dashboard_chckbx.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dashboard_chckbx.CheckedState.BorderRadius = 0;
            this.dashboard_chckbx.CheckedState.BorderThickness = 0;
            this.dashboard_chckbx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dashboard_chckbx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.dashboard_chckbx.Location = new System.Drawing.Point(65, 46);
            this.dashboard_chckbx.Name = "dashboard_chckbx";
            this.dashboard_chckbx.Size = new System.Drawing.Size(168, 28);
            this.dashboard_chckbx.TabIndex = 78;
            this.dashboard_chckbx.Text = "DASHBOARD";
            this.dashboard_chckbx.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.dashboard_chckbx.UncheckedState.BorderRadius = 0;
            this.dashboard_chckbx.UncheckedState.BorderThickness = 0;
            this.dashboard_chckbx.UncheckedState.FillColor = System.Drawing.Color.DimGray;
            // 
            // localService_chckbx
            // 
            this.localService_chckbx.AutoSize = true;
            this.localService_chckbx.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.localService_chckbx.CheckedState.BorderRadius = 0;
            this.localService_chckbx.CheckedState.BorderThickness = 0;
            this.localService_chckbx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.localService_chckbx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.localService_chckbx.Location = new System.Drawing.Point(65, 377);
            this.localService_chckbx.Name = "localService_chckbx";
            this.localService_chckbx.Size = new System.Drawing.Size(207, 28);
            this.localService_chckbx.TabIndex = 83;
            this.localService_chckbx.Text = "LOCAL SERVICE ";
            this.localService_chckbx.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.localService_chckbx.UncheckedState.BorderRadius = 0;
            this.localService_chckbx.UncheckedState.BorderThickness = 0;
            this.localService_chckbx.UncheckedState.FillColor = System.Drawing.Color.DimGray;
            // 
            // reservations_chckbx
            // 
            this.reservations_chckbx.AutoSize = true;
            this.reservations_chckbx.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reservations_chckbx.CheckedState.BorderRadius = 0;
            this.reservations_chckbx.CheckedState.BorderThickness = 0;
            this.reservations_chckbx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reservations_chckbx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.reservations_chckbx.Location = new System.Drawing.Point(65, 94);
            this.reservations_chckbx.Name = "reservations_chckbx";
            this.reservations_chckbx.Size = new System.Drawing.Size(197, 28);
            this.reservations_chckbx.TabIndex = 79;
            this.reservations_chckbx.Text = "RESERVATIONS";
            this.reservations_chckbx.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.reservations_chckbx.UncheckedState.BorderRadius = 0;
            this.reservations_chckbx.UncheckedState.BorderThickness = 0;
            this.reservations_chckbx.UncheckedState.FillColor = System.Drawing.Color.DimGray;
            // 
            // sellParts_chckbx
            // 
            this.sellParts_chckbx.AutoSize = true;
            this.sellParts_chckbx.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sellParts_chckbx.CheckedState.BorderRadius = 0;
            this.sellParts_chckbx.CheckedState.BorderThickness = 0;
            this.sellParts_chckbx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sellParts_chckbx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.sellParts_chckbx.Location = new System.Drawing.Point(65, 316);
            this.sellParts_chckbx.Name = "sellParts_chckbx";
            this.sellParts_chckbx.Size = new System.Drawing.Size(164, 28);
            this.sellParts_chckbx.TabIndex = 82;
            this.sellParts_chckbx.Text = "SELL PARTS ";
            this.sellParts_chckbx.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.sellParts_chckbx.UncheckedState.BorderRadius = 0;
            this.sellParts_chckbx.UncheckedState.BorderThickness = 0;
            this.sellParts_chckbx.UncheckedState.FillColor = System.Drawing.Color.DimGray;
            // 
            // billing_chckbx
            // 
            this.billing_chckbx.AutoSize = true;
            this.billing_chckbx.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billing_chckbx.CheckedState.BorderRadius = 0;
            this.billing_chckbx.CheckedState.BorderThickness = 0;
            this.billing_chckbx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billing_chckbx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.billing_chckbx.Location = new System.Drawing.Point(65, 548);
            this.billing_chckbx.Name = "billing_chckbx";
            this.billing_chckbx.Size = new System.Drawing.Size(117, 28);
            this.billing_chckbx.TabIndex = 86;
            this.billing_chckbx.Text = "BILLING";
            this.billing_chckbx.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.billing_chckbx.UncheckedState.BorderRadius = 0;
            this.billing_chckbx.UncheckedState.BorderThickness = 0;
            this.billing_chckbx.UncheckedState.FillColor = System.Drawing.Color.DimGray;
            // 
            // localReservation_chckbx
            // 
            this.localReservation_chckbx.AutoSize = true;
            this.localReservation_chckbx.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.localReservation_chckbx.CheckedState.BorderRadius = 0;
            this.localReservation_chckbx.CheckedState.BorderThickness = 0;
            this.localReservation_chckbx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.localReservation_chckbx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.localReservation_chckbx.Location = new System.Drawing.Point(65, 433);
            this.localReservation_chckbx.Name = "localReservation_chckbx";
            this.localReservation_chckbx.Size = new System.Drawing.Size(262, 28);
            this.localReservation_chckbx.TabIndex = 84;
            this.localReservation_chckbx.Text = "LOCAL RESERVATION";
            this.localReservation_chckbx.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.localReservation_chckbx.UncheckedState.BorderRadius = 0;
            this.localReservation_chckbx.UncheckedState.BorderThickness = 0;
            this.localReservation_chckbx.UncheckedState.FillColor = System.Drawing.Color.DimGray;
            // 
            // manageMechanics_chckbx
            // 
            this.manageMechanics_chckbx.AutoSize = true;
            this.manageMechanics_chckbx.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.manageMechanics_chckbx.CheckedState.BorderRadius = 0;
            this.manageMechanics_chckbx.CheckedState.BorderThickness = 0;
            this.manageMechanics_chckbx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.manageMechanics_chckbx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.manageMechanics_chckbx.Location = new System.Drawing.Point(65, 148);
            this.manageMechanics_chckbx.Name = "manageMechanics_chckbx";
            this.manageMechanics_chckbx.Size = new System.Drawing.Size(264, 28);
            this.manageMechanics_chckbx.TabIndex = 80;
            this.manageMechanics_chckbx.Text = "MANAGE MECHANICS ";
            this.manageMechanics_chckbx.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.manageMechanics_chckbx.UncheckedState.BorderRadius = 0;
            this.manageMechanics_chckbx.UncheckedState.BorderThickness = 0;
            this.manageMechanics_chckbx.UncheckedState.FillColor = System.Drawing.Color.DimGray;
            // 
            // reports_chckbx
            // 
            this.reports_chckbx.AutoSize = true;
            this.reports_chckbx.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reports_chckbx.CheckedState.BorderRadius = 0;
            this.reports_chckbx.CheckedState.BorderThickness = 0;
            this.reports_chckbx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reports_chckbx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.reports_chckbx.Location = new System.Drawing.Point(65, 491);
            this.reports_chckbx.Name = "reports_chckbx";
            this.reports_chckbx.Size = new System.Drawing.Size(131, 28);
            this.reports_chckbx.TabIndex = 85;
            this.reports_chckbx.Text = "REPORTS";
            this.reports_chckbx.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.reports_chckbx.UncheckedState.BorderRadius = 0;
            this.reports_chckbx.UncheckedState.BorderThickness = 0;
            this.reports_chckbx.UncheckedState.FillColor = System.Drawing.Color.DimGray;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.deselect_btn);
            this.panel3.Controls.Add(this.setAccess_btn);
            this.panel3.Location = new System.Drawing.Point(961, 840);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 52);
            this.panel3.TabIndex = 78;
            // 
            // deselect_btn
            // 
            this.deselect_btn.BorderRadius = 3;
            this.deselect_btn.BorderThickness = 1;
            this.deselect_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deselect_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deselect_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deselect_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deselect_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deselect_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deselect_btn.ForeColor = System.Drawing.Color.White;
            this.deselect_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.deselect_btn.Location = new System.Drawing.Point(26, 8);
            this.deselect_btn.Name = "deselect_btn";
            this.deselect_btn.Size = new System.Drawing.Size(227, 36);
            this.deselect_btn.TabIndex = 67;
            this.deselect_btn.Text = "DESELECT ALL";
            this.deselect_btn.Click += new System.EventHandler(this.deselect_btn_Click);
            // 
            // setAccess_btn
            // 
            this.setAccess_btn.BorderRadius = 3;
            this.setAccess_btn.BorderThickness = 1;
            this.setAccess_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.setAccess_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.setAccess_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.setAccess_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.setAccess_btn.FillColor = System.Drawing.Color.Green;
            this.setAccess_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAccess_btn.ForeColor = System.Drawing.Color.White;
            this.setAccess_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.setAccess_btn.Location = new System.Drawing.Point(293, 8);
            this.setAccess_btn.Name = "setAccess_btn";
            this.setAccess_btn.Size = new System.Drawing.Size(227, 36);
            this.setAccess_btn.TabIndex = 57;
            this.setAccess_btn.Text = "SET ACCESS";
            this.setAccess_btn.Click += new System.EventHandler(this.setAccess_btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.personnelInfoDataGrid);
            this.panel4.Location = new System.Drawing.Point(16, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(920, 874);
            this.panel4.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 37);
            this.label2.TabIndex = 77;
            this.label2.Text = "SELECT PERSONNEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(50, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 30);
            this.label3.TabIndex = 80;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 81;
            this.label4.Text = "NAME:";
            // 
            // userId_lbl
            // 
            this.userId_lbl.AutoSize = true;
            this.userId_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userId_lbl.Location = new System.Drawing.Point(89, 7);
            this.userId_lbl.Name = "userId_lbl";
            this.userId_lbl.Size = new System.Drawing.Size(22, 30);
            this.userId_lbl.TabIndex = 82;
            this.userId_lbl.Text = "?";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_lbl.Location = new System.Drawing.Point(89, 51);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(22, 30);
            this.name_lbl.TabIndex = 83;
            this.name_lbl.Text = "?";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.name_lbl);
            this.panel5.Controls.Add(this.userId_lbl);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(961, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(545, 93);
            this.panel5.TabIndex = 84;
            // 
            // PersonnelAccessSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Name = "PersonnelAccessSettingsForm";
            this.Size = new System.Drawing.Size(1526, 909);
            ((System.ComponentModel.ISupportInitialize)(this.personnelInfoDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.checkBoxContainer.ResumeLayout(false);
            this.checkBoxContainer.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView personnelInfoDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel checkBoxContainer;
        private Guna.UI2.WinForms.Guna2CheckBox dashboard_chckbx;
        private Guna.UI2.WinForms.Guna2CheckBox localService_chckbx;
        private Guna.UI2.WinForms.Guna2CheckBox reservations_chckbx;
        private Guna.UI2.WinForms.Guna2CheckBox sellParts_chckbx;
        private Guna.UI2.WinForms.Guna2CheckBox billing_chckbx;
        private Guna.UI2.WinForms.Guna2CheckBox localReservation_chckbx;
        private Guna.UI2.WinForms.Guna2CheckBox manageMechanics_chckbx;
        private Guna.UI2.WinForms.Guna2CheckBox reports_chckbx;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button deselect_btn;
        private Guna.UI2.WinForms.Guna2Button setAccess_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userId_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userInfo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2CheckBox manageServices_chckbx;
        private Guna.UI2.WinForms.Guna2CheckBox manageInventory_chckbx;
    }
}
