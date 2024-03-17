﻿
namespace CadizAutoShopManagementSystem.UserControlForms
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.partsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.mechanicChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.reservationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.statusChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicChart)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationChart)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusChart)).BeginInit();
            this.SuspendLayout();
            // 
            // partsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.partsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.partsChart.Legends.Add(legend1);
            this.partsChart.Location = new System.Drawing.Point(15, 42);
            this.partsChart.Name = "partsChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.partsChart.Series.Add(series1);
            this.partsChart.Size = new System.Drawing.Size(567, 291);
            this.partsChart.TabIndex = 4;
            this.partsChart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "PARTS";
            // 
            // mechanicChart
            // 
            chartArea2.Name = "ChartArea1";
            this.mechanicChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.mechanicChart.Legends.Add(legend2);
            this.mechanicChart.Location = new System.Drawing.Point(16, 42);
            this.mechanicChart.Name = "mechanicChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.mechanicChart.Series.Add(series2);
            this.mechanicChart.Size = new System.Drawing.Size(567, 291);
            this.mechanicChart.TabIndex = 6;
            this.mechanicChart.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "MECHANICS WORKING";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.reservationChart);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(179, 14);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(596, 348);
            this.guna2Panel1.TabIndex = 7;
            // 
            // reservationChart
            // 
            chartArea3.Name = "ChartArea1";
            this.reservationChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.reservationChart.Legends.Add(legend3);
            this.reservationChart.Location = new System.Drawing.Point(14, 43);
            this.reservationChart.Name = "reservationChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.reservationChart.Series.Add(series3);
            this.reservationChart.Size = new System.Drawing.Size(567, 291);
            this.reservationChart.TabIndex = 9;
            this.reservationChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(156, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "SERVICES ON RESERVATIONS";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.partsChart);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(179, 476);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(596, 348);
            this.guna2Panel2.TabIndex = 8;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.mechanicChart);
            this.guna2Panel3.Location = new System.Drawing.Point(915, 476);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(596, 348);
            this.guna2Panel3.TabIndex = 9;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Green;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.statusChart);
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.Location = new System.Drawing.Point(915, 14);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(596, 348);
            this.guna2Panel4.TabIndex = 10;
            // 
            // statusChart
            // 
            chartArea4.Name = "ChartArea1";
            this.statusChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.statusChart.Legends.Add(legend4);
            this.statusChart.Location = new System.Drawing.Point(16, 43);
            this.statusChart.Name = "statusChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.statusChart.Series.Add(series4);
            this.statusChart.Size = new System.Drawing.Size(567, 291);
            this.statusChart.TabIndex = 11;
            this.statusChart.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(200, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "RESERVATION STATUS";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "DashboardForm";
            this.Size = new System.Drawing.Size(1717, 909);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicChart)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationChart)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart partsChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart mechanicChart;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart reservationChart;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart statusChart;
        private System.Windows.Forms.Label label4;
    }
}
