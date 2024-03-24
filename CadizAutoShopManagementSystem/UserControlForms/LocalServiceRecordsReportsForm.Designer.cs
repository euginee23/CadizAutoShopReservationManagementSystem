
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class LocalServiceRecordsReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.filterByMechanic_cmbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.filterByServiceType_cmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.localServiceRecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportExcel_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.showAll_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.filterDate_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.start_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.end_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.status_cmbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localServiceRecordsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.filterByMechanic_cmbx);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(339, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 146);
            this.panel4.TabIndex = 61;
            // 
            // filterByMechanic_cmbx
            // 
            this.filterByMechanic_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterByMechanic_cmbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByMechanic_cmbx.FormattingEnabled = true;
            this.filterByMechanic_cmbx.Location = new System.Drawing.Point(31, 79);
            this.filterByMechanic_cmbx.Name = "filterByMechanic_cmbx";
            this.filterByMechanic_cmbx.Size = new System.Drawing.Size(249, 28);
            this.filterByMechanic_cmbx.TabIndex = 43;
            this.filterByMechanic_cmbx.SelectedIndexChanged += new System.EventHandler(this.filterByMechanic_cmbx_SelectedIndexChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filter by Mechanic";
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
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.filterByServiceType_cmbx);
            this.panel2.Location = new System.Drawing.Point(16, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 146);
            this.panel2.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Filter by Service Done";
            // 
            // filterByServiceType_cmbx
            // 
            this.filterByServiceType_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterByServiceType_cmbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByServiceType_cmbx.FormattingEnabled = true;
            this.filterByServiceType_cmbx.Location = new System.Drawing.Point(25, 79);
            this.filterByServiceType_cmbx.Name = "filterByServiceType_cmbx";
            this.filterByServiceType_cmbx.Size = new System.Drawing.Size(249, 28);
            this.filterByServiceType_cmbx.TabIndex = 42;
            this.filterByServiceType_cmbx.SelectedIndexChanged += new System.EventHandler(this.filterByService_cmbx_SelectedIndexChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOCAL SERVICE DATA";
            // 
            // localServiceRecordsDataGridView
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.localServiceRecordsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.localServiceRecordsDataGridView.ColumnHeadersHeight = 30;
            this.localServiceRecordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column7,
            this.Column8});
            this.localServiceRecordsDataGridView.Location = new System.Drawing.Point(16, 35);
            this.localServiceRecordsDataGridView.Name = "localServiceRecordsDataGridView";
            this.localServiceRecordsDataGridView.ReadOnly = true;
            this.localServiceRecordsDataGridView.RowHeadersVisible = false;
            this.localServiceRecordsDataGridView.Size = new System.Drawing.Size(1460, 589);
            this.localServiceRecordsDataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.localServiceRecordsDataGridView);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1494, 642);
            this.panel1.TabIndex = 9;
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
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Controls.Add(this.showAll_btn);
            this.panel7.Controls.Add(this.exportExcel_btn);
            this.panel7.Location = new System.Drawing.Point(1286, 40);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(16, 672);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1494, 223);
            this.panel3.TabIndex = 10;
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
            this.panel6.Location = new System.Drawing.Point(987, 12);
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
            // Column1
            // 
            this.Column1.DataPropertyName = "localService_id";
            this.Column1.HeaderText = "SERVICE ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "customerInfo";
            this.Column2.HeaderText = "CUSTOMER";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "contactNumber";
            this.Column3.HeaderText = "CONTACT NUMBER";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "vehicleInfo";
            this.Column4.HeaderText = "VEHICLE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "serviceType";
            this.Column5.HeaderText = "SERVICE DONE";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "status";
            this.Column6.HeaderText = "STATUS";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "mechanicInfo";
            this.Column9.HeaderText = "MECHANIC";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 200;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "problem_description";
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column7.HeaderText = "PROBLEM";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "created_at";
            dataGridViewCellStyle9.Format = "D";
            dataGridViewCellStyle9.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column8.HeaderText = "DATE";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.status_cmbx);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(661, 59);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(305, 146);
            this.panel5.TabIndex = 65;
            // 
            // status_cmbx
            // 
            this.status_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_cmbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_cmbx.FormattingEnabled = true;
            this.status_cmbx.Location = new System.Drawing.Point(31, 79);
            this.status_cmbx.Name = "status_cmbx";
            this.status_cmbx.Size = new System.Drawing.Size(249, 28);
            this.status_cmbx.TabIndex = 43;
            this.status_cmbx.SelectedIndexChanged += new System.EventHandler(this.status_cmbx_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Filter by Status";
            // 
            // LocalServiceRecordsReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "LocalServiceRecordsReportsForm";
            this.Size = new System.Drawing.Size(1526, 909);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localServiceRecordsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox filterByMechanic_cmbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox filterByServiceType_cmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView localServiceRecordsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button exportExcel_btn;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2Button showAll_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button filterDate_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker start_DatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker end_DatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox status_cmbx;
        private System.Windows.Forms.Label label5;
    }
}
