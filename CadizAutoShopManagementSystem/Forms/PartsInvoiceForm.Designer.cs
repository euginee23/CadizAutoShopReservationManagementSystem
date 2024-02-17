
namespace CadizAutoShopManagementSystem.Forms
{
    partial class PartsInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsInvoiceForm));
            this.panelPrint = new System.Windows.Forms.Panel();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.unit_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.totalCost_lbl = new System.Windows.Forms.Label();
            this.customerAddress_lbl = new System.Windows.Forms.Label();
            this.transactionId_lbl = new System.Windows.Forms.Label();
            this.customerName_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.billing_button = new Guna.UI2.WinForms.Guna2Button();
            this.label24 = new System.Windows.Forms.Label();
            this.print_btn = new System.Windows.Forms.PictureBox();
            this.panelPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.print_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrint
            // 
            this.panelPrint.Controls.Add(this.partsDataGridView);
            this.panelPrint.Controls.Add(this.label23);
            this.panelPrint.Controls.Add(this.label22);
            this.panelPrint.Controls.Add(this.label20);
            this.panelPrint.Controls.Add(this.totalCost_lbl);
            this.panelPrint.Controls.Add(this.customerAddress_lbl);
            this.panelPrint.Controls.Add(this.transactionId_lbl);
            this.panelPrint.Controls.Add(this.customerName_lbl);
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
            this.panelPrint.Location = new System.Drawing.Point(28, 56);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(817, 887);
            this.panelPrint.TabIndex = 1;
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unit_Column,
            this.quantity_Column,
            this.cost_Column});
            this.partsDataGridView.Location = new System.Drawing.Point(28, 296);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.RowHeadersVisible = false;
            this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.partsDataGridView.Size = new System.Drawing.Size(756, 475);
            this.partsDataGridView.TabIndex = 17;
            // 
            // unit_Column
            // 
            this.unit_Column.HeaderText = "UNIT";
            this.unit_Column.Name = "unit_Column";
            this.unit_Column.Width = 500;
            // 
            // quantity_Column
            // 
            this.quantity_Column.HeaderText = "QUANTITY";
            this.quantity_Column.Name = "quantity_Column";
            // 
            // cost_Column
            // 
            this.cost_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cost_Column.HeaderText = "COST";
            this.cost_Column.Name = "cost_Column";
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
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(391, 843);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(393, 28);
            this.label22.TabIndex = 15;
            this.label22.Text = "SIGNATURE:   _______________________________";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(488, 787);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 21);
            this.label20.TabIndex = 15;
            this.label20.Text = "TOTAL COST:";
            // 
            // totalCost_lbl
            // 
            this.totalCost_lbl.AutoSize = true;
            this.totalCost_lbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost_lbl.Location = new System.Drawing.Point(598, 774);
            this.totalCost_lbl.Name = "totalCost_lbl";
            this.totalCost_lbl.Size = new System.Drawing.Size(29, 37);
            this.totalCost_lbl.TabIndex = 14;
            this.totalCost_lbl.Text = "?";
            // 
            // customerAddress_lbl
            // 
            this.customerAddress_lbl.AutoSize = true;
            this.customerAddress_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddress_lbl.Location = new System.Drawing.Point(175, 261);
            this.customerAddress_lbl.Name = "customerAddress_lbl";
            this.customerAddress_lbl.Size = new System.Drawing.Size(16, 20);
            this.customerAddress_lbl.TabIndex = 14;
            this.customerAddress_lbl.Text = "?";
            // 
            // transactionId_lbl
            // 
            this.transactionId_lbl.AutoSize = true;
            this.transactionId_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionId_lbl.Location = new System.Drawing.Point(175, 227);
            this.transactionId_lbl.Name = "transactionId_lbl";
            this.transactionId_lbl.Size = new System.Drawing.Size(16, 20);
            this.transactionId_lbl.TabIndex = 14;
            this.transactionId_lbl.Text = "?";
            // 
            // customerName_lbl
            // 
            this.customerName_lbl.AutoSize = true;
            this.customerName_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName_lbl.Location = new System.Drawing.Point(175, 196);
            this.customerName_lbl.Name = "customerName_lbl";
            this.customerName_lbl.Size = new System.Drawing.Size(16, 20);
            this.customerName_lbl.TabIndex = 14;
            this.customerName_lbl.Text = "?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "BUYER ADDRESS:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "TRANSACTION ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(100, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(29, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(39, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(381, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "104 Quezon Street, Molave, Zamboanga del Sur 7023";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "molaveengineering@gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "(+63) 946 847 7861";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone No:";
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
            this.billing_button.Location = new System.Drawing.Point(618, 949);
            this.billing_button.Name = "billing_button";
            this.billing_button.Size = new System.Drawing.Size(227, 45);
            this.billing_button.TabIndex = 42;
            this.billing_button.Text = "BILL";
            this.billing_button.Click += new System.EventHandler(this.billing_button_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(739, 26);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 20);
            this.label24.TabIndex = 44;
            this.label24.Text = "PRINT";
            // 
            // print_btn
            // 
            this.print_btn.Image = ((System.Drawing.Image)(resources.GetObject("print_btn.Image")));
            this.print_btn.Location = new System.Drawing.Point(794, 6);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(51, 40);
            this.print_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.print_btn.TabIndex = 43;
            this.print_btn.TabStop = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // PartsInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 1006);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.billing_button);
            this.Controls.Add(this.panelPrint);
            this.Name = "PartsInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartsInvoiceForm";
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.print_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label totalCost_lbl;
        private System.Windows.Forms.Label customerAddress_lbl;
        private System.Windows.Forms.Label transactionId_lbl;
        private System.Windows.Forms.Label customerName_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button billing_button;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox print_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost_Column;
    }
}