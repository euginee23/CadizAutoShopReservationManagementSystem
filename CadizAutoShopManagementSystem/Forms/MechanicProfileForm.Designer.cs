
namespace CadizAutoShopManagementSystem.Forms
{
    partial class MechanicProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MechanicProfileForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mechanicName_lbl = new System.Windows.Forms.Label();
            this.addressPhone_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.specialization_lbl = new System.Windows.Forms.Label();
            this.workHistoryDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPayout_lbl = new System.Windows.Forms.Label();
            this.billing_button = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mechanicId_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workHistoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mechanicName_lbl
            // 
            this.mechanicName_lbl.AutoSize = true;
            this.mechanicName_lbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mechanicName_lbl.Location = new System.Drawing.Point(12, 9);
            this.mechanicName_lbl.Name = "mechanicName_lbl";
            this.mechanicName_lbl.Size = new System.Drawing.Size(39, 50);
            this.mechanicName_lbl.TabIndex = 0;
            this.mechanicName_lbl.Text = "?";
            // 
            // addressPhone_lbl
            // 
            this.addressPhone_lbl.AutoSize = true;
            this.addressPhone_lbl.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressPhone_lbl.Location = new System.Drawing.Point(16, 69);
            this.addressPhone_lbl.Name = "addressPhone_lbl";
            this.addressPhone_lbl.Size = new System.Drawing.Size(22, 30);
            this.addressPhone_lbl.TabIndex = 1;
            this.addressPhone_lbl.Text = "?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(12, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 24);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(636, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Skill Assigned:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Work History:";
            // 
            // specialization_lbl
            // 
            this.specialization_lbl.AutoSize = true;
            this.specialization_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialization_lbl.Location = new System.Drawing.Point(156, 207);
            this.specialization_lbl.Name = "specialization_lbl";
            this.specialization_lbl.Size = new System.Drawing.Size(26, 32);
            this.specialization_lbl.TabIndex = 6;
            this.specialization_lbl.Text = "?";
            // 
            // workHistoryDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.workHistoryDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.workHistoryDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workHistoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.workHistoryDataGrid.ColumnHeadersHeight = 15;
            this.workHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.workHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.workHistoryDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.workHistoryDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.workHistoryDataGrid.Location = new System.Drawing.Point(162, 274);
            this.workHistoryDataGrid.Name = "workHistoryDataGrid";
            this.workHistoryDataGrid.RowHeadersVisible = false;
            this.workHistoryDataGrid.Size = new System.Drawing.Size(574, 417);
            this.workHistoryDataGrid.TabIndex = 7;
            this.workHistoryDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.workHistoryDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.workHistoryDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.workHistoryDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.workHistoryDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.workHistoryDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.workHistoryDataGrid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.workHistoryDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.workHistoryDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.workHistoryDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.workHistoryDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workHistoryDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.workHistoryDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.workHistoryDataGrid.ThemeStyle.HeaderStyle.Height = 15;
            this.workHistoryDataGrid.ThemeStyle.ReadOnly = false;
            this.workHistoryDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.workHistoryDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.workHistoryDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workHistoryDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.workHistoryDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.workHistoryDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.workHistoryDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 722);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Current Payout Amount:";
            // 
            // totalPayout_lbl
            // 
            this.totalPayout_lbl.AutoSize = true;
            this.totalPayout_lbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayout_lbl.ForeColor = System.Drawing.Color.Gray;
            this.totalPayout_lbl.Location = new System.Drawing.Point(508, 706);
            this.totalPayout_lbl.Name = "totalPayout_lbl";
            this.totalPayout_lbl.Size = new System.Drawing.Size(39, 50);
            this.totalPayout_lbl.TabIndex = 9;
            this.totalPayout_lbl.Text = "?";
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
            this.billing_button.Location = new System.Drawing.Point(509, 834);
            this.billing_button.Name = "billing_button";
            this.billing_button.Size = new System.Drawing.Size(227, 45);
            this.billing_button.TabIndex = 43;
            this.billing_button.Text = "RELEASE PAYOUT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 30);
            this.label8.TabIndex = 44;
            this.label8.Text = "Mechanic Shop ID:";
            // 
            // mechanicId_lbl
            // 
            this.mechanicId_lbl.AutoSize = true;
            this.mechanicId_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mechanicId_lbl.Location = new System.Drawing.Point(192, 151);
            this.mechanicId_lbl.Name = "mechanicId_lbl";
            this.mechanicId_lbl.Size = new System.Drawing.Size(26, 32);
            this.mechanicId_lbl.TabIndex = 45;
            this.mechanicId_lbl.Text = "?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(12, 804);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 24);
            this.panel2.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "created_at";
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "workType";
            this.Column2.HeaderText = "Work Type";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "totalCost";
            this.Column4.HeaderText = "Total Cost";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "payAmount";
            this.Column3.HeaderText = "Pay Amout";
            this.Column3.Name = "Column3";
            // 
            // MechanicProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 891);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mechanicId_lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.billing_button);
            this.Controls.Add(this.totalPayout_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.workHistoryDataGrid);
            this.Controls.Add(this.specialization_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addressPhone_lbl);
            this.Controls.Add(this.mechanicName_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MechanicProfileForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mechanic Profile";
            this.Load += new System.EventHandler(this.MechanicProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workHistoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mechanicName_lbl;
        private System.Windows.Forms.Label addressPhone_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label specialization_lbl;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2DataGridView workHistoryDataGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalPayout_lbl;
        private Guna.UI2.WinForms.Guna2Button billing_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label mechanicId_lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}