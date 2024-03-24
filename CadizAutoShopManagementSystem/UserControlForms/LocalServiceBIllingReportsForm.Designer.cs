
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class LocalServiceBIllingReportsForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.showAll_btn = new Guna.UI2.WinForms.Guna2Button();
            this.exportExcel_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.filterDate_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.start_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.end_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.localServiceBillingDataGridView = new System.Windows.Forms.DataGridView();
            this.billing_idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraCostReasonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mechanicAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_atColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.totalNetIncome_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.payOut_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localServiceBillingDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(677, 672);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 223);
            this.panel3.TabIndex = 62;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Controls.Add(this.showAll_btn);
            this.panel7.Controls.Add(this.exportExcel_btn);
            this.panel7.Location = new System.Drawing.Point(622, 43);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(193, 138);
            this.panel7.TabIndex = 64;
            // 
            // showAll_btn
            // 
            this.showAll_btn.BorderRadius = 5;
            this.showAll_btn.BorderThickness = 1;
            this.showAll_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showAll_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showAll_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAll_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showAll_btn.FillColor = System.Drawing.Color.Gray;
            this.showAll_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll_btn.ForeColor = System.Drawing.Color.White;
            this.showAll_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.showAll_btn.Location = new System.Drawing.Point(15, 14);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(164, 39);
            this.showAll_btn.TabIndex = 59;
            this.showAll_btn.Text = "SHOW ALL DATA";
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // exportExcel_btn
            // 
            this.exportExcel_btn.BorderRadius = 5;
            this.exportExcel_btn.BorderThickness = 1;
            this.exportExcel_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exportExcel_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exportExcel_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exportExcel_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exportExcel_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.exportExcel_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportExcel_btn.ForeColor = System.Drawing.Color.White;
            this.exportExcel_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.exportExcel_btn.Location = new System.Drawing.Point(14, 81);
            this.exportExcel_btn.Name = "exportExcel_btn";
            this.exportExcel_btn.Size = new System.Drawing.Size(164, 40);
            this.exportExcel_btn.TabIndex = 58;
            this.exportExcel_btn.Text = "EXPORT TO EXCEL";
            this.exportExcel_btn.Click += new System.EventHandler(this.exportExcel_btn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Controls.Add(this.filterDate_btn);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.start_DatePicker);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.end_DatePicker);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(323, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(282, 193);
            this.panel6.TabIndex = 63;
            // 
            // filterDate_btn
            // 
            this.filterDate_btn.BorderRadius = 5;
            this.filterDate_btn.BorderThickness = 1;
            this.filterDate_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.filterDate_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.filterDate_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.filterDate_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.filterDate_btn.FillColor = System.Drawing.Color.Gray;
            this.filterDate_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDate_btn.ForeColor = System.Drawing.Color.White;
            this.filterDate_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.filterDate_btn.Location = new System.Drawing.Point(177, 157);
            this.filterDate_btn.Name = "filterDate_btn";
            this.filterDate_btn.Size = new System.Drawing.Size(88, 25);
            this.filterDate_btn.TabIndex = 60;
            this.filterDate_btn.Text = "FILTER";
            this.filterDate_btn.Click += new System.EventHandler(this.filterDate_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "Filter by Date:";
            // 
            // start_DatePicker
            // 
            this.start_DatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_DatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_DatePicker.Location = new System.Drawing.Point(16, 65);
            this.start_DatePicker.Name = "start_DatePicker";
            this.start_DatePicker.Size = new System.Drawing.Size(249, 29);
            this.start_DatePicker.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Start:";
            // 
            // end_DatePicker
            // 
            this.end_DatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_DatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_DatePicker.Location = new System.Drawing.Point(16, 120);
            this.end_DatePicker.Name = "end_DatePicker";
            this.end_DatePicker.Size = new System.Drawing.Size(249, 29);
            this.end_DatePicker.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "End:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "FILTERING ACTIONS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.localServiceBillingDataGridView);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1494, 642);
            this.panel1.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(593, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOCAL SERVICE DATA";
            // 
            // localServiceBillingDataGridView
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localServiceBillingDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.localServiceBillingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.localServiceBillingDataGridView.ColumnHeadersHeight = 30;
            this.localServiceBillingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billing_idColumn,
            this.customerNameColumn,
            this.serviceDoneColumn,
            this.extraCostColumn,
            this.extraCostReasonColumn,
            this.totalCostColumn,
            this.mechanicAmountColumn,
            this.created_atColumn,
            this.receiptImageColumn});
            this.localServiceBillingDataGridView.Location = new System.Drawing.Point(16, 35);
            this.localServiceBillingDataGridView.Name = "localServiceBillingDataGridView";
            this.localServiceBillingDataGridView.ReadOnly = true;
            this.localServiceBillingDataGridView.RowHeadersVisible = false;
            this.localServiceBillingDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localServiceBillingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.localServiceBillingDataGridView.Size = new System.Drawing.Size(1460, 589);
            this.localServiceBillingDataGridView.TabIndex = 0;
            // 
            // billing_idColumn
            // 
            this.billing_idColumn.DataPropertyName = "billing_id";
            this.billing_idColumn.HeaderText = "BILLING ID";
            this.billing_idColumn.Name = "billing_idColumn";
            this.billing_idColumn.ReadOnly = true;
            this.billing_idColumn.Width = 120;
            // 
            // customerNameColumn
            // 
            this.customerNameColumn.DataPropertyName = "customerName";
            this.customerNameColumn.HeaderText = "CUSTOMER NAME";
            this.customerNameColumn.Name = "customerNameColumn";
            this.customerNameColumn.ReadOnly = true;
            this.customerNameColumn.Width = 200;
            // 
            // serviceDoneColumn
            // 
            this.serviceDoneColumn.DataPropertyName = "serviceDone";
            this.serviceDoneColumn.HeaderText = "SERVICE DONE";
            this.serviceDoneColumn.Name = "serviceDoneColumn";
            this.serviceDoneColumn.ReadOnly = true;
            this.serviceDoneColumn.Width = 150;
            // 
            // extraCostColumn
            // 
            this.extraCostColumn.DataPropertyName = "extraCost";
            this.extraCostColumn.HeaderText = "EXTRA COST";
            this.extraCostColumn.Name = "extraCostColumn";
            this.extraCostColumn.ReadOnly = true;
            this.extraCostColumn.Width = 130;
            // 
            // extraCostReasonColumn
            // 
            this.extraCostReasonColumn.DataPropertyName = "extraCost_Reason";
            this.extraCostReasonColumn.HeaderText = "REASON";
            this.extraCostReasonColumn.Name = "extraCostReasonColumn";
            this.extraCostReasonColumn.ReadOnly = true;
            this.extraCostReasonColumn.Width = 250;
            // 
            // totalCostColumn
            // 
            this.totalCostColumn.DataPropertyName = "totalCost";
            this.totalCostColumn.HeaderText = "TOTAL COST";
            this.totalCostColumn.Name = "totalCostColumn";
            this.totalCostColumn.ReadOnly = true;
            this.totalCostColumn.Width = 120;
            // 
            // mechanicAmountColumn
            // 
            this.mechanicAmountColumn.HeaderText = "PAYOUT";
            this.mechanicAmountColumn.Name = "mechanicAmountColumn";
            this.mechanicAmountColumn.ReadOnly = true;
            this.mechanicAmountColumn.Width = 120;
            // 
            // created_atColumn
            // 
            this.created_atColumn.DataPropertyName = "created_at";
            this.created_atColumn.HeaderText = "DATE";
            this.created_atColumn.Name = "created_atColumn";
            this.created_atColumn.ReadOnly = true;
            this.created_atColumn.Width = 170;
            // 
            // receiptImageColumn
            // 
            this.receiptImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receiptImageColumn.HeaderText = "RECEIPT";
            this.receiptImageColumn.Name = "receiptImageColumn";
            this.receiptImageColumn.ReadOnly = true;
            // 
            // totalNetIncome_txt
            // 
            this.totalNetIncome_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalNetIncome_txt.DefaultText = "";
            this.totalNetIncome_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalNetIncome_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalNetIncome_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalNetIncome_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalNetIncome_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalNetIncome_txt.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNetIncome_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalNetIncome_txt.Location = new System.Drawing.Point(28, 69);
            this.totalNetIncome_txt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.totalNetIncome_txt.Name = "totalNetIncome_txt";
            this.totalNetIncome_txt.PasswordChar = '\0';
            this.totalNetIncome_txt.PlaceholderText = "";
            this.totalNetIncome_txt.SelectedText = "";
            this.totalNetIncome_txt.Size = new System.Drawing.Size(257, 97);
            this.totalNetIncome_txt.TabIndex = 34;
            this.totalNetIncome_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "TOTAL NET INCOME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.totalNetIncome_txt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(16, 672);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 223);
            this.panel2.TabIndex = 63;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.payOut_txt);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(348, 672);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 223);
            this.panel4.TabIndex = 64;
            // 
            // payOut_txt
            // 
            this.payOut_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.payOut_txt.DefaultText = "";
            this.payOut_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.payOut_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.payOut_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.payOut_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.payOut_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.payOut_txt.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payOut_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.payOut_txt.Location = new System.Drawing.Point(28, 69);
            this.payOut_txt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.payOut_txt.Name = "payOut_txt";
            this.payOut_txt.PasswordChar = '\0';
            this.payOut_txt.PlaceholderText = "";
            this.payOut_txt.SelectedText = "";
            this.payOut_txt.Size = new System.Drawing.Size(257, 97);
            this.payOut_txt.TabIndex = 34;
            this.payOut_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 60);
            this.label3.TabIndex = 5;
            this.label3.Text = " TOTAL DEDUCTED \r\nMECHANIC PAYOUT\r\n";
            // 
            // LocalServiceBIllingReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "LocalServiceBIllingReportsForm";
            this.Size = new System.Drawing.Size(1526, 909);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localServiceBillingDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2Button showAll_btn;
        private Guna.UI2.WinForms.Guna2Button exportExcel_btn;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button filterDate_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker start_DatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker end_DatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView localServiceBillingDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox totalNetIncome_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox payOut_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn billing_idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraCostReasonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mechanicAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_atColumn;
        private System.Windows.Forms.DataGridViewImageColumn receiptImageColumn;
    }
}
