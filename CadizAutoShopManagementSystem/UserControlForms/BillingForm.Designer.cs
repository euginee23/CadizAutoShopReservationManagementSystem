namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class BillingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.billingPanelContainer = new System.Windows.Forms.Panel();
            this.invoice_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.totalCost_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceType_txt = new System.Windows.Forms.TextBox();
            this.extraExpenseReason_txt = new System.Windows.Forms.TextBox();
            this.extraExpenseCost_txt = new System.Windows.Forms.TextBox();
            this.reservationId_txt = new System.Windows.Forms.TextBox();
            this.customerName_txt = new System.Windows.Forms.TextBox();
            this.billingId_txt = new System.Windows.Forms.TextBox();
            this.reservationBillingDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.billing_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraExpense_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraExpense_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsBilling_btn = new Guna.UI2.WinForms.Guna2Button();
            this.billingPanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBillingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // billingPanelContainer
            // 
            this.billingPanelContainer.Controls.Add(this.invoice_btn);
            this.billingPanelContainer.Controls.Add(this.label9);
            this.billingPanelContainer.Controls.Add(this.guna2ComboBox1);
            this.billingPanelContainer.Controls.Add(this.label8);
            this.billingPanelContainer.Controls.Add(this.textBox7);
            this.billingPanelContainer.Controls.Add(this.totalCost_txt);
            this.billingPanelContainer.Controls.Add(this.label7);
            this.billingPanelContainer.Controls.Add(this.label6);
            this.billingPanelContainer.Controls.Add(this.label5);
            this.billingPanelContainer.Controls.Add(this.label4);
            this.billingPanelContainer.Controls.Add(this.label3);
            this.billingPanelContainer.Controls.Add(this.label2);
            this.billingPanelContainer.Controls.Add(this.label1);
            this.billingPanelContainer.Controls.Add(this.serviceType_txt);
            this.billingPanelContainer.Controls.Add(this.extraExpenseReason_txt);
            this.billingPanelContainer.Controls.Add(this.extraExpenseCost_txt);
            this.billingPanelContainer.Controls.Add(this.reservationId_txt);
            this.billingPanelContainer.Controls.Add(this.customerName_txt);
            this.billingPanelContainer.Controls.Add(this.billingId_txt);
            this.billingPanelContainer.Controls.Add(this.reservationBillingDataGridView);
            this.billingPanelContainer.Controls.Add(this.partsBilling_btn);
            this.billingPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.billingPanelContainer.Name = "billingPanelContainer";
            this.billingPanelContainer.Size = new System.Drawing.Size(1251, 744);
            this.billingPanelContainer.TabIndex = 3;
            // 
            // invoice_btn
            // 
            this.invoice_btn.BorderRadius = 12;
            this.invoice_btn.BorderThickness = 1;
            this.invoice_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.invoice_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.invoice_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.invoice_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.invoice_btn.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.invoice_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice_btn.ForeColor = System.Drawing.Color.White;
            this.invoice_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.invoice_btn.Location = new System.Drawing.Point(891, 182);
            this.invoice_btn.Name = "invoice_btn";
            this.invoice_btn.Size = new System.Drawing.Size(227, 45);
            this.invoice_btn.TabIndex = 40;
            this.invoice_btn.Text = "INVOICE";
            this.invoice_btn.Click += new System.EventHandler(this.invoice_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(833, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "FILTER BY SERVICE DONE:";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(996, 253);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(239, 36);
            this.guna2ComboBox1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "SEARCH:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(75, 264);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(493, 25);
            this.textBox7.TabIndex = 35;
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
            this.totalCost_txt.Location = new System.Drawing.Point(877, 75);
            this.totalCost_txt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.totalCost_txt.Name = "totalCost_txt";
            this.totalCost_txt.PasswordChar = '\0';
            this.totalCost_txt.PlaceholderText = "";
            this.totalCost_txt.ReadOnly = true;
            this.totalCost_txt.SelectedText = "";
            this.totalCost_txt.Size = new System.Drawing.Size(257, 97);
            this.totalCost_txt.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(782, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "TOTAL COST:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "EXTRA COST:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "EXTRA COST REASON:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "SERVICE DONE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "CUSTOMER NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "RESERVATION ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "BILLING ID:";
            // 
            // serviceType_txt
            // 
            this.serviceType_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceType_txt.Location = new System.Drawing.Point(156, 106);
            this.serviceType_txt.Name = "serviceType_txt";
            this.serviceType_txt.ReadOnly = true;
            this.serviceType_txt.Size = new System.Drawing.Size(493, 25);
            this.serviceType_txt.TabIndex = 6;
            // 
            // extraExpenseReason_txt
            // 
            this.extraExpenseReason_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraExpenseReason_txt.Location = new System.Drawing.Point(156, 137);
            this.extraExpenseReason_txt.Multiline = true;
            this.extraExpenseReason_txt.Name = "extraExpenseReason_txt";
            this.extraExpenseReason_txt.ReadOnly = true;
            this.extraExpenseReason_txt.Size = new System.Drawing.Size(493, 76);
            this.extraExpenseReason_txt.TabIndex = 6;
            // 
            // extraExpenseCost_txt
            // 
            this.extraExpenseCost_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraExpenseCost_txt.Location = new System.Drawing.Point(156, 219);
            this.extraExpenseCost_txt.Name = "extraExpenseCost_txt";
            this.extraExpenseCost_txt.ReadOnly = true;
            this.extraExpenseCost_txt.Size = new System.Drawing.Size(493, 25);
            this.extraExpenseCost_txt.TabIndex = 6;
            // 
            // reservationId_txt
            // 
            this.reservationId_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationId_txt.Location = new System.Drawing.Point(156, 44);
            this.reservationId_txt.Name = "reservationId_txt";
            this.reservationId_txt.ReadOnly = true;
            this.reservationId_txt.Size = new System.Drawing.Size(493, 25);
            this.reservationId_txt.TabIndex = 6;
            // 
            // customerName_txt
            // 
            this.customerName_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName_txt.Location = new System.Drawing.Point(156, 75);
            this.customerName_txt.Name = "customerName_txt";
            this.customerName_txt.ReadOnly = true;
            this.customerName_txt.Size = new System.Drawing.Size(493, 25);
            this.customerName_txt.TabIndex = 6;
            // 
            // billingId_txt
            // 
            this.billingId_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingId_txt.Location = new System.Drawing.Point(156, 13);
            this.billingId_txt.Name = "billingId_txt";
            this.billingId_txt.ReadOnly = true;
            this.billingId_txt.Size = new System.Drawing.Size(493, 25);
            this.billingId_txt.TabIndex = 6;
            // 
            // reservationBillingDataGridView
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.reservationBillingDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationBillingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.reservationBillingDataGridView.ColumnHeadersHeight = 15;
            this.reservationBillingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.reservationBillingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billing_id,
            this.reservation_id,
            this.customer_name,
            this.serviceType,
            this.extraExpense_reason,
            this.extraExpense_cost,
            this.total_cost});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reservationBillingDataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.reservationBillingDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reservationBillingDataGridView.Location = new System.Drawing.Point(12, 295);
            this.reservationBillingDataGridView.Name = "reservationBillingDataGridView";
            this.reservationBillingDataGridView.RowHeadersVisible = false;
            this.reservationBillingDataGridView.Size = new System.Drawing.Size(1223, 436);
            this.reservationBillingDataGridView.TabIndex = 5;
            this.reservationBillingDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.reservationBillingDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.reservationBillingDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.reservationBillingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.reservationBillingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.reservationBillingDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.reservationBillingDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reservationBillingDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.reservationBillingDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reservationBillingDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationBillingDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.reservationBillingDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.reservationBillingDataGridView.ThemeStyle.HeaderStyle.Height = 15;
            this.reservationBillingDataGridView.ThemeStyle.ReadOnly = false;
            this.reservationBillingDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.reservationBillingDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.reservationBillingDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationBillingDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.reservationBillingDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.reservationBillingDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reservationBillingDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.reservationBillingDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getBillingInformation_CellClick);
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
            this.reservation_id.DataPropertyName = "reservation_id";
            this.reservation_id.FillWeight = 101.4748F;
            this.reservation_id.HeaderText = "RESERVATION ID";
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
            // partsBilling_btn
            // 
            this.partsBilling_btn.BorderRadius = 10;
            this.partsBilling_btn.BorderThickness = 1;
            this.partsBilling_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.partsBilling_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.partsBilling_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.partsBilling_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.partsBilling_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsBilling_btn.ForeColor = System.Drawing.Color.White;
            this.partsBilling_btn.Location = new System.Drawing.Point(1084, 3);
            this.partsBilling_btn.Name = "partsBilling_btn";
            this.partsBilling_btn.Size = new System.Drawing.Size(164, 35);
            this.partsBilling_btn.TabIndex = 4;
            this.partsBilling_btn.Text = "Go to Parts Billing";
            this.partsBilling_btn.Click += new System.EventHandler(this.partsBilling_btn_Click);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.billingPanelContainer);
            this.Name = "BillingForm";
            this.Size = new System.Drawing.Size(1251, 744);
            this.Load += new System.EventHandler(this.BillingForm_Load);
            this.billingPanelContainer.ResumeLayout(false);
            this.billingPanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBillingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel billingPanelContainer;
        private Guna.UI2.WinForms.Guna2Button partsBilling_btn;
        private Guna.UI2.WinForms.Guna2DataGridView reservationBillingDataGridView;
        private System.Windows.Forms.TextBox billingId_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serviceType_txt;
        private System.Windows.Forms.TextBox extraExpenseReason_txt;
        private System.Windows.Forms.TextBox extraExpenseCost_txt;
        private System.Windows.Forms.TextBox reservationId_txt;
        private System.Windows.Forms.TextBox customerName_txt;
        private Guna.UI2.WinForms.Guna2TextBox totalCost_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button invoice_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billing_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraExpense_reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraExpense_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_cost;
    }
}
