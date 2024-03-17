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
            this.billingPanelContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.partsBilling_btn = new Guna.UI2.WinForms.Guna2Button();
            this.reservationBilling_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serviceBilling_btn = new Guna.UI2.WinForms.Guna2Button();
            this.billingPanelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // billingPanelContainer
            // 
            this.billingPanelContainer.Controls.Add(this.label1);
            this.billingPanelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.billingPanelContainer.Location = new System.Drawing.Point(194, 0);
            this.billingPanelContainer.Name = "billingPanelContainer";
            this.billingPanelContainer.Size = new System.Drawing.Size(1523, 909);
            this.billingPanelContainer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT BILLING WINDOW";
            // 
            // partsBilling_btn
            // 
            this.partsBilling_btn.BorderRadius = 3;
            this.partsBilling_btn.BorderThickness = 1;
            this.partsBilling_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.partsBilling_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.partsBilling_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.partsBilling_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.partsBilling_btn.FillColor = System.Drawing.Color.DarkGray;
            this.partsBilling_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsBilling_btn.ForeColor = System.Drawing.Color.Black;
            this.partsBilling_btn.Location = new System.Drawing.Point(3, 60);
            this.partsBilling_btn.Name = "partsBilling_btn";
            this.partsBilling_btn.Size = new System.Drawing.Size(183, 50);
            this.partsBilling_btn.TabIndex = 4;
            this.partsBilling_btn.Text = "PARTS BILLING";
            this.partsBilling_btn.Click += new System.EventHandler(this.partsBilling_btn_Click);
            // 
            // reservationBilling_btn
            // 
            this.reservationBilling_btn.BorderRadius = 3;
            this.reservationBilling_btn.BorderThickness = 1;
            this.reservationBilling_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reservationBilling_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reservationBilling_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reservationBilling_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reservationBilling_btn.FillColor = System.Drawing.Color.DarkGray;
            this.reservationBilling_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationBilling_btn.ForeColor = System.Drawing.Color.Black;
            this.reservationBilling_btn.Location = new System.Drawing.Point(3, 3);
            this.reservationBilling_btn.Name = "reservationBilling_btn";
            this.reservationBilling_btn.Size = new System.Drawing.Size(183, 51);
            this.reservationBilling_btn.TabIndex = 5;
            this.reservationBilling_btn.Text = "RERVATION BILLING";
            this.reservationBilling_btn.Click += new System.EventHandler(this.reservationBilling_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.serviceBilling_btn);
            this.panel1.Controls.Add(this.reservationBilling_btn);
            this.panel1.Controls.Add(this.partsBilling_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 909);
            this.panel1.TabIndex = 6;
            // 
            // serviceBilling_btn
            // 
            this.serviceBilling_btn.BorderRadius = 3;
            this.serviceBilling_btn.BorderThickness = 1;
            this.serviceBilling_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.serviceBilling_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.serviceBilling_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.serviceBilling_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.serviceBilling_btn.FillColor = System.Drawing.Color.DarkGray;
            this.serviceBilling_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceBilling_btn.ForeColor = System.Drawing.Color.Black;
            this.serviceBilling_btn.Location = new System.Drawing.Point(3, 116);
            this.serviceBilling_btn.Name = "serviceBilling_btn";
            this.serviceBilling_btn.Size = new System.Drawing.Size(183, 50);
            this.serviceBilling_btn.TabIndex = 6;
            this.serviceBilling_btn.Text = "SERVICE BILLING";
            this.serviceBilling_btn.Click += new System.EventHandler(this.serviceBilling_btn_Click);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.billingPanelContainer);
            this.Name = "BillingForm";
            this.Size = new System.Drawing.Size(1717, 909);
            this.billingPanelContainer.ResumeLayout(false);
            this.billingPanelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel billingPanelContainer;
        private Guna.UI2.WinForms.Guna2Button partsBilling_btn;
        private Guna.UI2.WinForms.Guna2Button reservationBilling_btn;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button serviceBilling_btn;
        private System.Windows.Forms.Label label1;
    }
}
