
namespace CadizAutoShopManagementSystem.Forms
{
    partial class LocalServicesMarkingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalServicesMarkingForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.progress_btn = new Guna.UI2.WinForms.Guna2Button();
            this.cancel_btn = new Guna.UI2.WinForms.Guna2Button();
            this.done_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.progress_btn);
            this.panel2.Controls.Add(this.cancel_btn);
            this.panel2.Controls.Add(this.done_btn);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 60);
            this.panel2.TabIndex = 46;
            // 
            // progress_btn
            // 
            this.progress_btn.BorderRadius = 2;
            this.progress_btn.BorderThickness = 1;
            this.progress_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.progress_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.progress_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.progress_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.progress_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progress_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_btn.ForeColor = System.Drawing.Color.White;
            this.progress_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progress_btn.Location = new System.Drawing.Point(207, 12);
            this.progress_btn.Name = "progress_btn";
            this.progress_btn.Size = new System.Drawing.Size(198, 39);
            this.progress_btn.TabIndex = 42;
            this.progress_btn.Text = "ON-PROGRESS";
            this.progress_btn.Click += new System.EventHandler(this.progress_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BorderRadius = 2;
            this.cancel_btn.BorderThickness = 1;
            this.cancel_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancel_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancel_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancel_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancel_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cancel_btn.Location = new System.Drawing.Point(14, 12);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(187, 39);
            this.cancel_btn.TabIndex = 43;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // done_btn
            // 
            this.done_btn.BorderRadius = 2;
            this.done_btn.BorderThickness = 1;
            this.done_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.done_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.done_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.done_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.done_btn.FillColor = System.Drawing.Color.Green;
            this.done_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_btn.ForeColor = System.Drawing.Color.White;
            this.done_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.done_btn.Location = new System.Drawing.Point(411, 12);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(198, 39);
            this.done_btn.TabIndex = 27;
            this.done_btn.Text = "DONE";
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // LocalServicesMarkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 67);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LocalServicesMarkingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARK SERVICE STATUS AS:";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button progress_btn;
        private Guna.UI2.WinForms.Guna2Button cancel_btn;
        private Guna.UI2.WinForms.Guna2Button done_btn;
    }
}