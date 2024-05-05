namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class ReservationsForm
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
            this.reservationPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pendingReservation_btn_Click = new Guna.UI2.WinForms.Guna2Button();
            this.completedReservations_btn = new Guna.UI2.WinForms.Guna2Button();
            this.approvedReservation_btn_Click = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservationPanel
            // 
            this.reservationPanel.Location = new System.Drawing.Point(192, 0);
            this.reservationPanel.Name = "reservationPanel";
            this.reservationPanel.Size = new System.Drawing.Size(1525, 909);
            this.reservationPanel.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.completedReservations_btn);
            this.panel1.Controls.Add(this.pendingReservation_btn_Click);
            this.panel1.Controls.Add(this.approvedReservation_btn_Click);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 909);
            this.panel1.TabIndex = 34;
            // 
            // pendingReservation_btn_Click
            // 
            this.pendingReservation_btn_Click.BorderRadius = 3;
            this.pendingReservation_btn_Click.BorderThickness = 1;
            this.pendingReservation_btn_Click.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pendingReservation_btn_Click.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pendingReservation_btn_Click.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pendingReservation_btn_Click.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pendingReservation_btn_Click.FillColor = System.Drawing.Color.DarkGray;
            this.pendingReservation_btn_Click.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingReservation_btn_Click.ForeColor = System.Drawing.Color.Black;
            this.pendingReservation_btn_Click.Location = new System.Drawing.Point(3, 3);
            this.pendingReservation_btn_Click.Name = "pendingReservation_btn_Click";
            this.pendingReservation_btn_Click.Size = new System.Drawing.Size(183, 51);
            this.pendingReservation_btn_Click.TabIndex = 5;
            this.pendingReservation_btn_Click.Text = "PENDING";
            this.pendingReservation_btn_Click.Click += new System.EventHandler(this.pendingReservation_btn_Click_Click);
            // 
            // completedReservations_btn
            // 
            this.completedReservations_btn.BorderRadius = 3;
            this.completedReservations_btn.BorderThickness = 1;
            this.completedReservations_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.completedReservations_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.completedReservations_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.completedReservations_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.completedReservations_btn.FillColor = System.Drawing.Color.DarkGray;
            this.completedReservations_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedReservations_btn.ForeColor = System.Drawing.Color.Black;
            this.completedReservations_btn.Location = new System.Drawing.Point(3, 116);
            this.completedReservations_btn.Name = "completedReservations_btn";
            this.completedReservations_btn.Size = new System.Drawing.Size(183, 50);
            this.completedReservations_btn.TabIndex = 6;
            this.completedReservations_btn.Text = "COMPLETED";
            this.completedReservations_btn.Click += new System.EventHandler(this.completedReservations_btn_Click_1);
            // 
            // approvedReservation_btn_Click
            // 
            this.approvedReservation_btn_Click.BorderRadius = 3;
            this.approvedReservation_btn_Click.BorderThickness = 1;
            this.approvedReservation_btn_Click.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.approvedReservation_btn_Click.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.approvedReservation_btn_Click.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.approvedReservation_btn_Click.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.approvedReservation_btn_Click.FillColor = System.Drawing.Color.DarkGray;
            this.approvedReservation_btn_Click.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedReservation_btn_Click.ForeColor = System.Drawing.Color.Black;
            this.approvedReservation_btn_Click.Location = new System.Drawing.Point(3, 60);
            this.approvedReservation_btn_Click.Name = "approvedReservation_btn_Click";
            this.approvedReservation_btn_Click.Size = new System.Drawing.Size(183, 50);
            this.approvedReservation_btn_Click.TabIndex = 4;
            this.approvedReservation_btn_Click.Text = "APPROVED";
            this.approvedReservation_btn_Click.Click += new System.EventHandler(this.approvedReservation_btn_Click_Click);
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reservationPanel);
            this.Name = "ReservationsForm";
            this.Size = new System.Drawing.Size(1717, 909);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel reservationPanel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button pendingReservation_btn_Click;
        private Guna.UI2.WinForms.Guna2Button completedReservations_btn;
        private Guna.UI2.WinForms.Guna2Button approvedReservation_btn_Click;
    }
}
