namespace Stock_Management.Forms
{
    partial class ProductReportForm
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
            this.dgvProductReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductReport
            // 
            this.dgvProductReport.AllowUserToAddRows = false;
            this.dgvProductReport.AllowUserToDeleteRows = false;
            this.dgvProductReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductReport.Location = new System.Drawing.Point(12, 12);
            this.dgvProductReport.Name = "dgvProductReport";
            this.dgvProductReport.ReadOnly = true;
            this.dgvProductReport.Size = new System.Drawing.Size(776, 426);
            this.dgvProductReport.TabIndex = 0;
            // 
            // ProductReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProductReport);
            this.Name = "ProductReportForm";
            this.Text = "Product Report";
            this.Load += new System.EventHandler(this.ProductReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductReport;
    }
}