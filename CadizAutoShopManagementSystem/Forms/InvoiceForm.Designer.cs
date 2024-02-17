
namespace CadizAutoShopManagementSystem.Forms
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.panelPrint = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.billingId_lbl = new System.Windows.Forms.Label();
            this.reservationId_lbl = new System.Windows.Forms.Label();
            this.customerName_lbl = new System.Windows.Forms.Label();
            this.serviceType_lbl = new System.Windows.Forms.Label();
            this.extraExpenseReason_lbl = new System.Windows.Forms.Label();
            this.extraExpenseCost_lbl = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.totalCost_lbl = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.billing_button = new Guna.UI2.WinForms.Guna2Button();
            this.panelPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrint
            // 
            this.panelPrint.Controls.Add(this.label23);
            this.panelPrint.Controls.Add(this.label22);
            this.panelPrint.Controls.Add(this.label20);
            this.panelPrint.Controls.Add(this.totalCost_lbl);
            this.panelPrint.Controls.Add(this.extraExpenseCost_lbl);
            this.panelPrint.Controls.Add(this.extraExpenseReason_lbl);
            this.panelPrint.Controls.Add(this.serviceType_lbl);
            this.panelPrint.Controls.Add(this.customerName_lbl);
            this.panelPrint.Controls.Add(this.reservationId_lbl);
            this.panelPrint.Controls.Add(this.billingId_lbl);
            this.panelPrint.Controls.Add(this.label8);
            this.panelPrint.Controls.Add(this.label9);
            this.panelPrint.Controls.Add(this.label10);
            this.panelPrint.Controls.Add(this.label11);
            this.panelPrint.Controls.Add(this.label12);
            this.panelPrint.Controls.Add(this.label13);
            this.panelPrint.Controls.Add(this.label4);
            this.panelPrint.Controls.Add(this.label3);
            this.panelPrint.Controls.Add(this.label7);
            this.panelPrint.Controls.Add(this.label6);
            this.panelPrint.Controls.Add(this.label5);
            this.panelPrint.Controls.Add(this.label2);
            this.panelPrint.Controls.Add(this.label1);
            this.panelPrint.Location = new System.Drawing.Point(29, 58);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(817, 885);
            this.panelPrint.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(795, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(252, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADIZ AUTO REPAIR SHOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(39, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(29, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "(+63) 946 847 7861";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "molaveengineering@gmail.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(381, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "104 Quezon Street, Molave, Zamboanga del Sur 7023";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(227, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "EXTRA COST:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(166, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "EXTRA COST REASON:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(209, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "SERVICE DONE:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(188, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "CUSTOMER NAME:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(199, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "RESERVATION ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(238, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "BILLING ID:";
            // 
            // billingId_lbl
            // 
            this.billingId_lbl.AutoSize = true;
            this.billingId_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingId_lbl.Location = new System.Drawing.Point(342, 239);
            this.billingId_lbl.Name = "billingId_lbl";
            this.billingId_lbl.Size = new System.Drawing.Size(16, 20);
            this.billingId_lbl.TabIndex = 14;
            this.billingId_lbl.Text = "?";
            // 
            // reservationId_lbl
            // 
            this.reservationId_lbl.AutoSize = true;
            this.reservationId_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationId_lbl.Location = new System.Drawing.Point(342, 270);
            this.reservationId_lbl.Name = "reservationId_lbl";
            this.reservationId_lbl.Size = new System.Drawing.Size(16, 20);
            this.reservationId_lbl.TabIndex = 14;
            this.reservationId_lbl.Text = "?";
            // 
            // customerName_lbl
            // 
            this.customerName_lbl.AutoSize = true;
            this.customerName_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName_lbl.Location = new System.Drawing.Point(342, 304);
            this.customerName_lbl.Name = "customerName_lbl";
            this.customerName_lbl.Size = new System.Drawing.Size(16, 20);
            this.customerName_lbl.TabIndex = 14;
            this.customerName_lbl.Text = "?";
            // 
            // serviceType_lbl
            // 
            this.serviceType_lbl.AutoSize = true;
            this.serviceType_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceType_lbl.Location = new System.Drawing.Point(342, 340);
            this.serviceType_lbl.Name = "serviceType_lbl";
            this.serviceType_lbl.Size = new System.Drawing.Size(16, 20);
            this.serviceType_lbl.TabIndex = 14;
            this.serviceType_lbl.Text = "?";
            // 
            // extraExpenseReason_lbl
            // 
            this.extraExpenseReason_lbl.AutoSize = true;
            this.extraExpenseReason_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraExpenseReason_lbl.Location = new System.Drawing.Point(342, 373);
            this.extraExpenseReason_lbl.Name = "extraExpenseReason_lbl";
            this.extraExpenseReason_lbl.Size = new System.Drawing.Size(16, 20);
            this.extraExpenseReason_lbl.TabIndex = 14;
            this.extraExpenseReason_lbl.Text = "?";
            // 
            // extraExpenseCost_lbl
            // 
            this.extraExpenseCost_lbl.AutoSize = true;
            this.extraExpenseCost_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraExpenseCost_lbl.Location = new System.Drawing.Point(342, 440);
            this.extraExpenseCost_lbl.Name = "extraExpenseCost_lbl";
            this.extraExpenseCost_lbl.Size = new System.Drawing.Size(16, 20);
            this.extraExpenseCost_lbl.TabIndex = 14;
            this.extraExpenseCost_lbl.Text = "?";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(448, 581);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 21);
            this.label20.TabIndex = 15;
            this.label20.Text = "TOTAL COST:";
            // 
            // totalCost_lbl
            // 
            this.totalCost_lbl.AutoSize = true;
            this.totalCost_lbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost_lbl.Location = new System.Drawing.Point(558, 568);
            this.totalCost_lbl.Name = "totalCost_lbl";
            this.totalCost_lbl.Size = new System.Drawing.Size(29, 37);
            this.totalCost_lbl.TabIndex = 14;
            this.totalCost_lbl.Text = "?";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(391, 802);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(393, 28);
            this.label22.TabIndex = 15;
            this.label22.Text = "SIGNATURE:   _______________________________";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(13, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 20);
            this.label23.TabIndex = 16;
            this.label23.Text = "INVOICE";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(740, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 20);
            this.label24.TabIndex = 17;
            this.label24.Text = "PRINT";
            // 
            // billing_button
            // 
            this.billing_button.BorderRadius = 12;
            this.billing_button.BorderThickness = 1;
            this.billing_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.billing_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.billing_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.billing_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.billing_button.FillColor = System.Drawing.Color.Green;
            this.billing_button.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billing_button.ForeColor = System.Drawing.Color.White;
            this.billing_button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.billing_button.Location = new System.Drawing.Point(619, 949);
            this.billing_button.Name = "billing_button";
            this.billing_button.Size = new System.Drawing.Size(227, 45);
            this.billing_button.TabIndex = 41;
            this.billing_button.Text = "BILL";
            this.billing_button.Click += new System.EventHandler(this.billing_button_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 1006);
            this.Controls.Add(this.billing_button);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceForm";
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label extraExpenseCost_lbl;
        private System.Windows.Forms.Label extraExpenseReason_lbl;
        private System.Windows.Forms.Label serviceType_lbl;
        private System.Windows.Forms.Label customerName_lbl;
        private System.Windows.Forms.Label reservationId_lbl;
        private System.Windows.Forms.Label billingId_lbl;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label totalCost_lbl;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private Guna.UI2.WinForms.Guna2Button billing_button;
    }
}