namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class InventoryManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.partsDataGrid = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum_Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.showId_txt = new System.Windows.Forms.TextBox();
            this.searchPart_txt = new System.Windows.Forms.TextBox();
            this.clear_btn = new Guna.UI2.WinForms.Guna2Button();
            this.partId_txt = new System.Windows.Forms.TextBox();
            this.update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.partNumber_txt = new System.Windows.Forms.TextBox();
            this.addButton_btn = new Guna.UI2.WinForms.Guna2Button();
            this.partName_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.partAvailability_txt = new System.Windows.Forms.TextBox();
            this.partCat_cmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.partPrice_txt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.partModel_txt = new System.Windows.Forms.ComboBox();
            this.generate_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showAll_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.filterCat_cmbx = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addQuantity_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // partsDataGrid
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.partsDataGrid.ColumnHeadersHeight = 40;
            this.partsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Number,
            this.Column_Name,
            this.Column_Model,
            this.Column_Price,
            this.Colum_Availability,
            this.Remove});
            this.partsDataGrid.Location = new System.Drawing.Point(15, 15);
            this.partsDataGrid.Name = "partsDataGrid";
            this.partsDataGrid.ReadOnly = true;
            this.partsDataGrid.RowHeadersVisible = false;
            this.partsDataGrid.RowHeadersWidth = 40;
            this.partsDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsDataGrid.RowTemplate.Height = 40;
            this.partsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGrid.Size = new System.Drawing.Size(1024, 790);
            this.partsDataGrid.TabIndex = 32;
            this.partsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getPart_CellClick);
            this.partsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.removePart_CellContentClick);
            // 
            // Column_ID
            // 
            this.Column_ID.DataPropertyName = "part_id";
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            // 
            // Column_Number
            // 
            this.Column_Number.DataPropertyName = "part_number";
            this.Column_Number.HeaderText = "NUMBER";
            this.Column_Number.Name = "Column_Number";
            this.Column_Number.ReadOnly = true;
            this.Column_Number.Width = 120;
            // 
            // Column_Name
            // 
            this.Column_Name.DataPropertyName = "part_name";
            this.Column_Name.HeaderText = "NAME";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            this.Column_Name.Width = 250;
            // 
            // Column_Model
            // 
            this.Column_Model.DataPropertyName = "part_model";
            this.Column_Model.HeaderText = "MODEL";
            this.Column_Model.Name = "Column_Model";
            this.Column_Model.ReadOnly = true;
            this.Column_Model.Width = 150;
            // 
            // Column_Price
            // 
            this.Column_Price.DataPropertyName = "price";
            this.Column_Price.HeaderText = "PRICE";
            this.Column_Price.Name = "Column_Price";
            this.Column_Price.ReadOnly = true;
            this.Column_Price.Width = 150;
            // 
            // Colum_Availability
            // 
            this.Colum_Availability.DataPropertyName = "availability";
            this.Colum_Availability.HeaderText = "AVAILABILITY";
            this.Colum_Availability.Name = "Colum_Availability";
            this.Colum_Availability.ReadOnly = true;
            this.Colum_Availability.Width = 150;
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.DefaultCellStyle = dataGridViewCellStyle3;
            this.Remove.HeaderText = "ACTION";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // showId_txt
            // 
            this.showId_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showId_txt.Location = new System.Drawing.Point(527, 7);
            this.showId_txt.Name = "showId_txt";
            this.showId_txt.ReadOnly = true;
            this.showId_txt.Size = new System.Drawing.Size(80, 27);
            this.showId_txt.TabIndex = 33;
            this.showId_txt.TextChanged += new System.EventHandler(this.getPartInfo_TextChanged);
            // 
            // searchPart_txt
            // 
            this.searchPart_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPart_txt.Location = new System.Drawing.Point(73, 13);
            this.searchPart_txt.Name = "searchPart_txt";
            this.searchPart_txt.Size = new System.Drawing.Size(388, 27);
            this.searchPart_txt.TabIndex = 35;
            this.searchPart_txt.TextChanged += new System.EventHandler(this.searchPart_TextChanged);
            // 
            // clear_btn
            // 
            this.clear_btn.BorderRadius = 3;
            this.clear_btn.BorderThickness = 1;
            this.clear_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clear_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clear_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clear_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clear_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clear_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clear_btn.Location = new System.Drawing.Point(13, 11);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(187, 39);
            this.clear_btn.TabIndex = 55;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // partId_txt
            // 
            this.partId_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partId_txt.Location = new System.Drawing.Point(13, 74);
            this.partId_txt.Name = "partId_txt";
            this.partId_txt.Size = new System.Drawing.Size(476, 27);
            this.partId_txt.TabIndex = 44;
            // 
            // update_btn
            // 
            this.update_btn.BorderRadius = 3;
            this.update_btn.BorderThickness = 1;
            this.update_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.update_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.update_btn.Location = new System.Drawing.Point(212, 11);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(186, 39);
            this.update_btn.TabIndex = 54;
            this.update_btn.Text = "UPDATE";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // partNumber_txt
            // 
            this.partNumber_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumber_txt.Location = new System.Drawing.Point(13, 215);
            this.partNumber_txt.Name = "partNumber_txt";
            this.partNumber_txt.Size = new System.Drawing.Size(594, 27);
            this.partNumber_txt.TabIndex = 36;
            // 
            // addButton_btn
            // 
            this.addButton_btn.BorderRadius = 3;
            this.addButton_btn.BorderThickness = 1;
            this.addButton_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton_btn.FillColor = System.Drawing.Color.Green;
            this.addButton_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton_btn.ForeColor = System.Drawing.Color.White;
            this.addButton_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addButton_btn.Location = new System.Drawing.Point(409, 11);
            this.addButton_btn.Name = "addButton_btn";
            this.addButton_btn.Size = new System.Drawing.Size(198, 39);
            this.addButton_btn.TabIndex = 53;
            this.addButton_btn.Text = "ADD";
            this.addButton_btn.Click += new System.EventHandler(this.addButton_btn_Click);
            // 
            // partName_txt
            // 
            this.partName_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partName_txt.Location = new System.Drawing.Point(13, 290);
            this.partName_txt.Name = "partName_txt";
            this.partName_txt.Size = new System.Drawing.Size(594, 27);
            this.partName_txt.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 556);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Part Number:";
            // 
            // description_txt
            // 
            this.description_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_txt.Location = new System.Drawing.Point(13, 579);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(594, 140);
            this.description_txt.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Availability:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Part Name:";
            // 
            // partAvailability_txt
            // 
            this.partAvailability_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partAvailability_txt.Location = new System.Drawing.Point(14, 510);
            this.partAvailability_txt.Name = "partAvailability_txt";
            this.partAvailability_txt.ReadOnly = true;
            this.partAvailability_txt.Size = new System.Drawing.Size(283, 27);
            this.partAvailability_txt.TabIndex = 47;
            // 
            // partCat_cmbx
            // 
            this.partCat_cmbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partCat_cmbx.FormattingEnabled = true;
            this.partCat_cmbx.Location = new System.Drawing.Point(13, 142);
            this.partCat_cmbx.Name = "partCat_cmbx";
            this.partCat_cmbx.Size = new System.Drawing.Size(594, 28);
            this.partCat_cmbx.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Part ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Make:";
            // 
            // partPrice_txt
            // 
            this.partPrice_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partPrice_txt.Location = new System.Drawing.Point(13, 436);
            this.partPrice_txt.Name = "partPrice_txt";
            this.partPrice_txt.Size = new System.Drawing.Size(594, 27);
            this.partPrice_txt.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(12, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(621, 51);
            this.panel4.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(148, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 30);
            this.label10.TabIndex = 36;
            this.label10.Text = "MANAGE PARTS INVENTORY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.Controls.Add(this.addButton_btn);
            this.panel1.Location = new System.Drawing.Point(12, 835);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 60);
            this.panel1.TabIndex = 57;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.addQuantity_txt);
            this.guna2GroupBox1.Controls.Add(this.partModel_txt);
            this.guna2GroupBox1.Controls.Add(this.generate_btn);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.Controls.Add(this.showId_txt);
            this.guna2GroupBox1.Controls.Add(this.partId_txt);
            this.guna2GroupBox1.Controls.Add(this.partPrice_txt);
            this.guna2GroupBox1.Controls.Add(this.partNumber_txt);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.partName_txt);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.partCat_cmbx);
            this.guna2GroupBox1.Controls.Add(this.description_txt);
            this.guna2GroupBox1.Controls.Add(this.partAvailability_txt);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 80);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(621, 736);
            this.guna2GroupBox1.TabIndex = 56;
            this.guna2GroupBox1.Text = "MECHANIC INFORMATION";
            // 
            // partModel_txt
            // 
            this.partModel_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partModel_txt.FormattingEnabled = true;
            this.partModel_txt.Location = new System.Drawing.Point(14, 364);
            this.partModel_txt.Name = "partModel_txt";
            this.partModel_txt.Size = new System.Drawing.Size(594, 28);
            this.partModel_txt.TabIndex = 61;
            // 
            // generate_btn
            // 
            this.generate_btn.BorderRadius = 2;
            this.generate_btn.BorderThickness = 1;
            this.generate_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generate_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generate_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generate_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generate_btn.FillColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.generate_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_btn.ForeColor = System.Drawing.Color.White;
            this.generate_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.generate_btn.Location = new System.Drawing.Point(495, 74);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(112, 27);
            this.generate_btn.TabIndex = 60;
            this.generate_btn.Text = "GENERATE";
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(494, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.showAll_btn);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.filterCat_cmbx);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.searchPart_txt);
            this.panel3.Location = new System.Drawing.Point(649, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1053, 51);
            this.panel3.TabIndex = 59;
            // 
            // showAll_btn
            // 
            this.showAll_btn.BorderRadius = 2;
            this.showAll_btn.BorderThickness = 1;
            this.showAll_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showAll_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showAll_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAll_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showAll_btn.FillColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.showAll_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll_btn.ForeColor = System.Drawing.Color.White;
            this.showAll_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.showAll_btn.Location = new System.Drawing.Point(467, 13);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(108, 27);
            this.showAll_btn.TabIndex = 61;
            this.showAll_btn.Text = "SHOW ALL";
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(662, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Filter by Category:";
            // 
            // filterCat_cmbx
            // 
            this.filterCat_cmbx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCat_cmbx.FormattingEnabled = true;
            this.filterCat_cmbx.Location = new System.Drawing.Point(806, 13);
            this.filterCat_cmbx.Name = "filterCat_cmbx";
            this.filterCat_cmbx.Size = new System.Drawing.Size(233, 28);
            this.filterCat_cmbx.TabIndex = 56;
            this.filterCat_cmbx.SelectedIndexChanged += new System.EventHandler(this.filterCat_cmbx_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 55;
            this.label11.Text = "Search:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.partsDataGrid);
            this.panel2.Location = new System.Drawing.Point(649, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 815);
            this.panel2.TabIndex = 60;
            // 
            // addQuantity_txt
            // 
            this.addQuantity_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuantity_txt.Location = new System.Drawing.Point(338, 510);
            this.addQuantity_txt.Name = "addQuantity_txt";
            this.addQuantity_txt.Size = new System.Drawing.Size(269, 27);
            this.addQuantity_txt.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(334, 487);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "Add Quantity:";
            // 
            // InventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "InventoryManagementForm";
            this.Size = new System.Drawing.Size(1717, 909);
            this.Load += new System.EventHandler(this.InventoryManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView partsDataGrid;
        private System.Windows.Forms.TextBox showId_txt;
        private System.Windows.Forms.TextBox searchPart_txt;
        private Guna.UI2.WinForms.Guna2Button clear_btn;
        private System.Windows.Forms.TextBox partId_txt;
        private Guna.UI2.WinForms.Guna2Button update_btn;
        private System.Windows.Forms.TextBox partNumber_txt;
        private Guna.UI2.WinForms.Guna2Button addButton_btn;
        private System.Windows.Forms.TextBox partName_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partAvailability_txt;
        private System.Windows.Forms.ComboBox partCat_cmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partPrice_txt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button generate_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum_Availability;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.ComboBox partModel_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox filterCat_cmbx;
        private Guna.UI2.WinForms.Guna2Button showAll_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox addQuantity_txt;
    }
}
