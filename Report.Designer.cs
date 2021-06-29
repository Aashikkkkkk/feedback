namespace Feedback_System
{
    partial class Report
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
            this.customerReviewGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.adminPanel = new System.Windows.Forms.Button();
            this.SortUpBtn = new System.Windows.Forms.Button();
            this.sortDownBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerReviewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerReviewGrid
            // 
            this.customerReviewGrid.AllowUserToAddRows = false;
            this.customerReviewGrid.AllowUserToDeleteRows = false;
            this.customerReviewGrid.AllowUserToResizeColumns = false;
            this.customerReviewGrid.AllowUserToResizeRows = false;
            this.customerReviewGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.customerReviewGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerReviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customerReviewGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customerReviewGrid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.customerReviewGrid.Location = new System.Drawing.Point(18, 47);
            this.customerReviewGrid.MultiSelect = false;
            this.customerReviewGrid.Name = "customerReviewGrid";
            this.customerReviewGrid.ReadOnly = true;
            this.customerReviewGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customerReviewGrid.Size = new System.Drawing.Size(1250, 329);
            this.customerReviewGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Review";
            // 
            // adminPanel
            // 
            this.adminPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adminPanel.BackColor = System.Drawing.SystemColors.Window;
            this.adminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminPanel.Location = new System.Drawing.Point(1193, 397);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(75, 29);
            this.adminPanel.TabIndex = 10;
            this.adminPanel.Text = "ADMIN";
            this.adminPanel.UseVisualStyleBackColor = false;
            this.adminPanel.Click += new System.EventHandler(this.adminPanel_Click);
            // 
            // SortUpBtn
            // 
            this.SortUpBtn.BackColor = System.Drawing.SystemColors.Window;
            this.SortUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.SortUpBtn.Location = new System.Drawing.Point(64, 397);
            this.SortUpBtn.Name = "SortUpBtn";
            this.SortUpBtn.Size = new System.Drawing.Size(75, 29);
            this.SortUpBtn.TabIndex = 11;
            this.SortUpBtn.Text = "SORT ↑";
            this.SortUpBtn.UseVisualStyleBackColor = false;
            this.SortUpBtn.Click += new System.EventHandler(this.SortUpBtn_Click);
            // 
            // sortDownBtn
            // 
            this.sortDownBtn.BackColor = System.Drawing.SystemColors.Window;
            this.sortDownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.sortDownBtn.Location = new System.Drawing.Point(198, 397);
            this.sortDownBtn.Name = "sortDownBtn";
            this.sortDownBtn.Size = new System.Drawing.Size(75, 29);
            this.sortDownBtn.TabIndex = 12;
            this.sortDownBtn.Text = "SORT ↓";
            this.sortDownBtn.UseVisualStyleBackColor = false;
            this.sortDownBtn.Click += new System.EventHandler(this.sortDownBtn_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1287, 438);
            this.Controls.Add(this.sortDownBtn);
            this.Controls.Add(this.SortUpBtn);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerReviewGrid);
            this.MaximizeBox = false;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerReviewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerReviewGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminPanel;
        private System.Windows.Forms.Button SortUpBtn;
        private System.Windows.Forms.Button sortDownBtn;
    }
}