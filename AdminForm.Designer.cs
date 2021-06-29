namespace Feedback_System
{
    partial class AdminForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.btnCriteria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GridAdmin = new System.Windows.Forms.DataGridView();
            this.adminBtn = new System.Windows.Forms.Button();
            this.ReportAdmin = new System.Windows.Forms.Button();
            this.homeAdmin = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.overAllReportGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comChart = new System.Windows.Forms.ComboBox();
            this.criteriaSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overAllReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Panel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtCriteria);
            this.panel1.Controls.Add(this.btnCriteria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 113);
            this.panel1.TabIndex = 3;
            // 
            // txtCriteria
            // 
            this.txtCriteria.AutoCompleteCustomSource.AddRange(new string[] {
            "Food Quality",
            "Cleanliness",
            "Value Of Money",
            "Staff Friendliness",
            "Restaurant Ambiance"});
            this.txtCriteria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCriteria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriteria.Location = new System.Drawing.Point(127, 22);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(249, 29);
            this.txtCriteria.TabIndex = 7;
            this.txtCriteria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCriteria_KeyPress);
            // 
            // btnCriteria
            // 
            this.btnCriteria.BackColor = System.Drawing.SystemColors.Window;
            this.btnCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCriteria.Location = new System.Drawing.Point(127, 71);
            this.btnCriteria.Name = "btnCriteria";
            this.btnCriteria.Size = new System.Drawing.Size(75, 23);
            this.btnCriteria.TabIndex = 6;
            this.btnCriteria.Text = "ADD";
            this.btnCriteria.UseVisualStyleBackColor = false;
            this.btnCriteria.Click += new System.EventHandler(this.btnCriteria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criteria";
            // 
            // GridAdmin
            // 
            this.GridAdmin.AllowUserToAddRows = false;
            this.GridAdmin.AllowUserToDeleteRows = false;
            this.GridAdmin.AllowUserToResizeColumns = false;
            this.GridAdmin.AllowUserToResizeRows = false;
            this.GridAdmin.BackgroundColor = System.Drawing.Color.Snow;
            this.GridAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAdmin.Location = new System.Drawing.Point(12, 175);
            this.GridAdmin.Name = "GridAdmin";
            this.GridAdmin.ReadOnly = true;
            this.GridAdmin.Size = new System.Drawing.Size(402, 184);
            this.GridAdmin.TabIndex = 4;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.SystemColors.Window;
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminBtn.Location = new System.Drawing.Point(168, 376);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(75, 23);
            this.adminBtn.TabIndex = 5;
            this.adminBtn.Text = "DONE";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click_1);
            // 
            // ReportAdmin
            // 
            this.ReportAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.ReportAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ReportAdmin.Location = new System.Drawing.Point(1087, 373);
            this.ReportAdmin.Name = "ReportAdmin";
            this.ReportAdmin.Size = new System.Drawing.Size(166, 23);
            this.ReportAdmin.TabIndex = 6;
            this.ReportAdmin.Text = "REPORT DETAIL";
            this.ReportAdmin.UseVisualStyleBackColor = false;
            this.ReportAdmin.Click += new System.EventHandler(this.ReportAdmin_Click);
            // 
            // homeAdmin
            // 
            this.homeAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.homeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.homeAdmin.Location = new System.Drawing.Point(1378, 373);
            this.homeAdmin.Name = "homeAdmin";
            this.homeAdmin.Size = new System.Drawing.Size(75, 23);
            this.homeAdmin.TabIndex = 9;
            this.homeAdmin.Text = "HOME";
            this.homeAdmin.UseVisualStyleBackColor = false;
            this.homeAdmin.Click += new System.EventHandler(this.homeAdmin_Click_1);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(437, 44);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.SystemColors.ActiveBorder;
            series1.Legend = "Legend1";
            series1.Name = "Customers";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(619, 315);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "Rating";
            // 
            // overAllReportGrid
            // 
            this.overAllReportGrid.AllowUserToAddRows = false;
            this.overAllReportGrid.AllowUserToDeleteRows = false;
            this.overAllReportGrid.AllowUserToResizeColumns = false;
            this.overAllReportGrid.AllowUserToResizeRows = false;
            this.overAllReportGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.overAllReportGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.overAllReportGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.overAllReportGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.overAllReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overAllReportGrid.Location = new System.Drawing.Point(1087, 106);
            this.overAllReportGrid.Name = "overAllReportGrid";
            this.overAllReportGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.overAllReportGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.overAllReportGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overAllReportGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.overAllReportGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.overAllReportGrid.Size = new System.Drawing.Size(366, 133);
            this.overAllReportGrid.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1082, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Report";
            // 
            // comChart
            // 
            this.comChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comChart.FormattingEnabled = true;
            this.comChart.Items.AddRange(new object[] {
            "Food Quality",
            "Staff Friendliness",
            "Restaurant Ambiance",
            "Value Of Money",
            "Order Accuracy",
            "Cleanliness"});
            this.comChart.Location = new System.Drawing.Point(527, 373);
            this.comChart.Name = "comChart";
            this.comChart.Size = new System.Drawing.Size(201, 26);
            this.comChart.TabIndex = 13;
            // 
            // criteriaSearch
            // 
            this.criteriaSearch.BackColor = System.Drawing.SystemColors.Window;
            this.criteriaSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.criteriaSearch.Location = new System.Drawing.Point(770, 374);
            this.criteriaSearch.Name = "criteriaSearch";
            this.criteriaSearch.Size = new System.Drawing.Size(92, 26);
            this.criteriaSearch.TabIndex = 14;
            this.criteriaSearch.Text = "SEARCH";
            this.criteriaSearch.UseVisualStyleBackColor = false;
            this.criteriaSearch.Click += new System.EventHandler(this.criteriaSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choose Criteria:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1489, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.criteriaSearch);
            this.Controls.Add(this.comChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.overAllReportGrid);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.GridAdmin);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.homeAdmin);
            this.Controls.Add(this.ReportAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overAllReportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridAdmin;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button btnCriteria;
        private System.Windows.Forms.Button ReportAdmin;
        private System.Windows.Forms.Button homeAdmin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.DataGridView overAllReportGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comChart;
        private System.Windows.Forms.Button criteriaSearch;
        private System.Windows.Forms.Label label4;
    }
}