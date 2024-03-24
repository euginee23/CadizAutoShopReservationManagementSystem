﻿
namespace CadizAutoShopManagementSystem.Forms
{
    partial class DoneReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoneReservationForm));
            this.laborCostTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.serviceTypeTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTextBox = new System.Windows.Forms.TextBox();
            this.mechanicTextBox = new System.Windows.Forms.TextBox();
            this.extraExpensesNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.addToBilling_btn = new Guna.UI2.WinForms.Guna2Button();
            this.totalPriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.extraExpenseReason_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.extraExpensesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // laborCostTextBox
            // 
            this.laborCostTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborCostTextBox.Location = new System.Drawing.Point(160, 12);
            this.laborCostTextBox.Name = "laborCostTextBox";
            this.laborCostTextBox.ReadOnly = true;
            this.laborCostTextBox.Size = new System.Drawing.Size(307, 27);
            this.laborCostTextBox.TabIndex = 0;
            // 
            // customerTextBox
            // 
            this.customerTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextBox.Location = new System.Drawing.Point(160, 45);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.ReadOnly = true;
            this.customerTextBox.Size = new System.Drawing.Size(307, 27);
            this.customerTextBox.TabIndex = 0;
            // 
            // serviceTypeTextBox
            // 
            this.serviceTypeTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceTypeTextBox.Location = new System.Drawing.Point(160, 78);
            this.serviceTypeTextBox.Name = "serviceTypeTextBox";
            this.serviceTypeTextBox.ReadOnly = true;
            this.serviceTypeTextBox.Size = new System.Drawing.Size(307, 27);
            this.serviceTypeTextBox.TabIndex = 0;
            // 
            // vehicleTextBox
            // 
            this.vehicleTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleTextBox.Location = new System.Drawing.Point(160, 111);
            this.vehicleTextBox.Name = "vehicleTextBox";
            this.vehicleTextBox.ReadOnly = true;
            this.vehicleTextBox.Size = new System.Drawing.Size(307, 27);
            this.vehicleTextBox.TabIndex = 0;
            // 
            // mechanicTextBox
            // 
            this.mechanicTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mechanicTextBox.Location = new System.Drawing.Point(160, 144);
            this.mechanicTextBox.Name = "mechanicTextBox";
            this.mechanicTextBox.ReadOnly = true;
            this.mechanicTextBox.Size = new System.Drawing.Size(307, 27);
            this.mechanicTextBox.TabIndex = 0;
            // 
            // extraExpensesNumericUpDown
            // 
            this.extraExpensesNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.extraExpensesNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.extraExpensesNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.extraExpensesNumericUpDown.Location = new System.Drawing.Point(269, 353);
            this.extraExpensesNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.extraExpensesNumericUpDown.Name = "extraExpensesNumericUpDown";
            this.extraExpensesNumericUpDown.Size = new System.Drawing.Size(324, 36);
            this.extraExpensesNumericUpDown.TabIndex = 1;
            this.extraExpensesNumericUpDown.ValueChanged += new System.EventHandler(this.extraExpensesNumericUpDown_ValueChanged);
            // 
            // addToBilling_btn
            // 
            this.addToBilling_btn.BorderRadius = 12;
            this.addToBilling_btn.BorderThickness = 1;
            this.addToBilling_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addToBilling_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addToBilling_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addToBilling_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addToBilling_btn.FillColor = System.Drawing.Color.Green;
            this.addToBilling_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToBilling_btn.ForeColor = System.Drawing.Color.White;
            this.addToBilling_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addToBilling_btn.Location = new System.Drawing.Point(406, 492);
            this.addToBilling_btn.Name = "addToBilling_btn";
            this.addToBilling_btn.Size = new System.Drawing.Size(187, 41);
            this.addToBilling_btn.TabIndex = 31;
            this.addToBilling_btn.Text = "Add to Billing Queue";
            this.addToBilling_btn.Click += new System.EventHandler(this.addToBilling_btn_Click);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalPriceTextBox.DefaultText = "";
            this.totalPriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalPriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalPriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalPriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalPriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalPriceTextBox.Location = new System.Drawing.Point(269, 397);
            this.totalPriceTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.PasswordChar = '\0';
            this.totalPriceTextBox.PlaceholderText = "";
            this.totalPriceTextBox.SelectedText = "";
            this.totalPriceTextBox.Size = new System.Drawing.Size(324, 65);
            this.totalPriceTextBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Service Labor Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Service Done:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Vehicle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mechanic Assigned:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Extra Expenses Description / Reason:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Extra Expenses Cost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(167, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Overall Total:";
            // 
            // extraExpenseReason_txt
            // 
            this.extraExpenseReason_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraExpenseReason_txt.Location = new System.Drawing.Point(269, 204);
            this.extraExpenseReason_txt.Multiline = true;
            this.extraExpenseReason_txt.Name = "extraExpenseReason_txt";
            this.extraExpenseReason_txt.Size = new System.Drawing.Size(324, 143);
            this.extraExpenseReason_txt.TabIndex = 39;
            // 
            // DoneReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 545);
            this.Controls.Add(this.extraExpenseReason_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.addToBilling_btn);
            this.Controls.Add(this.extraExpensesNumericUpDown);
            this.Controls.Add(this.mechanicTextBox);
            this.Controls.Add(this.vehicleTextBox);
            this.Controls.Add(this.serviceTypeTextBox);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.laborCostTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoneReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mark Reservation as Done";
            this.Load += new System.EventHandler(this.DoneReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.extraExpensesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox laborCostTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox serviceTypeTextBox;
        private System.Windows.Forms.TextBox vehicleTextBox;
        private System.Windows.Forms.TextBox mechanicTextBox;
        private Guna.UI2.WinForms.Guna2NumericUpDown extraExpensesNumericUpDown;
        private Guna.UI2.WinForms.Guna2Button addToBilling_btn;
        private Guna.UI2.WinForms.Guna2TextBox totalPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox extraExpenseReason_txt;
    }
}