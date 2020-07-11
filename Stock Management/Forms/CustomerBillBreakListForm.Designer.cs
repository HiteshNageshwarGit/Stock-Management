namespace Stock_Management.Forms
{
    partial class CustomerBillBreakListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalProductQuantityInCart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFinishBilling = new System.Windows.Forms.Button();
            this.txtTotalProductCountInCart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalBillAmountForCart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.CartColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColUnitPticeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColUnitSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColProductQuantityInCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColAddOne = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CartColRemoveOne = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CartColTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Location = new System.Drawing.Point(381, 17);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(88, 28);
            this.btnSearchCustomer.TabIndex = 31;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(478, 22);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(185, 64);
            this.txtRemarks.TabIndex = 30;
            this.txtRemarks.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Remarks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Customer Name";
            // 
            // txtTotalProductQuantityInCart
            // 
            this.txtTotalProductQuantityInCart.Enabled = false;
            this.txtTotalProductQuantityInCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProductQuantityInCart.Location = new System.Drawing.Point(11, 20);
            this.txtTotalProductQuantityInCart.Name = "txtTotalProductQuantityInCart";
            this.txtTotalProductQuantityInCart.Size = new System.Drawing.Size(105, 23);
            this.txtTotalProductQuantityInCart.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total Quantity";
            // 
            // btnFinishBilling
            // 
            this.btnFinishBilling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinishBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishBilling.Location = new System.Drawing.Point(746, 26);
            this.btnFinishBilling.Name = "btnFinishBilling";
            this.btnFinishBilling.Size = new System.Drawing.Size(67, 38);
            this.btnFinishBilling.TabIndex = 25;
            this.btnFinishBilling.Text = "Finish";
            this.btnFinishBilling.UseVisualStyleBackColor = true;
            this.btnFinishBilling.Click += new System.EventHandler(this.btnFinishBilling_Click);
            // 
            // txtTotalProductCountInCart
            // 
            this.txtTotalProductCountInCart.Enabled = false;
            this.txtTotalProductCountInCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProductCountInCart.Location = new System.Drawing.Point(11, 63);
            this.txtTotalProductCountInCart.Name = "txtTotalProductCountInCart";
            this.txtTotalProductCountInCart.Size = new System.Drawing.Size(104, 23);
            this.txtTotalProductCountInCart.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total Product Count";
            // 
            // txtTotalBillAmountForCart
            // 
            this.txtTotalBillAmountForCart.Enabled = false;
            this.txtTotalBillAmountForCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBillAmountForCart.Location = new System.Drawing.Point(192, 65);
            this.txtTotalBillAmountForCart.Name = "txtTotalBillAmountForCart";
            this.txtTotalBillAmountForCart.Size = new System.Drawing.Size(183, 23);
            this.txtTotalBillAmountForCart.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total Amount";
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.Location = new System.Drawing.Point(12, 94);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(810, 506);
            this.dgvCart.TabIndex = 20;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            this.dgvCart.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellEndEdit);
            this.dgvCart.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCart_EditingControlShowing);
            // 
            // CartColProductName
            // 
            this.CartColProductName.DataPropertyName = "ProductName";
            this.CartColProductName.FillWeight = 200F;
            this.CartColProductName.HeaderText = "Product Name";
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose;
            this.CartColUnitSellPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.CartColUnitSellPrice.HeaderText = "Unt Sell Price";
            this.CartColUnitSellPrice.MaxInputLength = 9999;
            this.CartColUnitSellPrice.Name = "CartColUnitSellPrice";
            // 
            // CartColTotalQuantity
            // 
            this.CartColTotalQuantity.DataPropertyName = "AvailableQuantity";
            this.CartColTotalQuantity.FillWeight = 50F;
            this.CartColTotalQuantity.HeaderText = "Avlble Qty";
            this.CartColTotalQuantity.Name = "CartColTotalQuantity";
            this.CartColTotalQuantity.ReadOnly = true;
            // 
            // CartColProductQuantityInCart
            // 
            this.CartColProductQuantityInCart.DataPropertyName = "SellingQuantity";
            this.CartColProductQuantityInCart.FillWeight = 50F;
            this.CartColProductQuantityInCart.HeaderText = "Qty In Cart";
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
            this.CartColTotalAmount.HeaderText = "Total";
            this.CartColTotalAmount.Name = "CartColTotalAmount";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(191, 21);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(184, 23);
            this.txtCustomerName.TabIndex = 32;
            // 
            // CustomerBillBreakListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalProductQuantityInCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFinishBilling);
            this.Controls.Add(this.txtTotalProductCountInCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalBillAmountForCart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCart);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CustomerBillBreakListForm";
            this.Text = "CustomerCartForm";
            this.Load += new System.EventHandler(this.CustomerBillBreakListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.RichTextBox txtRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalProductQuantityInCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFinishBilling;
        private System.Windows.Forms.TextBox txtTotalProductCountInCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalBillAmountForCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.TextBox txtCustomerName;
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