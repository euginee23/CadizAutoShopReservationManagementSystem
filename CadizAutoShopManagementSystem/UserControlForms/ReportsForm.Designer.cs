
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class ReportsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reservationsReport = new Guna.UI2.WinForms.Guna2Button();
            this.reportsPanelContainer = new System.Windows.Forms.Panel();
            this.log_in_reports_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.log_in_reports_btn);
            this.panel1.Controls.Add(this.reservationsReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 909);
            this.panel1.TabIndex = 7;
            // 
            // reservationsReport
            // 
            this.reservationsReport.BorderRadius = 3;
            this.reservationsReport.BorderThickness = 1;
            this.reservationsReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reservationsReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reservationsReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reservationsReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reservationsReport.FillColor = System.Drawing.Color.DarkGray;
            this.reservationsReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsReport.ForeColor = System.Drawing.Color.Black;
            this.reservationsReport.Location = new System.Drawing.Point(3, 3);
            this.reservationsReport.Name = "reservationsReport";
            this.reservationsReport.Size = new System.Drawing.Size(183, 51);
            this.reservationsReport.TabIndex = 5;
            this.reservationsReport.Text = "RESERVATIONS";
            this.reservationsReport.Click += new System.EventHandler(this.reservationsReport_Click);
            // 
            // reportsPanelContainer
            // 
            this.reportsPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsPanelContainer.Location = new System.Drawing.Point(191, 0);
            this.reportsPanelContainer.Name = "reportsPanelContainer";
            this.reportsPanelContainer.Size = new System.Drawing.Size(1526, 909);
            this.reportsPanelContainer.TabIndex = 8;
            // 
            // log_in_reports_btn
            // 
            this.log_in_reports_btn.BorderRadius = 3;
            this.log_in_reports_btn.BorderThickness = 1;
            this.log_in_reports_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.log_in_reports_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.log_in_reports_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.log_in_reports_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.log_in_reports_btn.FillColor = System.Drawing.Color.DarkGray;
            this.log_in_reports_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_in_reports_btn.ForeColor = System.Drawing.Color.Black;
            this.log_in_reports_btn.Location = new System.Drawing.Point(3, 60);
            this.log_in_reports_btn.Name = "log_in_reports_btn";
            this.log_in_reports_btn.Size = new System.Drawing.Size(183, 51);
            this.log_in_reports_btn.TabIndex = 6;
            this.log_in_reports_btn.Text = "LOG-IN REPORTS";
            this.log_in_reports_btn.Click += new System.EventHandler(this.log_in_reports_btn_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportsPanelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsForm";
            this.Size = new System.Drawing.Size(1717, 909);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button reservationsReport;
        private System.Windows.Forms.Panel reportsPanelContainer;
        private Guna.UI2.WinForms.Guna2Button log_in_reports_btn;
    }
}
