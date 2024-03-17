
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class SettingsForm
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
            this.serviceBilling_btn = new Guna.UI2.WinForms.Guna2Button();
            this.adminAccount_btn = new Guna.UI2.WinForms.Guna2Button();
            this.partsBilling_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panelSettingsContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.serviceBilling_btn);
            this.panel1.Controls.Add(this.adminAccount_btn);
            this.panel1.Controls.Add(this.partsBilling_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 909);
            this.panel1.TabIndex = 7;
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
            this.serviceBilling_btn.Text = "PERSONNEL ACCESS";
            // 
            // adminAccount_btn
            // 
            this.adminAccount_btn.BorderRadius = 3;
            this.adminAccount_btn.BorderThickness = 1;
            this.adminAccount_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adminAccount_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adminAccount_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adminAccount_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adminAccount_btn.FillColor = System.Drawing.Color.DarkGray;
            this.adminAccount_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAccount_btn.ForeColor = System.Drawing.Color.Black;
            this.adminAccount_btn.Location = new System.Drawing.Point(3, 3);
            this.adminAccount_btn.Name = "adminAccount_btn";
            this.adminAccount_btn.Size = new System.Drawing.Size(183, 51);
            this.adminAccount_btn.TabIndex = 5;
            this.adminAccount_btn.Text = "ADMIN ACCOUNT";
            this.adminAccount_btn.Click += new System.EventHandler(this.adminAccount_btn_Click);
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
            this.partsBilling_btn.Text = "MANAGE STAFF";
            // 
            // panelSettingsContainer
            // 
            this.panelSettingsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettingsContainer.Location = new System.Drawing.Point(191, 0);
            this.panelSettingsContainer.Name = "panelSettingsContainer";
            this.panelSettingsContainer.Size = new System.Drawing.Size(1526, 909);
            this.panelSettingsContainer.TabIndex = 8;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSettingsContainer);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsForm";
            this.Size = new System.Drawing.Size(1717, 909);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button serviceBilling_btn;
        private Guna.UI2.WinForms.Guna2Button adminAccount_btn;
        private Guna.UI2.WinForms.Guna2Button partsBilling_btn;
        private System.Windows.Forms.Panel panelSettingsContainer;
    }
}
