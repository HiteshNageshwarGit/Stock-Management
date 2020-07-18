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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductReport = new System.Windows.Forms.DataGridView();
            this.ColSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductReport
            // 
            this.dgvProductReport.AllowUserToAddRows = false;
            this.dgvProductReport.AllowUserToDeleteRows = false;
            this.dgvProductReport.AllowUserToOrderColumns = true;
            this.dgvProductReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            this.dgvProductReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSNo,
            this.ColProductName,
            this.ColUnitPrice,
            this.ColAvailableQuantity});
            this.dgvProductReport.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProductReport.Location = new System.Drawing.Point(13, 13);
            this.dgvProductReport.MultiSelect = false;
            this.dgvProductReport.Name = "dgvProductReport";
            this.dgvProductReport.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductReport.RowHeadersWidth = 21;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvProductReport.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductReport.Size = new System.Drawing.Size(775, 425);
            this.dgvProductReport.TabIndex = 0;
            this.dgvProductReport.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ColSNo
            // 
            this.ColSNo.DataPropertyName = "SNo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColSNo.HeaderText = "S.No.";
            this.ColSNo.MinimumWidth = 50;
            this.ColSNo.Name = "ColSNo";
            this.ColSNo.ReadOnly = true;
            this.ColSNo.Width = 50;
            // 
            // ColProductName
            // 
            this.ColProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColProductName.DataPropertyName = "ProductName";
            this.ColProductName.HeaderText = "Product Name";
            this.ColProductName.MinimumWidth = 200;
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.ReadOnly = true;
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColUnitPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColUnitPrice.HeaderText = "Unit Price";
            this.ColUnitPrice.MinimumWidth = 100;
            this.ColUnitPrice.Name = "ColUnitPrice";
            this.ColUnitPrice.ReadOnly = true;
            // 
            // ColAvailableQuantity
            // 
            this.ColAvailableQuantity.DataPropertyName = "AvailableQuantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColAvailableQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColAvailableQuantity.HeaderText = "Avl Qty";
            this.ColAvailableQuantity.MinimumWidth = 100;
            this.ColAvailableQuantity.Name = "ColAvailableQuantity";
            this.ColAvailableQuantity.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAvailableQuantity;
    }
}