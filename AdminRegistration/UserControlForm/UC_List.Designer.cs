
namespace AdminRegistration.UserControlForm
{
    partial class UC_List
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
            this.adminInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.userInfo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.adminInfoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // adminInfoDataGrid
            // 
            this.adminInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminInfoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userInfo_id,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.RemoveColumn});
            this.adminInfoDataGrid.Location = new System.Drawing.Point(35, 43);
            this.adminInfoDataGrid.Name = "adminInfoDataGrid";
            this.adminInfoDataGrid.RowHeadersVisible = false;
            this.adminInfoDataGrid.Size = new System.Drawing.Size(776, 645);
            this.adminInfoDataGrid.TabIndex = 66;
            this.adminInfoDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminInfoDataGrid_CellContentClick);
            // 
            // userInfo_id
            // 
            this.userInfo_id.DataPropertyName = "userInfo_id";
            this.userInfo_id.HeaderText = "ID";
            this.userInfo_id.Name = "userInfo_id";
            this.userInfo_id.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "firstName";
            this.Column2.HeaderText = "FIRST NAME";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "lastName";
            this.Column3.HeaderText = "LAST NAME";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "contactNumber";
            this.Column4.HeaderText = "CONTACT #";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "address";
            this.Column5.HeaderText = "ADDRESS";
            this.Column5.Name = "Column5";
            // 
            // RemoveColumn
            // 
            this.RemoveColumn.HeaderText = "REMOVE";
            this.RemoveColumn.Name = "RemoveColumn";
            this.RemoveColumn.Text = "X";
            this.RemoveColumn.UseColumnTextForButtonValue = true;
            this.RemoveColumn.Width = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(19, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 678);
            this.panel1.TabIndex = 67;
            // 
            // UC_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminInfoDataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "UC_List";
            this.Size = new System.Drawing.Size(850, 720);
            ((System.ComponentModel.ISupportInitialize)(this.adminInfoDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adminInfoDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn userInfo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveColumn;
        private System.Windows.Forms.Panel panel1;
    }
}
