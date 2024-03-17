namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class MechanicRegForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mechanicDataGrid = new System.Windows.Forms.DataGridView();
            this.mechanicId_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ViewColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mechanicId_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filter_cmbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showAll_btn = new Guna.UI2.WinForms.Guna2Button();
            this.mechanicContacttxt = new System.Windows.Forms.TextBox();
            this.specialization_cmbx = new System.Windows.Forms.ComboBox();
            this.mechanicAddresstxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mechanicLnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.register_btn = new Guna.UI2.WinForms.Guna2Button();
            this.mechanicFnametxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.clear_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicDataGrid)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mechanicDataGrid
            // 
            this.mechanicDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mechanicDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mechanicId_column,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.DeleteColumn,
            this.ViewColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mechanicDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.mechanicDataGrid.Location = new System.Drawing.Point(8, 383);
            this.mechanicDataGrid.Name = "mechanicDataGrid";
            this.mechanicDataGrid.RowHeadersVisible = false;
            this.mechanicDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mechanicDataGrid.Size = new System.Drawing.Size(1228, 348);
            this.mechanicDataGrid.TabIndex = 27;
            this.mechanicDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.action_cellContentClick);
            this.mechanicDataGrid.SelectionChanged += new System.EventHandler(this.selectMechanicChanged);
            // 
            // mechanicId_column
            // 
            this.mechanicId_column.DataPropertyName = "mechanic_id";
            this.mechanicId_column.HeaderText = "ID";
            this.mechanicId_column.Name = "mechanicId_column";
            this.mechanicId_column.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "mechanicName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 204;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "address";
            this.Column3.HeaderText = "Address";
            this.Column3.Name = "Column3";
            this.Column3.Width = 205;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "contactNumber";
            this.Column4.HeaderText = "Contact #";
            this.Column4.Name = "Column4";
            this.Column4.Width = 204;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "specialization";
            this.Column5.HeaderText = "Specialization";
            this.Column5.Name = "Column5";
            // 
            // DeleteColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.DeleteColumn.HeaderText = "Action";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // ViewColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            this.ViewColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewColumn.HeaderText = "Action";
            this.ViewColumn.Name = "ViewColumn";
            this.ViewColumn.Text = "View";
            this.ViewColumn.UseColumnTextForButtonValue = true;
            // 
            // mechanicId_txt
            // 
            this.mechanicId_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mechanicId_txt.Location = new System.Drawing.Point(424, 9);
            this.mechanicId_txt.Name = "mechanicId_txt";
            this.mechanicId_txt.ReadOnly = true;
            this.mechanicId_txt.Size = new System.Drawing.Size(80, 27);
            this.mechanicId_txt.TabIndex = 28;
            this.mechanicId_txt.TextChanged += new System.EventHandler(this.getMechanicTextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "ID:";
            // 
            // filter_cmbx
            // 
            this.filter_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_cmbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_cmbx.FormattingEnabled = true;
            this.filter_cmbx.Location = new System.Drawing.Point(907, 350);
            this.filter_cmbx.Name = "filter_cmbx";
            this.filter_cmbx.Size = new System.Drawing.Size(266, 28);
            this.filter_cmbx.TabIndex = 30;
            this.filter_cmbx.SelectedIndexChanged += new System.EventHandler(this.filterBySpecialization);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(903, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Filter by Specialization:";
            // 
            // showAll_btn
            // 
            this.showAll_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showAll_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showAll_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAll_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showAll_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showAll_btn.ForeColor = System.Drawing.Color.White;
            this.showAll_btn.Location = new System.Drawing.Point(1179, 350);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(57, 28);
            this.showAll_btn.TabIndex = 32;
            this.showAll_btn.Text = "ALL";
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // mechanicContacttxt
            // 
            this.mechanicContacttxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mechanicContacttxt.Location = new System.Drawing.Point(128, 257);
            this.mechanicContacttxt.Name = "mechanicContacttxt";
            this.mechanicContacttxt.Size = new System.Drawing.Size(376, 27);
            this.mechanicContacttxt.TabIndex = 20;
            // 
            // specialization_cmbx
            // 
            this.specialization_cmbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialization_cmbx.FormattingEnabled = true;
            this.specialization_cmbx.Location = new System.Drawing.Point(128, 290);
            this.specialization_cmbx.Name = "specialization_cmbx";
            this.specialization_cmbx.Size = new System.Drawing.Size(376, 28);
            this.specialization_cmbx.TabIndex = 22;
            // 
            // mechanicAddresstxt
            // 
            this.mechanicAddresstxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mechanicAddresstxt.Location = new System.Drawing.Point(128, 117);
            this.mechanicAddresstxt.Multiline = true;
            this.mechanicAddresstxt.Name = "mechanicAddresstxt";
            this.mechanicAddresstxt.Size = new System.Drawing.Size(376, 134);
            this.mechanicAddresstxt.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Last Name:";
            // 
            // mechanicLnametxt
            // 
            this.mechanicLnametxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mechanicLnametxt.Location = new System.Drawing.Point(128, 84);
            this.mechanicLnametxt.Name = "mechanicLnametxt";
            this.mechanicLnametxt.Size = new System.Drawing.Size(376, 27);
            this.mechanicLnametxt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Contact #:";
            // 
            // register_btn
            // 
            this.register_btn.BorderRadius = 12;
            this.register_btn.BorderThickness = 1;
            this.register_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.register_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.register_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.register_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.register_btn.FillColor = System.Drawing.Color.Green;
            this.register_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.register_btn.Location = new System.Drawing.Point(384, 324);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(120, 35);
            this.register_btn.TabIndex = 27;
            this.register_btn.Text = "Register";
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // mechanicFnametxt
            // 
            this.mechanicFnametxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mechanicFnametxt.Location = new System.Drawing.Point(128, 51);
            this.mechanicFnametxt.Name = "mechanicFnametxt";
            this.mechanicFnametxt.Size = new System.Drawing.Size(376, 27);
            this.mechanicFnametxt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Specialization:";
            // 
            // update_btn
            // 
            this.update_btn.BorderRadius = 12;
            this.update_btn.BorderThickness = 1;
            this.update_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.update_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.update_btn.Location = new System.Drawing.Point(258, 324);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(120, 35);
            this.update_btn.TabIndex = 28;
            this.update_btn.Text = "Update";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BorderRadius = 12;
            this.clear_btn.BorderThickness = 1;
            this.clear_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clear_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clear_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clear_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clear_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clear_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clear_btn.Location = new System.Drawing.Point(128, 324);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(124, 35);
            this.clear_btn.TabIndex = 33;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.clear_btn);
            this.guna2GroupBox1.Controls.Add(this.update_btn);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.specialization_cmbx);
            this.guna2GroupBox1.Controls.Add(this.register_btn);
            this.guna2GroupBox1.Controls.Add(this.mechanicId_txt);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.mechanicContacttxt);
            this.guna2GroupBox1.Controls.Add(this.mechanicLnametxt);
            this.guna2GroupBox1.Controls.Add(this.mechanicAddresstxt);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.mechanicFnametxt);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(8, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(524, 374);
            this.guna2GroupBox1.TabIndex = 34;
            this.guna2GroupBox1.Text = "Mechanic Information";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(538, 350);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 27);
            this.textBox1.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(538, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Search:";
            // 
            // MechanicRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.showAll_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.filter_cmbx);
            this.Controls.Add(this.mechanicDataGrid);
            this.Name = "MechanicRegForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1717, 909);
            this.Load += new System.EventHandler(this.MechanicRegForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mechanicDataGrid)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView mechanicDataGrid;
        private System.Windows.Forms.TextBox mechanicId_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox filter_cmbx;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button showAll_btn;
        private System.Windows.Forms.TextBox mechanicContacttxt;
        private System.Windows.Forms.ComboBox specialization_cmbx;
        private System.Windows.Forms.TextBox mechanicAddresstxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mechanicLnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button register_btn;
        private System.Windows.Forms.TextBox mechanicFnametxt;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button update_btn;
        private Guna.UI2.WinForms.Guna2Button clear_btn;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn mechanicId_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ViewColumn;
    }
}
