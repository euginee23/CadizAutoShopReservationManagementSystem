
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class LogInReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loginHistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exportExcel_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clearData_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.filterDate_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.start_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.end_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginHistoryDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loginHistoryDataGrid);
            this.panel1.Location = new System.Drawing.Point(321, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 880);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOG-IN HISTORY DATA";
            // 
            // loginHistoryDataGrid
            // 
            this.loginHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loginHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.loginHistoryDataGrid.Location = new System.Drawing.Point(16, 34);
            this.loginHistoryDataGrid.Name = "loginHistoryDataGrid";
            this.loginHistoryDataGrid.ReadOnly = true;
            this.loginHistoryDataGrid.RowHeadersVisible = false;
            this.loginHistoryDataGrid.Size = new System.Drawing.Size(852, 829);
            this.loginHistoryDataGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "user_id";
            this.Column1.HeaderText = "USER ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "userRole";
            this.Column2.HeaderText = "USER TYPE";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "firstName";
            this.Column3.HeaderText = "NAME";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "lastName";
            this.Column4.HeaderText = "LAST NAME";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "date";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.Format = "D";
            dataGridViewCellStyle9.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column5.HeaderText = "DATE";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "time";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Format = "t";
            dataGridViewCellStyle10.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column6.HeaderText = "TIME";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.exportExcel_btn);
            this.panel2.Location = new System.Drawing.Point(1237, 808);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 86);
            this.panel2.TabIndex = 3;
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
            this.exportExcel_btn.Location = new System.Drawing.Point(21, 21);
            this.exportExcel_btn.Name = "exportExcel_btn";
            this.exportExcel_btn.Size = new System.Drawing.Size(219, 48);
            this.exportExcel_btn.TabIndex = 58;
            this.exportExcel_btn.Text = "EXPORT TO EXCEL";
            this.exportExcel_btn.Click += new System.EventHandler(this.exportExcel_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.clearData_btn);
            this.panel3.Location = new System.Drawing.Point(1237, 701);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 86);
            this.panel3.TabIndex = 4;
            // 
            // clearData_btn
            // 
            this.clearData_btn.BorderRadius = 5;
            this.clearData_btn.BorderThickness = 1;
            this.clearData_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearData_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearData_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearData_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearData_btn.FillColor = System.Drawing.Color.Maroon;
            this.clearData_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearData_btn.ForeColor = System.Drawing.Color.White;
            this.clearData_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clearData_btn.Location = new System.Drawing.Point(21, 21);
            this.clearData_btn.Name = "clearData_btn";
            this.clearData_btn.Size = new System.Drawing.Size(219, 48);
            this.clearData_btn.TabIndex = 58;
            this.clearData_btn.Text = "CLEAR DATA";
            this.clearData_btn.Click += new System.EventHandler(this.clearData_btn_Click);
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
            this.panel6.Location = new System.Drawing.Point(18, 701);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(282, 193);
            this.panel6.TabIndex = 64;
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
            // LogInReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LogInReportsForm";
            this.Size = new System.Drawing.Size(1526, 909);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginHistoryDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView loginHistoryDataGrid;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button exportExcel_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button clearData_btn;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button filterDate_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker start_DatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker end_DatePicker;
        private System.Windows.Forms.Label label8;
    }
}
