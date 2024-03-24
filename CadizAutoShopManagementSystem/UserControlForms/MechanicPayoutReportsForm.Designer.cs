
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class MechanicPayoutReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.specialization_cmbx = new System.Windows.Forms.ComboBox();
            this.filterDate_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.start_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.end_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showAll_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.exportExcel_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.payoutReportsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payoutReportsDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // specialization_cmbx
            // 
            this.specialization_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialization_cmbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialization_cmbx.FormattingEnabled = true;
            this.specialization_cmbx.Location = new System.Drawing.Point(25, 79);
            this.specialization_cmbx.Name = "specialization_cmbx";
            this.specialization_cmbx.Size = new System.Drawing.Size(249, 28);
            this.specialization_cmbx.TabIndex = 42;
            this.specialization_cmbx.SelectedIndexChanged += new System.EventHandler(this.specialization_cmbx_SelectedIndexChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Filter by Specialization";
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
            this.panel6.Location = new System.Drawing.Point(987, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(282, 193);
            this.panel6.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.payoutReportsDataGridView);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1494, 642);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "PAYOUT DATA";
            // 
            // payoutReportsDataGridView
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payoutReportsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.payoutReportsDataGridView.ColumnHeadersHeight = 30;
            this.payoutReportsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.pay_amount});
            this.payoutReportsDataGridView.Location = new System.Drawing.Point(16, 35);
            this.payoutReportsDataGridView.Name = "payoutReportsDataGridView";
            this.payoutReportsDataGridView.ReadOnly = true;
            this.payoutReportsDataGridView.RowHeadersVisible = false;
            this.payoutReportsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payoutReportsDataGridView.Size = new System.Drawing.Size(1460, 589);
            this.payoutReportsDataGridView.TabIndex = 0;
            this.payoutReportsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PayoutReportsDataGridView_CellFormatting);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(16, 672);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1494, 223);
            this.panel3.TabIndex = 8;
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
            this.panel2.Controls.Add(this.specialization_cmbx);
            this.panel2.Location = new System.Drawing.Point(16, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 146);
            this.panel2.TabIndex = 60;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mechanicInfo";
            this.Column1.HeaderText = "MECHANIC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "contactNumber";
            this.Column2.HeaderText = "CONTACT NUMBER";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "address";
            this.Column3.HeaderText = "ADDRESS";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 400;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "pay_date";
            dataGridViewCellStyle18.Format = "D";
            dataGridViewCellStyle18.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column4.HeaderText = "DATE RELEASED";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // pay_amount
            // 
            this.pay_amount.DataPropertyName = "pay_amount";
            this.pay_amount.HeaderText = "TOTAL AMOUNT";
            this.pay_amount.Name = "pay_amount";
            this.pay_amount.ReadOnly = true;
            this.pay_amount.Width = 300;
            // 
            // MechanicPayoutReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "MechanicPayoutReportsForm";
            this.Size = new System.Drawing.Size(1526, 909);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payoutReportsDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox specialization_cmbx;
        private Guna.UI2.WinForms.Guna2Button filterDate_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker start_DatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker end_DatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button showAll_btn;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2Button exportExcel_btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView payoutReportsDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_amount;
    }
}
