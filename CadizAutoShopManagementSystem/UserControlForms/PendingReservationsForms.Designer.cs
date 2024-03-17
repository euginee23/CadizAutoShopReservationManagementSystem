
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class PendingReservationsForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.filter_cmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refresh_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decline = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Approve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pendingDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pendingDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "PENDING RESERVATIONS";
            // 
            // filter_cmbx
            // 
            this.filter_cmbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_cmbx.FormattingEnabled = true;
            this.filter_cmbx.Location = new System.Drawing.Point(792, 5);
            this.filter_cmbx.Name = "filter_cmbx";
            this.filter_cmbx.Size = new System.Drawing.Size(353, 28);
            this.filter_cmbx.TabIndex = 42;
            this.filter_cmbx.SelectedIndexChanged += new System.EventHandler(this.servicesComboBox_SelectedIndex);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Filter By Service Type:";
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
            this.refresh_btn.Location = new System.Drawing.Point(1151, 5);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(107, 25);
            this.refresh_btn.TabIndex = 44;
            this.refresh_btn.Text = "SHOW ALL";
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "time";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column7.HeaderText = "Time";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "date";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "problem_description";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "Problem Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 320;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "vehicleName";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Vehicle Details";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "serviceType";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Service Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "customerName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column2.HeaderText = "Customer Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 128;
            // 
            // reservation_id
            // 
            this.reservation_id.DataPropertyName = "reservation_id";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.reservation_id.DefaultCellStyle = dataGridViewCellStyle7;
            this.reservation_id.HeaderText = "ID";
            this.reservation_id.Name = "reservation_id";
            this.reservation_id.ReadOnly = true;
            // 
            // Decline
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Decline.DefaultCellStyle = dataGridViewCellStyle8;
            this.Decline.HeaderText = "Decline";
            this.Decline.Name = "Decline";
            this.Decline.ReadOnly = true;
            this.Decline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Decline.Text = "Decline";
            this.Decline.UseColumnTextForButtonValue = true;
            // 
            // Approve
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Green;
            this.Approve.DefaultCellStyle = dataGridViewCellStyle9;
            this.Approve.HeaderText = "Approve";
            this.Approve.Name = "Approve";
            this.Approve.ReadOnly = true;
            this.Approve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Approve.Text = "Approve";
            this.Approve.UseColumnTextForButtonValue = true;
            // 
            // pendingDataGrid
            // 
            this.pendingDataGrid.ColumnHeadersHeight = 30;
            this.pendingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Approve,
            this.Decline,
            this.reservation_id,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pendingDataGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.pendingDataGrid.Location = new System.Drawing.Point(13, 36);
            this.pendingDataGrid.Name = "pendingDataGrid";
            this.pendingDataGrid.ReadOnly = true;
            this.pendingDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pendingDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.pendingDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pendingDataGrid.Size = new System.Drawing.Size(1245, 651);
            this.pendingDataGrid.TabIndex = 40;
            this.pendingDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buttonClick);
            // 
            // PendingReservationsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pendingDataGrid);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filter_cmbx);
            this.Controls.Add(this.label1);
            this.Name = "PendingReservationsForms";
            this.Size = new System.Drawing.Size(1525, 909);
            this.Load += new System.EventHandler(this.PendingReservationsFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pendingDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filter_cmbx;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button refresh_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservation_id;
        private System.Windows.Forms.DataGridViewButtonColumn Decline;
        private System.Windows.Forms.DataGridViewButtonColumn Approve;
        private System.Windows.Forms.DataGridView pendingDataGrid;
    }
}
