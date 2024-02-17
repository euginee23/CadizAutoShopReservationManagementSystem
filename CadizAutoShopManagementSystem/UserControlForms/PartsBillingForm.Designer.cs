
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class PartsBillingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.billingPanelContainer = new System.Windows.Forms.Panel();
            this.back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.partsBillingDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.transactionSelectDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.invoice_btn = new Guna.UI2.WinForms.Guna2Button();
            this.totalCost_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionId_txt = new System.Windows.Forms.TextBox();
            this.transaction_idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.reservationId_txt = new System.Windows.Forms.TextBox();
            this.customerName_txt = new System.Windows.Forms.TextBox();
            this.billingId_txt = new System.Windows.Forms.TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_costColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingPanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsBillingDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionSelectDataGrid)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // billingPanelContainer
            // 
            this.billingPanelContainer.Controls.Add(this.label4);
            this.billingPanelContainer.Controls.Add(this.invoice_btn);
            this.billingPanelContainer.Controls.Add(this.totalCost_txt);
            this.billingPanelContainer.Controls.Add(this.label7);
            this.billingPanelContainer.Controls.Add(this.transactionId_txt);
            this.billingPanelContainer.Controls.Add(this.textBox7);
            this.billingPanelContainer.Controls.Add(this.label1);
            this.billingPanelContainer.Controls.Add(this.label8);
            this.billingPanelContainer.Controls.Add(this.transactionSelectDataGrid);
            this.billingPanelContainer.Controls.Add(this.partsBillingDataGrid);
            this.billingPanelContainer.Controls.Add(this.back_btn);
            this.billingPanelContainer.Controls.Add(this.guna2GroupBox1);
            this.billingPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.billingPanelContainer.Name = "billingPanelContainer";
            this.billingPanelContainer.Size = new System.Drawing.Size(1251, 744);
            this.billingPanelContainer.TabIndex = 0;
            this.billingPanelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.billingPanelContainer_Paint);
            // 
            // back_btn
            // 
            this.back_btn.BorderRadius = 10;
            this.back_btn.BorderThickness = 1;
            this.back_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(3, 3);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(78, 32);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "← Back";
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // partsBillingDataGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.partsBillingDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partsBillingDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.partsBillingDataGrid.ColumnHeadersHeight = 15;
            this.partsBillingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.partsBillingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.total_costColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.partsBillingDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.partsBillingDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.partsBillingDataGrid.Location = new System.Drawing.Point(431, 295);
            this.partsBillingDataGrid.Name = "partsBillingDataGrid";
            this.partsBillingDataGrid.RowHeadersVisible = false;
            this.partsBillingDataGrid.Size = new System.Drawing.Size(805, 436);
            this.partsBillingDataGrid.TabIndex = 6;
            this.partsBillingDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.partsBillingDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.partsBillingDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.partsBillingDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.partsBillingDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.partsBillingDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.partsBillingDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.partsBillingDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.partsBillingDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.partsBillingDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsBillingDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.partsBillingDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.partsBillingDataGrid.ThemeStyle.HeaderStyle.Height = 15;
            this.partsBillingDataGrid.ThemeStyle.ReadOnly = false;
            this.partsBillingDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.partsBillingDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.partsBillingDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsBillingDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.partsBillingDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.partsBillingDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.partsBillingDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // transactionSelectDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.transactionSelectDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionSelectDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.transactionSelectDataGrid.ColumnHeadersHeight = 15;
            this.transactionSelectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.transactionSelectDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transaction_idColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transactionSelectDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.transactionSelectDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.transactionSelectDataGrid.Location = new System.Drawing.Point(20, 295);
            this.transactionSelectDataGrid.Name = "transactionSelectDataGrid";
            this.transactionSelectDataGrid.RowHeadersVisible = false;
            this.transactionSelectDataGrid.Size = new System.Drawing.Size(381, 436);
            this.transactionSelectDataGrid.TabIndex = 7;
            this.transactionSelectDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.transactionSelectDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.transactionSelectDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.transactionSelectDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.transactionSelectDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.transactionSelectDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.transactionSelectDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.transactionSelectDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.transactionSelectDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.transactionSelectDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionSelectDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.transactionSelectDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.transactionSelectDataGrid.ThemeStyle.HeaderStyle.Height = 15;
            this.transactionSelectDataGrid.ThemeStyle.ReadOnly = false;
            this.transactionSelectDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.transactionSelectDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.transactionSelectDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionSelectDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.transactionSelectDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.transactionSelectDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.transactionSelectDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.transactionSelectDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getTransactionID_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "SEARCH:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(81, 264);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(320, 25);
            this.textBox7.TabIndex = 38;
            // 
            // invoice_btn
            // 
            this.invoice_btn.BorderRadius = 12;
            this.invoice_btn.BorderThickness = 1;
            this.invoice_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.invoice_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.invoice_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.invoice_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.invoice_btn.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.invoice_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice_btn.ForeColor = System.Drawing.Color.White;
            this.invoice_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.invoice_btn.Location = new System.Drawing.Point(892, 182);
            this.invoice_btn.Name = "invoice_btn";
            this.invoice_btn.Size = new System.Drawing.Size(227, 45);
            this.invoice_btn.TabIndex = 43;
            this.invoice_btn.Text = "INVOICE";
            // 
            // totalCost_txt
            // 
            this.totalCost_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalCost_txt.DefaultText = "";
            this.totalCost_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalCost_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalCost_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalCost_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalCost_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalCost_txt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalCost_txt.Location = new System.Drawing.Point(878, 75);
            this.totalCost_txt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.totalCost_txt.Name = "totalCost_txt";
            this.totalCost_txt.PasswordChar = '\0';
            this.totalCost_txt.PlaceholderText = "";
            this.totalCost_txt.ReadOnly = true;
            this.totalCost_txt.SelectedText = "";
            this.totalCost_txt.Size = new System.Drawing.Size(257, 97);
            this.totalCost_txt.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(783, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "TOTAL COST:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(759, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "TRANSACTION ID:";
            // 
            // transactionId_txt
            // 
            this.transactionId_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionId_txt.Location = new System.Drawing.Point(878, 43);
            this.transactionId_txt.Name = "transactionId_txt";
            this.transactionId_txt.ReadOnly = true;
            this.transactionId_txt.Size = new System.Drawing.Size(257, 25);
            this.transactionId_txt.TabIndex = 44;
            this.transactionId_txt.TextChanged += new System.EventHandler(this.getPartsByTransactionID);
            // 
            // transaction_idColumn
            // 
            this.transaction_idColumn.DataPropertyName = "transaction_id";
            this.transaction_idColumn.HeaderText = "SELECT TRANSACTION IDENTIFICATION";
            this.transaction_idColumn.Name = "transaction_idColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "ADDRESS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "LAST NAME:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "FIRST NAME:";
            // 
            // reservationId_txt
            // 
            this.reservationId_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationId_txt.Location = new System.Drawing.Point(135, 90);
            this.reservationId_txt.Name = "reservationId_txt";
            this.reservationId_txt.Size = new System.Drawing.Size(493, 25);
            this.reservationId_txt.TabIndex = 49;
            // 
            // customerName_txt
            // 
            this.customerName_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName_txt.Location = new System.Drawing.Point(135, 121);
            this.customerName_txt.Name = "customerName_txt";
            this.customerName_txt.Size = new System.Drawing.Size(493, 25);
            this.customerName_txt.TabIndex = 50;
            // 
            // billingId_txt
            // 
            this.billingId_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingId_txt.Location = new System.Drawing.Point(135, 59);
            this.billingId_txt.Name = "billingId_txt";
            this.billingId_txt.Size = new System.Drawing.Size(493, 25);
            this.billingId_txt.TabIndex = 51;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.billingId_txt);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.reservationId_txt);
            this.guna2GroupBox1.Controls.Add(this.customerName_txt);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(20, 43);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(662, 184);
            this.guna2GroupBox1.TabIndex = 58;
            this.guna2GroupBox1.Text = "ENTER CUSTOMER / BUYER INFO FOR RECEIPT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 59;
            this.label4.Text = "CART:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PartId";
            this.Column1.HeaderText = "PART ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PartName";
            this.Column2.HeaderText = "PART NAME";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Quantity";
            this.Column3.HeaderText = "QUANTITY ";
            this.Column3.Name = "Column3";
            // 
            // total_costColumn
            // 
            this.total_costColumn.DataPropertyName = "TotalCost";
            this.total_costColumn.HeaderText = "TOTAL COST";
            this.total_costColumn.Name = "total_costColumn";
            // 
            // PartsBillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.billingPanelContainer);
            this.Name = "PartsBillingForm";
            this.Size = new System.Drawing.Size(1251, 744);
            this.billingPanelContainer.ResumeLayout(false);
            this.billingPanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsBillingDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionSelectDataGrid)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel billingPanelContainer;
        private Guna.UI2.WinForms.Guna2Button back_btn;
        private Guna.UI2.WinForms.Guna2DataGridView partsBillingDataGrid;
        private Guna.UI2.WinForms.Guna2DataGridView transactionSelectDataGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private Guna.UI2.WinForms.Guna2Button invoice_btn;
        private Guna.UI2.WinForms.Guna2TextBox totalCost_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox transactionId_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_idColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox reservationId_txt;
        private System.Windows.Forms.TextBox customerName_txt;
        private System.Windows.Forms.TextBox billingId_txt;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_costColumn;
    }
}
