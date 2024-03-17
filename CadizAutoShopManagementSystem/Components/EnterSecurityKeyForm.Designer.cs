
namespace CadizAutoShopManagementSystem.Components
{
    partial class EnterSecurityKeyForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.securityKey_txt = new System.Windows.Forms.TextBox();
            this.continue_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // securityKey_txt
            // 
            this.securityKey_txt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityKey_txt.Location = new System.Drawing.Point(30, 71);
            this.securityKey_txt.Name = "securityKey_txt";
            this.securityKey_txt.PasswordChar = '•';
            this.securityKey_txt.Size = new System.Drawing.Size(561, 43);
            this.securityKey_txt.TabIndex = 58;
            this.securityKey_txt.UseSystemPasswordChar = true;
            // 
            // continue_btn
            // 
            this.continue_btn.BorderRadius = 3;
            this.continue_btn.BorderThickness = 1;
            this.continue_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.continue_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.continue_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.continue_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.continue_btn.FillColor = System.Drawing.Color.Green;
            this.continue_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_btn.ForeColor = System.Drawing.Color.White;
            this.continue_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.continue_btn.Location = new System.Drawing.Point(215, 170);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(227, 36);
            this.continue_btn.TabIndex = 59;
            this.continue_btn.Text = "CONTINUE";
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.securityKey_txt);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(621, 140);
            this.panel5.TabIndex = 66;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(146, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(333, 40);
            this.label20.TabIndex = 66;
            this.label20.Text = "Please Enter Security Key";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(12, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 52);
            this.panel3.TabIndex = 67;
            // 
            // EnterSecurityKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 224);
            this.Controls.Add(this.continue_btn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterSecurityKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Security Key to Continue";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox securityKey_txt;
        private Guna.UI2.WinForms.Guna2Button continue_btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel3;
    }
}