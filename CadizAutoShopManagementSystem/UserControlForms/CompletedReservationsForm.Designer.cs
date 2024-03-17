
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class CompletedReservationsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exportExcel_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filter_cmbx = new System.Windows.Forms.ComboBox();
            this.completedDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refresh_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.completedDataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.exportExcel_btn.Location = new System.Drawing.Point(1083, 693);
            this.exportExcel_btn.Name = "exportExcel_btn";
            this.exportExcel_btn.Size = new System.Drawing.Size(176, 35);
            this.exportExcel_btn.TabIndex = 57;
            this.exportExcel_btn.Text = "EXPORT TO EXCEL";
            this.exportExcel_btn.Click += new System.EventHandler(this.exportExcel_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 56;
            this.label2.Text = "Filter By Service Type:";
            // 
            // filter_cmbx
            // 
            this.filter_cmbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_cmbx.FormattingEnabled = true;
            this.filter_cmbx.Location = new System.Drawing.Point(793, 5);
            this.filter_cmbx.Name = "filter_cmbx";
            this.filter_cmbx.Size = new System.Drawing.Size(353, 28);
            this.filter_cmbx.TabIndex = 55;
            this.filter_cmbx.SelectedIndexChanged += new System.EventHandler(this.servicesComboBox_SelectedIndex);
            // 
            // completedDataGrid
            // 
            this.completedDataGrid.ColumnHeadersHeight = 30;
            this.completedDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.completedDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.completedDataGrid.Location = new System.Drawing.Point(14, 36);
            this.completedDataGrid.Name = "completedDataGrid";
            this.completedDataGrid.ReadOnly = true;
            this.completedDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.completedDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.completedDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.completedDataGrid.Size = new System.Drawing.Size(1245, 651);
            this.completedDataGrid.TabIndex = 54;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "reservation_id";
            this.Column1.HeaderText = "RESERVATION ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "customerName";
            this.Column2.HeaderText = "CUSTOMER NAME";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "serviceType";
            this.Column3.HeaderText = "SERVICE DONE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "vehicleName";
            this.Column4.HeaderText = "VEHICLE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "problem_description";
            this.Column5.HeaderText = "PROBLEM DESCRIPTION";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 310;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "date";
            this.Column6.HeaderText = "DATE";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 110;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "time";
            this.Column7.HeaderText = "TIME";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BorderRadius = 6;
            this.refresh_btn.BorderThickness = 1;
            this.refresh_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refresh_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refresh_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refresh_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refresh_btn.FillColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.refresh_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.refresh_btn.Location = new System.Drawing.Point(1152, 6);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(107, 24);
            this.refresh_btn.TabIndex = 53;
            this.refresh_btn.Text = "SHOW ALL";
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "COMPLETED RESERVATIONS";
            // 
            // CompletedReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exportExcel_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filter_cmbx);
            this.Controls.Add(this.completedDataGrid);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.label1);
            this.Name = "CompletedReservationsForm";
            this.Size = new System.Drawing.Size(1525, 909);
            this.Load += new System.EventHandler(this.CompletedReservationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.completedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button exportExcel_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filter_cmbx;
        private System.Windows.Forms.DataGridView completedDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Guna.UI2.WinForms.Guna2Button refresh_btn;
        private System.Windows.Forms.Label label1;
    }
}
