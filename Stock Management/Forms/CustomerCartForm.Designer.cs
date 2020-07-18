namespace Stock_Management.Forms
{
    partial class CustomerCartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlCustomerBillBreakup = new System.Windows.Forms.Panel();
            this.ColSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDealerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTAvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPriceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddToCart = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(12, 12);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(300, 23);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyUp);
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSNo,
            this.ColProductName,
            this.ColDealerName,
            this.ColBillDate,
            this.ColTotalQuantity,
            this.ColTAvailableQuantity,
            this.ColUnitPrice,
            this.ColUnitPriceCode,
            this.ColSellingPrice,
            this.ColAddToCart});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductList.Location = new System.Drawing.Point(11, 43);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(760, 155);
            this.dgvProductList.TabIndex = 0;
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvProductList);
            this.splitContainer1.Panel1.Controls.Add(this.txtProductName);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlCustomerBillBreakup);
            this.splitContainer1.Size = new System.Drawing.Size(784, 562);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 3;
            // 
            // pnlCustomerBillBreakup
            // 
            this.pnlCustomerBillBreakup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomerBillBreakup.Location = new System.Drawing.Point(-1, -3);
            this.pnlCustomerBillBreakup.Name = "pnlCustomerBillBreakup";
            this.pnlCustomerBillBreakup.Size = new System.Drawing.Size(784, 357);
            this.pnlCustomerBillBreakup.TabIndex = 20;
            // 
            // ColSNo
            // 
            this.ColSNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSNo.DataPropertyName = "SNo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColSNo.FillWeight = 50F;
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
            this.ColProductName.FillWeight = 150F;
            this.ColProductName.HeaderText = "Product Name";
            this.ColProductName.MinimumWidth = 150;
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.ReadOnly = true;
            // 
            // ColDealerName
            // 
            this.ColDealerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDealerName.DataPropertyName = "DealerName";
            this.ColDealerName.FillWeight = 150F;
            this.ColDealerName.HeaderText = "Dealer Name";
            this.ColDealerName.MinimumWidth = 10;
            this.ColDealerName.Name = "ColDealerName";
            this.ColDealerName.ReadOnly = true;
            // 
            // ColBillDate
            // 
            this.ColBillDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColBillDate.DataPropertyName = "DealerBillDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColBillDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColBillDate.FillWeight = 150F;
            this.ColBillDate.HeaderText = "Bill Date";
            this.ColBillDate.MinimumWidth = 150;
            this.ColBillDate.Name = "ColBillDate";
            this.ColBillDate.ReadOnly = true;
            this.ColBillDate.Width = 150;
            // 
            // ColTotalQuantity
            // 
            this.ColTotalQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTotalQuantity.DataPropertyName = "TotalQuantity";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColTotalQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColTotalQuantity.HeaderText = "Tot Qty";
            this.ColTotalQuantity.MinimumWidth = 100;
            this.ColTotalQuantity.Name = "ColTotalQuantity";
            this.ColTotalQuantity.ReadOnly = true;
            this.ColTotalQuantity.ToolTipText = "Total Quantity";
            // 
            // ColTAvailableQuantity
            // 
            this.ColTAvailableQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTAvailableQuantity.DataPropertyName = "AvailableQuantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColTAvailableQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColTAvailableQuantity.HeaderText = "Avl Qty";
            this.ColTAvailableQuantity.MinimumWidth = 100;
            this.ColTAvailableQuantity.Name = "ColTAvailableQuantity";
            this.ColTAvailableQuantity.ReadOnly = true;
            this.ColTAvailableQuantity.ToolTipText = "Available Quantity";
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUnitPrice.DataPropertyName = "DealerUnitPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColUnitPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColUnitPrice.HeaderText = "Unt Prc";
            this.ColUnitPrice.MinimumWidth = 100;
            this.ColUnitPrice.Name = "ColUnitPrice";
            this.ColUnitPrice.ReadOnly = true;
            this.ColUnitPrice.ToolTipText = "Unit Price";
            // 
            // ColUnitPriceCode
            // 
            this.ColUnitPriceCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUnitPriceCode.DataPropertyName = "DealerUnitPriceInCode";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColUnitPriceCode.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColUnitPriceCode.FillWeight = 120F;
            this.ColUnitPriceCode.HeaderText = "Unt Prc Cde";
            this.ColUnitPriceCode.MinimumWidth = 120;
            this.ColUnitPriceCode.Name = "ColUnitPriceCode";
            this.ColUnitPriceCode.ReadOnly = true;
            this.ColUnitPriceCode.ToolTipText = "Unit Price Code";
            this.ColUnitPriceCode.Width = 120;
            // 
            // ColSellingPrice
            // 
            this.ColSellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSellingPrice.DataPropertyName = "SellingUnitPrice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSellingPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColSellingPrice.FillWeight = 120F;
            this.ColSellingPrice.HeaderText = "Unt Sel Prc";
            this.ColSellingPrice.MinimumWidth = 120;
            this.ColSellingPrice.Name = "ColSellingPrice";
            this.ColSellingPrice.ReadOnly = true;
            this.ColSellingPrice.ToolTipText = "Unit Sell Price";
            this.ColSellingPrice.Width = 120;
            // 
            // ColAddToCart
            // 
            this.ColAddToCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColAddToCart.HeaderText = "Add to Cart";
            this.ColAddToCart.MinimumWidth = 100;
            this.ColAddToCart.Name = "ColAddToCart";
            this.ColAddToCart.ReadOnly = true;
            this.ColAddToCart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAddToCart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAddToCart.Text = "Add to Cart";
            this.ColAddToCart.Width = 150;
            // 
            // CustomerCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CustomerCartForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Customer Cart";
            this.Load += new System.EventHandler(this.SellForm_Load);
            this.Shown += new System.EventHandler(this.SellForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlCustomerBillBreakup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDealerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTAvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPriceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSellingPrice;
        private System.Windows.Forms.DataGridViewButtonColumn ColAddToCart;
    }
}