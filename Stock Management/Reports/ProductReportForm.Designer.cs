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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductReport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.ColSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDealerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDealerBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSellingUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollBillDetails = new System.Windows.Forms.DataGridViewLinkColumn();
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
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSNo,
            this.ColProductName,
            this.ColDealerName,
            this.ColDealerBillDate,
            this.ColUnitPrice,
            this.ColSellingUnitPrice,
            this.ColTotalQuantity,
            this.ColAvailableQuantity,
            this.CollBillDetails});
            this.dgvProductReport.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProductReport.Location = new System.Drawing.Point(13, 56);
            this.dgvProductReport.MultiSelect = false;
            this.dgvProductReport.Name = "dgvProductReport";
            this.dgvProductReport.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProductReport.RowHeadersWidth = 21;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvProductReport.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductReport.Size = new System.Drawing.Size(759, 394);
            this.dgvProductReport.TabIndex = 0;
            this.dgvProductReport.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductReport_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(120, 15);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(282, 23);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyUp);
            // 
            // ColSNo
            // 
            this.ColSNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSNo.DataPropertyName = "SNo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColSNo.Frozen = true;
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
            // ColDealerName
            // 
            this.ColDealerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDealerName.DataPropertyName = "DealerName";
            this.ColDealerName.HeaderText = "Dealer";
            this.ColDealerName.MinimumWidth = 100;
            this.ColDealerName.Name = "ColDealerName";
            this.ColDealerName.ReadOnly = true;
            // 
            // ColDealerBillDate
            // 
            this.ColDealerBillDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColDealerBillDate.DataPropertyName = "DealerBillDate";
            this.ColDealerBillDate.FillWeight = 150F;
            this.ColDealerBillDate.HeaderText = "BillDate";
            this.ColDealerBillDate.MinimumWidth = 150;
            this.ColDealerBillDate.Name = "ColDealerBillDate";
            this.ColDealerBillDate.ReadOnly = true;
            this.ColDealerBillDate.Width = 150;
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUnitPrice.DataPropertyName = "DealerUnitPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColUnitPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColUnitPrice.HeaderText = "Unt Prc";
            this.ColUnitPrice.MinimumWidth = 100;
            this.ColUnitPrice.Name = "ColUnitPrice";
            this.ColUnitPrice.ReadOnly = true;
            this.ColUnitPrice.ToolTipText = "Unit Price";
            // 
            // ColSellingUnitPrice
            // 
            this.ColSellingUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSellingUnitPrice.DataPropertyName = "SellingUnitPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSellingUnitPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColSellingUnitPrice.HeaderText = "Sell Prc";
            this.ColSellingUnitPrice.MinimumWidth = 100;
            this.ColSellingUnitPrice.Name = "ColSellingUnitPrice";
            this.ColSellingUnitPrice.ReadOnly = true;
            this.ColSellingUnitPrice.ToolTipText = "Selling Price";
            // 
            // ColTotalQuantity
            // 
            this.ColTotalQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTotalQuantity.DataPropertyName = "TotalQuantity";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColTotalQuantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColTotalQuantity.HeaderText = "Tot Qty";
            this.ColTotalQuantity.MinimumWidth = 100;
            this.ColTotalQuantity.Name = "ColTotalQuantity";
            this.ColTotalQuantity.ReadOnly = true;
            this.ColTotalQuantity.ToolTipText = "Total Quantity";
            // 
            // ColAvailableQuantity
            // 
            this.ColAvailableQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColAvailableQuantity.DataPropertyName = "AvailableQuantity";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColAvailableQuantity.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColAvailableQuantity.HeaderText = "Avl Qty";
            this.ColAvailableQuantity.MinimumWidth = 100;
            this.ColAvailableQuantity.Name = "ColAvailableQuantity";
            this.ColAvailableQuantity.ReadOnly = true;
            this.ColAvailableQuantity.ToolTipText = "AvailableQuantity";
            // 
            // CollBillDetails
            // 
            this.CollBillDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CollBillDetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.CollBillDetails.FillWeight = 80F;
            this.CollBillDetails.HeaderText = "Show";
            this.CollBillDetails.MinimumWidth = 80;
            this.CollBillDetails.Name = "CollBillDetails";
            this.CollBillDetails.ReadOnly = true;
            this.CollBillDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CollBillDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CollBillDetails.Text = "Brkup";
            this.CollBillDetails.ToolTipText = "Show Bill";
            this.CollBillDetails.Visible = false;
            // 
            // ProductReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.dgvProductReport);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "ProductReportForm";
            this.Text = "Product Report";
            this.Load += new System.EventHandler(this.ProductReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDealerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDealerBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSellingUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAvailableQuantity;
        private System.Windows.Forms.DataGridViewLinkColumn CollBillDetails;
    }
}