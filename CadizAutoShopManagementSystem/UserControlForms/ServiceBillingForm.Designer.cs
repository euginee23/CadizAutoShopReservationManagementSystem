
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class ServiceBillingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invoice_btn = new Guna.UI2.WinForms.Guna2Button();
            this.serviceType_cmbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.totalCost_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceType_txt = new System.Windows.Forms.TextBox();
            this.extraExpenseReason_txt = new System.Windows.Forms.TextBox();
            this.extraExpenseCost_txt = new System.Windows.Forms.TextBox();
            this.serviceId_txt = new System.Windows.Forms.TextBox();
            this.customerName_txt = new System.Windows.Forms.TextBox();
            this.billingId_txt = new System.Windows.Forms.TextBox();
            this.serviceBillingDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.billing_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraExpense_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraExpense_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBillingDataGridView)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoice_btn
            // 
            this.invoice_btn.BorderRadius = 3;
            this.invoice_btn.BorderThickness = 1;
            this.invoice_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.invoice_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.invoice_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.invoice_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.invoice_btn.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.invoice_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice_btn.ForeColor = System.Drawing.Color.White;
            this.invoice_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.invoice_btn.Location = new System.Drawing.Point(160, 194);
            this.invoice_btn.Name = "invoice_btn";
            this.invoice_btn.Size = new System.Drawing.Size(204, 45);
            this.invoice_btn.TabIndex = 80;
            this.invoice_btn.Text = "INVOICE";
            this.invoice_btn.Click += new System.EventHandler(this.invoice_btn_Click);
            // 
            // serviceType_cmbx
            // 
            this.serviceType_cmbx.BackColor = System.Drawing.Color.Transparent;
            this.serviceType_cmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.serviceType_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceType_cmbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.serviceType_cmbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.serviceType_cmbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.serviceType_cmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.serviceType_cmbx.ItemHeight = 30;
            this.serviceType_cmbx.Location = new System.Drawing.Point(730, 7);
            this.serviceType_cmbx.Name = "serviceType_cmbx";
            this.serviceType_cmbx.Size = new System.Drawing.Size(213, 36);
            this.serviceType_cmbx.TabIndex = 78;
            this.serviceType_cmbx.SelectedIndexChanged += new System.EventHandler(this.serviceFilterIndexChanged);
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(89, 13);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(416, 25);
            this.search_txt.TabIndex = 76;
            this.search_txt.TextChanged += new System.EventHandler(this.searchTextChanged);
            // 
            // totalCost_txt
            // 
            this.totalCost_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalCost_txt.DefaultText = "";
            this.totalCost_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalCost_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalCost_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalCost_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalCost_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalCost_txt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalCost_txt.Location = new System.Drawing.Point(20, 49);
            this.totalCost_txt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.totalCost_txt.Name = "totalCost_txt";
            this.totalCost_txt.PasswordChar = '\0';
            this.totalCost_txt.PlaceholderText = "";
            this.totalCost_txt.ReadOnly = true;
            this.totalCost_txt.SelectedText = "";
            this.totalCost_txt.Size = new System.Drawing.Size(234, 97);
            this.totalCost_txt.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = "SERVICE ID:";
            // 
            // serviceType_txt
            // 
            this.serviceType_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceType_txt.Location = new System.Drawing.Point(25, 289);
            this.serviceType_txt.Name = "serviceType_txt";
            this.serviceType_txt.ReadOnly = true;
            this.serviceType_txt.Size = new System.Drawing.Size(476, 29);
            this.serviceType_txt.TabIndex = 66;
            // 
            // extraExpenseReason_txt
            // 
            this.extraExpenseReason_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraExpenseReason_txt.Location = new System.Drawing.Point(24, 356);
            this.extraExpenseReason_txt.Multiline = true;
            this.extraExpenseReason_txt.Name = "extraExpenseReason_txt";
            this.extraExpenseReason_txt.ReadOnly = true;
            this.extraExpenseReason_txt.Size = new System.Drawing.Size(477, 143);
            this.extraExpenseReason_txt.TabIndex = 65;
            // 
            // extraExpenseCost_txt
            // 
            this.extraExpenseCost_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraExpenseCost_txt.Location = new System.Drawing.Point(25, 541);
            this.extraExpenseCost_txt.Name = "extraExpenseCost_txt";
            this.extraExpenseCost_txt.ReadOnly = true;
            this.extraExpenseCost_txt.Size = new System.Drawing.Size(477, 29);
            this.extraExpenseCost_txt.TabIndex = 64;
            // 
            // serviceId_txt
            // 
            this.serviceId_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceId_txt.Location = new System.Drawing.Point(24, 158);
            this.serviceId_txt.Name = "serviceId_txt";
            this.serviceId_txt.ReadOnly = true;
            this.serviceId_txt.Size = new System.Drawing.Size(477, 29);
            this.serviceId_txt.TabIndex = 63;
            // 
            // customerName_txt
            // 
            this.customerName_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName_txt.Location = new System.Drawing.Point(25, 226);
            this.customerName_txt.Name = "customerName_txt";
            this.customerName_txt.ReadOnly = true;
            this.customerName_txt.Size = new System.Drawing.Size(477, 29);
            this.customerName_txt.TabIndex = 62;
            // 
            // billingId_txt
            // 
            this.billingId_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingId_txt.Location = new System.Drawing.Point(24, 93);
            this.billingId_txt.Name = "billingId_txt";
            this.billingId_txt.ReadOnly = true;
            this.billingId_txt.Size = new System.Drawing.Size(477, 29);
            this.billingId_txt.TabIndex = 67;
            // 
            // serviceBillingDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.serviceBillingDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceBillingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.serviceBillingDataGridView.ColumnHeadersHeight = 15;
            this.serviceBillingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.serviceBillingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billing_id,
            this.reservation_id,
            this.customer_name,
            this.serviceType,
            this.extraExpense_reason,
            this.extraExpense_cost,
            this.total_cost});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceBillingDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.serviceBillingDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.serviceBillingDataGridView.Location = new System.Drawing.Point(17, 60);
            this.serviceBillingDataGridView.Name = "serviceBillingDataGridView";
            this.serviceBillingDataGridView.RowHeadersVisible = false;
            this.serviceBillingDataGridView.Size = new System.Drawing.Size(917, 731);
            this.serviceBillingDataGridView.TabIndex = 61;
            this.serviceBillingDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.serviceBillingDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.serviceBillingDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.serviceBillingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.serviceBillingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.serviceBillingDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.serviceBillingDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.serviceBillingDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.serviceBillingDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.serviceBillingDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceBillingDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.serviceBillingDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.serviceBillingDataGridView.ThemeStyle.HeaderStyle.Height = 15;
            this.serviceBillingDataGridView.ThemeStyle.ReadOnly = false;
            this.serviceBillingDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.serviceBillingDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.serviceBillingDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceBillingDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.serviceBillingDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.serviceBillingDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.serviceBillingDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.serviceBillingDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getBillingInformation_CellClick);
            // 
            // billing_id
            // 
            this.billing_id.DataPropertyName = "billing_id";
            this.billing_id.FillWeight = 41.81653F;
            this.billing_id.HeaderText = "ID";
            this.billing_id.Name = "billing_id";
            // 
            // reservation_id
            // 
            this.reservation_id.DataPropertyName = "localService_id";
            this.reservation_id.FillWeight = 101.4748F;
            this.reservation_id.HeaderText = "SERVICE ID";
            this.reservation_id.Name = "reservation_id";
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.FillWeight = 101.4748F;
            this.customer_name.HeaderText = "CUSTOMER NAME";
            this.customer_name.Name = "customer_name";
            // 
            // serviceType
            // 
            this.serviceType.DataPropertyName = "serviceType";
            this.serviceType.HeaderText = "SERVICE DONE";
            this.serviceType.Name = "serviceType";
            // 
            // extraExpense_reason
            // 
            this.extraExpense_reason.DataPropertyName = "extraExpense_reason";
            this.extraExpense_reason.FillWeight = 152.2843F;
            this.extraExpense_reason.HeaderText = "EXTRA COST REASON";
            this.extraExpense_reason.Name = "extraExpense_reason";
            // 
            // extraExpense_cost
            // 
            this.extraExpense_cost.DataPropertyName = "extraExpense_cost";
            this.extraExpense_cost.FillWeight = 101.4748F;
            this.extraExpense_cost.HeaderText = "EXTRA COST";
            this.extraExpense_cost.Name = "extraExpense_cost";
            // 
            // total_cost
            // 
            this.total_cost.DataPropertyName = "total_cost";
            this.total_cost.FillWeight = 101.4748F;
            this.total_cost.HeaderText = "TOTAL COST";
            this.total_cost.Name = "total_cost";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.Controls.Add(this.label14);
            this.guna2GroupBox1.Controls.Add(this.label15);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.billingId_txt);
            this.guna2GroupBox1.Controls.Add(this.serviceId_txt);
            this.guna2GroupBox1.Controls.Add(this.customerName_txt);
            this.guna2GroupBox1.Controls.Add(this.serviceType_txt);
            this.guna2GroupBox1.Controls.Add(this.extraExpenseReason_txt);
            this.guna2GroupBox1.Controls.Add(this.extraExpenseCost_txt);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(15, 295);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(521, 599);
            this.guna2GroupBox1.TabIndex = 81;
            this.guna2GroupBox1.Text = "BILLING INFORMATION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 48;
            this.label10.Text = "BILLING ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 517);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 21);
            this.label12.TabIndex = 52;
            this.label12.Text = "EXTRA COST:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 21);
            this.label13.TabIndex = 50;
            this.label13.Text = "CUSTOMER NAME:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 21);
            this.label14.TabIndex = 54;
            this.label14.Text = "EXTRA COST REASON:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 21);
            this.label15.TabIndex = 51;
            this.label15.Text = "SERVICE DONE:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.invoice_btn);
            this.panel1.Location = new System.Drawing.Point(15, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 257);
            this.panel1.TabIndex = 82;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.totalCost_txt);
            this.panel4.Location = new System.Drawing.Point(127, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 166);
            this.panel4.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 53;
            this.label1.Text = "TOTAL COST:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.serviceType_cmbx);
            this.panel3.Controls.Add(this.search_txt);
            this.panel3.Location = new System.Drawing.Point(553, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 51);
            this.panel3.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 57;
            this.label3.Text = "SEARCH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(528, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "FILTER BY SERVICE DONE:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.serviceBillingDataGridView);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(554, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 806);
            this.panel2.TabIndex = 84;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(17, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(917, 35);
            this.panel5.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 62;
            this.label5.Text = "DONE SERVICES";
            // 
            // ServiceBillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "ServiceBillingForm";
            this.Size = new System.Drawing.Size(1526, 909);
            ((System.ComponentModel.ISupportInitialize)(this.serviceBillingDataGridView)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button invoice_btn;
        private Guna.UI2.WinForms.Guna2ComboBox serviceType_cmbx;
        private System.Windows.Forms.TextBox search_txt;
        private Guna.UI2.WinForms.Guna2TextBox totalCost_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serviceType_txt;
        private System.Windows.Forms.TextBox extraExpenseReason_txt;
        private System.Windows.Forms.TextBox extraExpenseCost_txt;
        private System.Windows.Forms.TextBox serviceId_txt;
        private System.Windows.Forms.TextBox customerName_txt;
        private System.Windows.Forms.TextBox billingId_txt;
        private Guna.UI2.WinForms.Guna2DataGridView serviceBillingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn billing_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraExpense_reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraExpense_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_cost;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
    }
}
