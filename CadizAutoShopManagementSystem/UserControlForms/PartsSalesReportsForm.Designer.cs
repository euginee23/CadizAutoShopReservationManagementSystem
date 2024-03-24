
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class PartsSalesReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.filterDate_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.start_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.end_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.showAll_btn = new Guna.UI2.WinForms.Guna2Button();
            this.exportExcel_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalSales_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.partsSalesReportsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.receiptImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsBoughtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsSalesReportsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel6.Location = new System.Drawing.Point(502, 17);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(497, 672);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 223);
            this.panel3.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Controls.Add(this.showAll_btn);
            this.panel7.Controls.Add(this.exportExcel_btn);
            this.panel7.Location = new System.Drawing.Point(801, 45);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.totalSales_txt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(16, 672);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 223);
            this.panel2.TabIndex = 60;
            // 
            // totalSales_txt
            // 
            this.totalSales_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalSales_txt.DefaultText = "";
            this.totalSales_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalSales_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalSales_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalSales_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalSales_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalSales_txt.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSales_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalSales_txt.Location = new System.Drawing.Point(95, 69);
            this.totalSales_txt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.totalSales_txt.Name = "totalSales_txt";
            this.totalSales_txt.PasswordChar = '\0';
            this.totalSales_txt.PlaceholderText = "";
            this.totalSales_txt.SelectedText = "";
            this.totalSales_txt.Size = new System.Drawing.Size(257, 97);
            this.totalSales_txt.TabIndex = 34;
            this.totalSales_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "TOTAL SALES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "SALES DATA";
            // 
            // partsSalesReportsDataGridView
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSalesReportsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partsSalesReportsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.partsSalesReportsDataGridView.ColumnHeadersHeight = 30;
            this.partsSalesReportsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIdColumn,
            this.customerNameColumn,
            this.customerAddressColumn,
            this.partsBoughtColumn,
            this.totalCostColumn,
            this.dateColumn,
            this.receiptImageColumn});
            this.partsSalesReportsDataGridView.Location = new System.Drawing.Point(16, 35);
            this.partsSalesReportsDataGridView.Name = "partsSalesReportsDataGridView";
            this.partsSalesReportsDataGridView.ReadOnly = true;
            this.partsSalesReportsDataGridView.RowHeadersVisible = false;
            this.partsSalesReportsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSalesReportsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsSalesReportsDataGridView.Size = new System.Drawing.Size(1460, 589);
            this.partsSalesReportsDataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.partsSalesReportsDataGridView);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1494, 642);
            this.panel1.TabIndex = 9;
            // 
            // receiptImageColumn
            // 
            this.receiptImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "System.Drawing.Bitmap";
            this.receiptImageColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.receiptImageColumn.HeaderText = "RECEIPT";
            this.receiptImageColumn.Name = "receiptImageColumn";
            this.receiptImageColumn.ReadOnly = true;
            this.receiptImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateColumn
            // 
            this.dateColumn.DataPropertyName = "created_at";
            dataGridViewCellStyle4.Format = "f";
            dataGridViewCellStyle4.NullValue = null;
            this.dateColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dateColumn.HeaderText = "DATE";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Width = 250;
            // 
            // totalCostColumn
            // 
            this.totalCostColumn.DataPropertyName = "totalCost";
            this.totalCostColumn.HeaderText = "TOTAL COST";
            this.totalCostColumn.Name = "totalCostColumn";
            this.totalCostColumn.ReadOnly = true;
            this.totalCostColumn.Width = 200;
            // 
            // partsBoughtColumn
            // 
            this.partsBoughtColumn.DataPropertyName = "partsBought";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partsBoughtColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.partsBoughtColumn.HeaderText = "PARTS BOUGHT";
            this.partsBoughtColumn.Name = "partsBoughtColumn";
            this.partsBoughtColumn.ReadOnly = true;
            this.partsBoughtColumn.Width = 200;
            // 
            // customerAddressColumn
            // 
            this.customerAddressColumn.DataPropertyName = "customerAddress";
            this.customerAddressColumn.HeaderText = "CUSTOMER ADDRESS";
            this.customerAddressColumn.Name = "customerAddressColumn";
            this.customerAddressColumn.ReadOnly = true;
            this.customerAddressColumn.Width = 257;
            // 
            // customerNameColumn
            // 
            this.customerNameColumn.DataPropertyName = "customerName";
            this.customerNameColumn.HeaderText = "CUSTOMER ";
            this.customerNameColumn.Name = "customerNameColumn";
            this.customerNameColumn.ReadOnly = true;
            this.customerNameColumn.Width = 200;
            // 
            // transactionIdColumn
            // 
            this.transactionIdColumn.DataPropertyName = "transaction_id";
            this.transactionIdColumn.HeaderText = "TRANSACTION ID";
            this.transactionIdColumn.Name = "transactionIdColumn";
            this.transactionIdColumn.ReadOnly = true;
            this.transactionIdColumn.Width = 150;
            // 
            // PartsSalesReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "PartsSalesReportsForm";
            this.Size = new System.Drawing.Size(1526, 909);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsSalesReportsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button filterDate_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker start_DatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker end_DatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2Button showAll_btn;
        private Guna.UI2.WinForms.Guna2Button exportExcel_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView partsSalesReportsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox totalSales_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsBoughtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewImageColumn receiptImageColumn;
    }
}
