namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class ServicesManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.servicesDataGrid = new System.Windows.Forms.DataGridView();
            this.serviceId_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_btn = new Guna.UI2.WinForms.Guna2Button();
            this.update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.serviceType_txt = new System.Windows.Forms.TextBox();
            this.add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.laborCost_txt = new System.Windows.Forms.TextBox();
            this.serviceId_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicesDataGrid
            // 
            this.servicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceId_column,
            this.Column2,
            this.Column3,
            this.Column4,
            this.deleteColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.servicesDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.servicesDataGrid.Location = new System.Drawing.Point(12, 308);
            this.servicesDataGrid.Name = "servicesDataGrid";
            this.servicesDataGrid.RowHeadersVisible = false;
            this.servicesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesDataGrid.Size = new System.Drawing.Size(1227, 421);
            this.servicesDataGrid.TabIndex = 33;
            this.servicesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deleteService_CellContentClick);
            this.servicesDataGrid.SelectionChanged += new System.EventHandler(this.selectService);
            // 
            // serviceId_column
            // 
            this.serviceId_column.DataPropertyName = "service_id";
            this.serviceId_column.HeaderText = "ID";
            this.serviceId_column.Name = "serviceId_column";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "serviceType";
            this.Column2.HeaderText = "SERVICE TYPE";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "serviceDescription";
            this.Column3.HeaderText = "DESCRIPTION";
            this.Column3.Name = "Column3";
            this.Column3.Width = 500;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "laborCost";
            this.Column4.HeaderText = "LABORT COST";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            this.deleteColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.deleteColumn.HeaderText = "Action";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Text = "REMOVE";
            this.deleteColumn.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.Controls.Add(this.serviceType_txt);
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.description_txt);
            this.groupBox1.Controls.Add(this.laborCost_txt);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 296);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Information";
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
            this.clear_btn.Location = new System.Drawing.Point(197, 246);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(110, 35);
            this.clear_btn.TabIndex = 29;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
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
            this.update_btn.Location = new System.Drawing.Point(313, 246);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(110, 35);
            this.update_btn.TabIndex = 28;
            this.update_btn.Text = "UPDATE";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // serviceType_txt
            // 
            this.serviceType_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceType_txt.Location = new System.Drawing.Point(119, 40);
            this.serviceType_txt.Name = "serviceType_txt";
            this.serviceType_txt.Size = new System.Drawing.Size(420, 27);
            this.serviceType_txt.TabIndex = 16;
            // 
            // add_btn
            // 
            this.add_btn.BorderRadius = 12;
            this.add_btn.BorderThickness = 1;
            this.add_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_btn.FillColor = System.Drawing.Color.Green;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_btn.Location = new System.Drawing.Point(429, 246);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(110, 35);
            this.add_btn.TabIndex = 27;
            this.add_btn.Text = "ADD";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Labor Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Service Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Description:";
            // 
            // description_txt
            // 
            this.description_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_txt.Location = new System.Drawing.Point(119, 73);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(420, 134);
            this.description_txt.TabIndex = 19;
            // 
            // laborCost_txt
            // 
            this.laborCost_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborCost_txt.Location = new System.Drawing.Point(119, 213);
            this.laborCost_txt.Name = "laborCost_txt";
            this.laborCost_txt.Size = new System.Drawing.Size(420, 27);
            this.laborCost_txt.TabIndex = 20;
            // 
            // serviceId_txt
            // 
            this.serviceId_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceId_txt.Location = new System.Drawing.Point(629, 276);
            this.serviceId_txt.Name = "serviceId_txt";
            this.serviceId_txt.ReadOnly = true;
            this.serviceId_txt.Size = new System.Drawing.Size(141, 27);
            this.serviceId_txt.TabIndex = 34;
            this.serviceId_txt.TextChanged += new System.EventHandler(this.getServicesTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID:";
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(904, 276);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(335, 27);
            this.search_txt.TabIndex = 36;
            this.search_txt.TextChanged += new System.EventHandler(this.searchServicesTextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(842, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Search:";
            // 
            // ServicesManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.serviceId_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servicesDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "ServicesManagementForm";
            this.Size = new System.Drawing.Size(1717, 909);
            this.Load += new System.EventHandler(this.ServicesManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView servicesDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button update_btn;
        private System.Windows.Forms.TextBox serviceType_txt;
        private Guna.UI2.WinForms.Guna2Button add_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.TextBox laborCost_txt;
        private System.Windows.Forms.TextBox serviceId_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button clear_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceId_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
    }
}
