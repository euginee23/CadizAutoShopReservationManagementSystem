﻿
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class SoldPartsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.partsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PartIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingQueue_btn = new Guna.UI2.WinForms.Guna2Button();
            this.filterPart_cmbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPart_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partId_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partNumber_txt = new System.Windows.Forms.TextBox();
            this.partName_txt = new System.Windows.Forms.TextBox();
            this.partModel_txt = new System.Windows.Forms.TextBox();
            this.partPrice_txt = new System.Windows.Forms.TextBox();
            this.partAvailability_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.minus_btn = new Guna.UI2.WinForms.Guna2Button();
            this.plus_btn = new Guna.UI2.WinForms.Guna2Button();
            this.totalPrice_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addToCart_btn = new Guna.UI2.WinForms.Guna2Button();
            this.cartDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartDeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.transactionId_txt = new System.Windows.Forms.TextBox();
            this.showAll_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // partsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.partsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.partsDataGridView.ColumnHeadersHeight = 15;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.partsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartIdColumn,
            this.PartNumberColumn,
            this.PartNameColumn,
            this.PartModelColumn,
            this.PriceColumn,
            this.AvailabilityColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.partsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.partsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.partsDataGridView.Location = new System.Drawing.Point(16, 59);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.ReadOnly = true;
            this.partsDataGridView.RowHeadersVisible = false;
            this.partsDataGridView.Size = new System.Drawing.Size(1195, 398);
            this.partsDataGridView.TabIndex = 0;
            this.partsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.partsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.partsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.partsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.partsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.partsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.partsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.partsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.partsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.partsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.partsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.partsDataGridView.ThemeStyle.HeaderStyle.Height = 15;
            this.partsDataGridView.ThemeStyle.ReadOnly = true;
            this.partsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.partsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.partsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.partsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.partsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.partsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.partsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getPartClick);
            // 
            // PartIdColumn
            // 
            this.PartIdColumn.DataPropertyName = "part_id";
            this.PartIdColumn.HeaderText = "PART ID";
            this.PartIdColumn.Name = "PartIdColumn";
            this.PartIdColumn.ReadOnly = true;
            // 
            // PartNumberColumn
            // 
            this.PartNumberColumn.DataPropertyName = "part_number";
            this.PartNumberColumn.HeaderText = "PART NUMBER";
            this.PartNumberColumn.Name = "PartNumberColumn";
            this.PartNumberColumn.ReadOnly = true;
            // 
            // PartNameColumn
            // 
            this.PartNameColumn.DataPropertyName = "part_name";
            this.PartNameColumn.HeaderText = "NAME";
            this.PartNameColumn.Name = "PartNameColumn";
            this.PartNameColumn.ReadOnly = true;
            // 
            // PartModelColumn
            // 
            this.PartModelColumn.DataPropertyName = "part_model";
            this.PartModelColumn.HeaderText = "MODEL";
            this.PartModelColumn.Name = "PartModelColumn";
            this.PartModelColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "price";
            this.PriceColumn.HeaderText = "PRICE";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // AvailabilityColumn
            // 
            this.AvailabilityColumn.DataPropertyName = "availability";
            this.AvailabilityColumn.HeaderText = "AVAILABILITY";
            this.AvailabilityColumn.Name = "AvailabilityColumn";
            this.AvailabilityColumn.ReadOnly = true;
            // 
            // billingQueue_btn
            // 
            this.billingQueue_btn.BorderRadius = 3;
            this.billingQueue_btn.BorderThickness = 1;
            this.billingQueue_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.billingQueue_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.billingQueue_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.billingQueue_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.billingQueue_btn.FillColor = System.Drawing.Color.Green;
            this.billingQueue_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingQueue_btn.ForeColor = System.Drawing.Color.White;
            this.billingQueue_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.billingQueue_btn.Location = new System.Drawing.Point(111, 18);
            this.billingQueue_btn.Name = "billingQueue_btn";
            this.billingQueue_btn.Size = new System.Drawing.Size(231, 42);
            this.billingQueue_btn.TabIndex = 8;
            this.billingQueue_btn.Text = "Add to Billing Queue";
            this.billingQueue_btn.Click += new System.EventHandler(this.billingQueue_btn_Click);
            // 
            // filterPart_cmbx
            // 
            this.filterPart_cmbx.BackColor = System.Drawing.Color.Transparent;
            this.filterPart_cmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterPart_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterPart_cmbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterPart_cmbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterPart_cmbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterPart_cmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filterPart_cmbx.ItemHeight = 30;
            this.filterPart_cmbx.Location = new System.Drawing.Point(953, 17);
            this.filterPart_cmbx.Name = "filterPart_cmbx";
            this.filterPart_cmbx.Size = new System.Drawing.Size(256, 36);
            this.filterPart_cmbx.TabIndex = 9;
            this.filterPart_cmbx.SelectedIndexChanged += new System.EventHandler(this.filterPart_cmbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(835, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter by Model:";
            // 
            // searchPart_txt
            // 
            this.searchPart_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchPart_txt.DefaultText = "";
            this.searchPart_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchPart_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchPart_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchPart_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchPart_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchPart_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchPart_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchPart_txt.Location = new System.Drawing.Point(72, 17);
            this.searchPart_txt.Name = "searchPart_txt";
            this.searchPart_txt.PasswordChar = '\0';
            this.searchPart_txt.PlaceholderText = "";
            this.searchPart_txt.SelectedText = "";
            this.searchPart_txt.Size = new System.Drawing.Size(421, 36);
            this.searchPart_txt.TabIndex = 11;
            this.searchPart_txt.TextChanged += new System.EventHandler(this.searchPart_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search:";
            // 
            // partId_txt
            // 
            this.partId_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partId_txt.Location = new System.Drawing.Point(17, 92);
            this.partId_txt.Name = "partId_txt";
            this.partId_txt.ReadOnly = true;
            this.partId_txt.Size = new System.Drawing.Size(798, 27);
            this.partId_txt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID:";
            // 
            // partNumber_txt
            // 
            this.partNumber_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumber_txt.Location = new System.Drawing.Point(17, 148);
            this.partNumber_txt.Name = "partNumber_txt";
            this.partNumber_txt.ReadOnly = true;
            this.partNumber_txt.Size = new System.Drawing.Size(798, 27);
            this.partNumber_txt.TabIndex = 13;
            // 
            // partName_txt
            // 
            this.partName_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partName_txt.Location = new System.Drawing.Point(17, 207);
            this.partName_txt.Name = "partName_txt";
            this.partName_txt.ReadOnly = true;
            this.partName_txt.Size = new System.Drawing.Size(798, 27);
            this.partName_txt.TabIndex = 13;
            // 
            // partModel_txt
            // 
            this.partModel_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partModel_txt.Location = new System.Drawing.Point(17, 264);
            this.partModel_txt.Name = "partModel_txt";
            this.partModel_txt.ReadOnly = true;
            this.partModel_txt.Size = new System.Drawing.Size(798, 27);
            this.partModel_txt.TabIndex = 13;
            // 
            // partPrice_txt
            // 
            this.partPrice_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partPrice_txt.Location = new System.Drawing.Point(17, 317);
            this.partPrice_txt.Name = "partPrice_txt";
            this.partPrice_txt.ReadOnly = true;
            this.partPrice_txt.Size = new System.Drawing.Size(365, 27);
            this.partPrice_txt.TabIndex = 13;
            // 
            // partAvailability_txt
            // 
            this.partAvailability_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partAvailability_txt.Location = new System.Drawing.Point(452, 317);
            this.partAvailability_txt.Name = "partAvailability_txt";
            this.partAvailability_txt.ReadOnly = true;
            this.partAvailability_txt.Size = new System.Drawing.Size(363, 27);
            this.partAvailability_txt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "NUMBER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "NAME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "MODEL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "PRICE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "AVAILABILITY:";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Controls.Add(this.label8);
            this.guna2GroupBox2.Controls.Add(this.partId_txt);
            this.guna2GroupBox2.Controls.Add(this.label7);
            this.guna2GroupBox2.Controls.Add(this.partNumber_txt);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.partName_txt);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.partModel_txt);
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.partPrice_txt);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.partAvailability_txt);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(14, 14);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(833, 391);
            this.guna2GroupBox2.TabIndex = 15;
            this.guna2GroupBox2.Text = "PART INFORMATION";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.minus_btn);
            this.guna2GroupBox1.Controls.Add(this.plus_btn);
            this.guna2GroupBox1.Controls.Add(this.totalPrice_txt);
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.quantity_txt);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(863, 14);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(381, 291);
            this.guna2GroupBox1.TabIndex = 16;
            this.guna2GroupBox1.Text = "SELL";
            // 
            // minus_btn
            // 
            this.minus_btn.BorderRadius = 3;
            this.minus_btn.BorderThickness = 1;
            this.minus_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minus_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minus_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minus_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minus_btn.FillColor = System.Drawing.SystemColors.HotTrack;
            this.minus_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus_btn.ForeColor = System.Drawing.Color.White;
            this.minus_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minus_btn.Location = new System.Drawing.Point(101, 82);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(36, 35);
            this.minus_btn.TabIndex = 35;
            this.minus_btn.Text = "-";
            this.minus_btn.Click += new System.EventHandler(this.minus_btn_Click);
            // 
            // plus_btn
            // 
            this.plus_btn.BorderRadius = 3;
            this.plus_btn.BorderThickness = 1;
            this.plus_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.plus_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.plus_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.plus_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.plus_btn.FillColor = System.Drawing.SystemColors.HotTrack;
            this.plus_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_btn.ForeColor = System.Drawing.Color.White;
            this.plus_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.plus_btn.Location = new System.Drawing.Point(249, 82);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(36, 35);
            this.plus_btn.TabIndex = 34;
            this.plus_btn.Text = "+";
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // totalPrice_txt
            // 
            this.totalPrice_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalPrice_txt.DefaultText = "";
            this.totalPrice_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalPrice_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalPrice_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalPrice_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalPrice_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalPrice_txt.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalPrice_txt.Location = new System.Drawing.Point(68, 176);
            this.totalPrice_txt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.totalPrice_txt.Name = "totalPrice_txt";
            this.totalPrice_txt.PasswordChar = '\0';
            this.totalPrice_txt.PlaceholderText = "";
            this.totalPrice_txt.SelectedText = "";
            this.totalPrice_txt.Size = new System.Drawing.Size(257, 97);
            this.totalPrice_txt.TabIndex = 33;
            this.totalPrice_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(152, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 30);
            this.label11.TabIndex = 14;
            this.label11.Text = "TOTAL:";
            // 
            // quantity_txt
            // 
            this.quantity_txt.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_txt.Location = new System.Drawing.Point(143, 75);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(100, 46);
            this.quantity_txt.TabIndex = 13;
            this.quantity_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(151, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "QUANTITY:";
            // 
            // addToCart_btn
            // 
            this.addToCart_btn.BorderRadius = 3;
            this.addToCart_btn.BorderThickness = 1;
            this.addToCart_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addToCart_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addToCart_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addToCart_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addToCart_btn.FillColor = System.Drawing.SystemColors.HotTrack;
            this.addToCart_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart_btn.ForeColor = System.Drawing.Color.White;
            this.addToCart_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addToCart_btn.Location = new System.Drawing.Point(101, 18);
            this.addToCart_btn.Name = "addToCart_btn";
            this.addToCart_btn.Size = new System.Drawing.Size(184, 42);
            this.addToCart_btn.TabIndex = 8;
            this.addToCart_btn.Text = "Add to Cart";
            this.addToCart_btn.Click += new System.EventHandler(this.addToCart_btn_Click);
            // 
            // cartDataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.cartDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.cartDataGridView.ColumnHeadersHeight = 15;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Quantity,
            this.TotalCost,
            this.cartDeleteColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.cartDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cartDataGridView.Location = new System.Drawing.Point(16, 46);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.RowHeadersVisible = false;
            this.cartDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartDataGridView.RowTemplate.Height = 40;
            this.cartDataGridView.Size = new System.Drawing.Size(418, 727);
            this.cartDataGridView.TabIndex = 17;
            this.cartDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.cartDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.cartDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.cartDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.cartDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.cartDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.cartDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cartDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cartDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cartDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.cartDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.cartDataGridView.ThemeStyle.HeaderStyle.Height = 15;
            this.cartDataGridView.ThemeStyle.ReadOnly = false;
            this.cartDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.cartDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cartDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.cartDataGridView.ThemeStyle.RowsStyle.Height = 40;
            this.cartDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cartDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.cartDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deletePart_ContentClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.FillWeight = 182.4319F;
            this.Column7.HeaderText = "Name";
            this.Column7.Name = "Column7";
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 62.22399F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // TotalCost
            // 
            this.TotalCost.FillWeight = 114.7349F;
            this.TotalCost.HeaderText = "Price";
            this.TotalCost.Name = "TotalCost";
            // 
            // cartDeleteColumn
            // 
            this.cartDeleteColumn.FillWeight = 40.60914F;
            this.cartDeleteColumn.HeaderText = "Delete";
            this.cartDeleteColumn.Name = "cartDeleteColumn";
            this.cartDeleteColumn.Text = "X";
            this.cartDeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "CART";
            // 
            // transactionId_txt
            // 
            this.transactionId_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionId_txt.Location = new System.Drawing.Point(203, 13);
            this.transactionId_txt.Name = "transactionId_txt";
            this.transactionId_txt.ReadOnly = true;
            this.transactionId_txt.Size = new System.Drawing.Size(231, 27);
            this.transactionId_txt.TabIndex = 19;
            // 
            // showAll_btn
            // 
            this.showAll_btn.BorderRadius = 3;
            this.showAll_btn.BorderThickness = 1;
            this.showAll_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showAll_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showAll_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAll_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showAll_btn.FillColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.showAll_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll_btn.ForeColor = System.Drawing.Color.White;
            this.showAll_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.showAll_btn.Location = new System.Drawing.Point(500, 17);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(122, 36);
            this.showAll_btn.TabIndex = 21;
            this.showAll_btn.Text = "SHOW ALL";
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.cartDataGridView);
            this.panel4.Controls.Add(this.transactionId_txt);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(1259, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 787);
            this.panel4.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(173, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.billingQueue_btn);
            this.panel1.Location = new System.Drawing.Point(1259, 817);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 78);
            this.panel1.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.searchPart_txt);
            this.panel2.Controls.Add(this.showAll_btn);
            this.panel2.Controls.Add(this.filterPart_cmbx);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.partsDataGridView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1229, 472);
            this.panel2.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.addToCart_btn);
            this.panel3.Location = new System.Drawing.Point(863, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 78);
            this.panel3.TabIndex = 62;
            // 
            // SoldPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "SoldPartsForm";
            this.Size = new System.Drawing.Size(1717, 909);
            this.Load += new System.EventHandler(this.SoldPartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView partsDataGridView;
        private Guna.UI2.WinForms.Guna2Button billingQueue_btn;
        private Guna.UI2.WinForms.Guna2ComboBox filterPart_cmbx;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox searchPart_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partId_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partNumber_txt;
        private System.Windows.Forms.TextBox partName_txt;
        private System.Windows.Forms.TextBox partModel_txt;
        private System.Windows.Forms.TextBox partPrice_txt;
        private System.Windows.Forms.TextBox partAvailability_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox totalPrice_txt;
        private Guna.UI2.WinForms.Guna2Button addToCart_btn;
        private Guna.UI2.WinForms.Guna2DataGridView cartDataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailabilityColumn;
        private System.Windows.Forms.TextBox transactionId_txt;
        private Guna.UI2.WinForms.Guna2Button showAll_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewButtonColumn cartDeleteColumn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button minus_btn;
        private Guna.UI2.WinForms.Guna2Button plus_btn;
    }
}
