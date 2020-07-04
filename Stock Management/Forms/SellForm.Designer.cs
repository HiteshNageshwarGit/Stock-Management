namespace Stock_Management.Forms
{
    partial class SellForm
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTotalProductQuantityInCart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFinishBilling = new System.Windows.Forms.Button();
            this.txtTotalProductCountInCart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalBillAmountForCart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDealerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTAvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPriceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddToCart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CartColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColUnitPticeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColUnitSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColProductQuantityInCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColAddOne = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CartColRemoveOne = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CartColTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
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
            this.ColProductName,
            this.ColDealerName,
            this.ColBillDate,
            this.ColTotalQuantity,
            this.ColTAvailableQuantity,
            this.ColUnitPrice,
            this.ColUnitPriceCode,
            this.ColSellingPrice,
            this.ColAddToCart});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductList.Location = new System.Drawing.Point(0, 43);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(882, 155);
            this.dgvProductList.TabIndex = 0;
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CartColProductName,
            this.CartColUnitPrice,
            this.CartColUnitPticeCode,
            this.CartColUnitSellPrice,
            this.CartColTotalQuantity,
            this.CartColProductQuantityInCart,
            this.CartColAddOne,
            this.CartColRemoveOne,
            this.CartColTotalAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.Location = new System.Drawing.Point(0, 62);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(882, 292);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            this.dgvCart.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCart_EditingControlShowing);
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtTotalProductQuantityInCart);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnFinishBilling);
            this.splitContainer1.Panel2.Controls.Add(this.txtTotalProductCountInCart);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtTotalBillAmountForCart);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.dgvCart);
            this.splitContainer1.Size = new System.Drawing.Size(884, 562);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 3;
            // 
            // txtTotalProductQuantityInCart
            // 
            this.txtTotalProductQuantityInCart.Enabled = false;
            this.txtTotalProductQuantityInCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProductQuantityInCart.Location = new System.Drawing.Point(635, 24);
            this.txtTotalProductQuantityInCart.Name = "txtTotalProductQuantityInCart";
            this.txtTotalProductQuantityInCart.Size = new System.Drawing.Size(69, 23);
            this.txtTotalProductQuantityInCart.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Product Count";
            // 
            // btnFinishBilling
            // 
            this.btnFinishBilling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinishBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishBilling.Location = new System.Drawing.Point(771, 20);
            this.btnFinishBilling.Name = "btnFinishBilling";
            this.btnFinishBilling.Size = new System.Drawing.Size(88, 28);
            this.btnFinishBilling.TabIndex = 12;
            this.btnFinishBilling.Text = "Finish";
            this.btnFinishBilling.UseVisualStyleBackColor = true;
            this.btnFinishBilling.Click += new System.EventHandler(this.btnFinishBilling_Click);
            // 
            // txtTotalProductCountInCart
            // 
            this.txtTotalProductCountInCart.Enabled = false;
            this.txtTotalProductCountInCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProductCountInCart.Location = new System.Drawing.Point(382, 24);
            this.txtTotalProductCountInCart.Name = "txtTotalProductCountInCart";
            this.txtTotalProductCountInCart.Size = new System.Drawing.Size(75, 23);
            this.txtTotalProductCountInCart.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Product Count";
            // 
            // txtTotalBillAmountForCart
            // 
            this.txtTotalBillAmountForCart.Enabled = false;
            this.txtTotalBillAmountForCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBillAmountForCart.Location = new System.Drawing.Point(113, 24);
            this.txtTotalBillAmountForCart.Name = "txtTotalBillAmountForCart";
            this.txtTotalBillAmountForCart.Size = new System.Drawing.Size(104, 23);
            this.txtTotalBillAmountForCart.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Amount";
            // 
            // ColProductName
            // 
            this.ColProductName.DataPropertyName = "ProductName";
            this.ColProductName.FillWeight = 200F;
            this.ColProductName.HeaderText = "Product NAme";
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.ReadOnly = true;
            // 
            // ColDealerName
            // 
            this.ColDealerName.DataPropertyName = "DealerName";
            this.ColDealerName.FillWeight = 200F;
            this.ColDealerName.HeaderText = "Dealer Name";
            this.ColDealerName.Name = "ColDealerName";
            this.ColDealerName.ReadOnly = true;
            // 
            // ColBillDate
            // 
            this.ColBillDate.DataPropertyName = "DealerBillDate";
            this.ColBillDate.HeaderText = "Bill Date";
            this.ColBillDate.Name = "ColBillDate";
            this.ColBillDate.ReadOnly = true;
            // 
            // ColTotalQuantity
            // 
            this.ColTotalQuantity.DataPropertyName = "TotalQuantity";
            this.ColTotalQuantity.HeaderText = "Total Quantity";
            this.ColTotalQuantity.Name = "ColTotalQuantity";
            this.ColTotalQuantity.ReadOnly = true;
            // 
            // ColTAvailableQuantity
            // 
            this.ColTAvailableQuantity.DataPropertyName = "AvailableQuantity";
            this.ColTAvailableQuantity.HeaderText = "Availble Quantity";
            this.ColTAvailableQuantity.Name = "ColTAvailableQuantity";
            this.ColTAvailableQuantity.ReadOnly = true;
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.DataPropertyName = "DealerUnitPrice";
            this.ColUnitPrice.HeaderText = "Unit Price";
            this.ColUnitPrice.Name = "ColUnitPrice";
            this.ColUnitPrice.ReadOnly = true;
            // 
            // ColUnitPriceCode
            // 
            this.ColUnitPriceCode.DataPropertyName = "DealerUnitPriceInCode";
            this.ColUnitPriceCode.HeaderText = "Unit Price Code";
            this.ColUnitPriceCode.Name = "ColUnitPriceCode";
            this.ColUnitPriceCode.ReadOnly = true;
            // 
            // ColSellingPrice
            // 
            this.ColSellingPrice.DataPropertyName = "SellingUnitPrice";
            this.ColSellingPrice.HeaderText = "Unit Selling Price";
            this.ColSellingPrice.Name = "ColSellingPrice";
            this.ColSellingPrice.ReadOnly = true;
            // 
            // ColAddToCart
            // 
            this.ColAddToCart.HeaderText = "Add to Cart";
            this.ColAddToCart.Name = "ColAddToCart";
            this.ColAddToCart.ReadOnly = true;
            this.ColAddToCart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAddToCart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAddToCart.Text = "Add to Cart";
            // 
            // CartColProductName
            // 
            this.CartColProductName.DataPropertyName = "ProductName";
            this.CartColProductName.FillWeight = 200F;
            this.CartColProductName.HeaderText = "Product NAme";
            this.CartColProductName.Name = "CartColProductName";
            this.CartColProductName.ReadOnly = true;
            // 
            // CartColUnitPrice
            // 
            this.CartColUnitPrice.DataPropertyName = "DealerUnitPrice";
            this.CartColUnitPrice.HeaderText = "Unit Price";
            this.CartColUnitPrice.Name = "CartColUnitPrice";
            this.CartColUnitPrice.ReadOnly = true;
            // 
            // CartColUnitPticeCode
            // 
            this.CartColUnitPticeCode.DataPropertyName = "DealerUnitPriceInCode";
            this.CartColUnitPticeCode.HeaderText = "Unit Price Code";
            this.CartColUnitPticeCode.Name = "CartColUnitPticeCode";
            this.CartColUnitPticeCode.ReadOnly = true;
            // 
            // CartColUnitSellPrice
            // 
            this.CartColUnitSellPrice.DataPropertyName = "SellingUnitPrice";
            this.CartColUnitSellPrice.HeaderText = "Unit Selling Price";
            this.CartColUnitSellPrice.Name = "CartColUnitSellPrice";
            // 
            // CartColTotalQuantity
            // 
            this.CartColTotalQuantity.DataPropertyName = "AvailableQuantity";
            this.CartColTotalQuantity.HeaderText = "Available Quantity";
            this.CartColTotalQuantity.Name = "CartColTotalQuantity";
            this.CartColTotalQuantity.ReadOnly = true;
            // 
            // CartColProductQuantityInCart
            // 
            this.CartColProductQuantityInCart.DataPropertyName = "SellingQuantity";
            this.CartColProductQuantityInCart.FillWeight = 50F;
            this.CartColProductQuantityInCart.HeaderText = "Quantity In Cart";
            this.CartColProductQuantityInCart.Name = "CartColProductQuantityInCart";
            // 
            // CartColAddOne
            // 
            this.CartColAddOne.FillWeight = 50F;
            this.CartColAddOne.HeaderText = "Add";
            this.CartColAddOne.Name = "CartColAddOne";
            this.CartColAddOne.ReadOnly = true;
            this.CartColAddOne.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CartColAddOne.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CartColAddOne.Text = "+";
            // 
            // CartColRemoveOne
            // 
            this.CartColRemoveOne.FillWeight = 50F;
            this.CartColRemoveOne.HeaderText = "Remove";
            this.CartColRemoveOne.Name = "CartColRemoveOne";
            this.CartColRemoveOne.ReadOnly = true;
            this.CartColRemoveOne.Text = "-";
            // 
            // CartColTotalAmount
            // 
            this.CartColTotalAmount.DataPropertyName = "SellingAmount";
            this.CartColTotalAmount.FillWeight = 50F;
            this.CartColTotalAmount.HeaderText = "Total";
            this.CartColTotalAmount.Name = "CartColTotalAmount";
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "SellForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Sell";
            this.Load += new System.EventHandler(this.SellForm_Load);
            this.Shown += new System.EventHandler(this.SellForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtTotalProductCountInCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalBillAmountForCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinishBilling;
        private System.Windows.Forms.TextBox txtTotalProductQuantityInCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDealerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTAvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPriceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSellingPrice;
        private System.Windows.Forms.DataGridViewButtonColumn ColAddToCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartColUnitPticeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartColUnitSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartColTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartColProductQuantityInCart;
        private System.Windows.Forms.DataGridViewButtonColumn CartColAddOne;
        private System.Windows.Forms.DataGridViewButtonColumn CartColRemoveOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartColTotalAmount;
    }
}