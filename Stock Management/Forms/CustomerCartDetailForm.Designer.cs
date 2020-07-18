namespace Stock_Management.Forms
{
    partial class CustomerCartDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFindCustomer = new System.Windows.Forms.Button();
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.ColSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColUnitPticeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColUnitSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColProductQuantityInCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartColAddOne = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CartColRemoveOne = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CartColTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCustomer.Location = new System.Drawing.Point(381, 17);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(88, 28);
            this.btnFindCustomer.TabIndex = 31;
            this.btnFindCustomer.Text = "&Find";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
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
            this.btnFinishBilling.Location = new System.Drawing.Point(725, 26);
            this.btnFinishBilling.Name = "btnFinishBilling";
            this.btnFinishBilling.Size = new System.Drawing.Size(88, 38);
            this.btnFinishBilling.TabIndex = 25;
            this.btnFinishBilling.Text = "Fini&sh";
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
            this.ColSNo,
            this.CartColProductName,
            this.CartColUnitPrice,
            this.CartColUnitPticeCode,
            this.CartColUnitSellPrice,
            this.CartColTotalQuantity,
            this.CartColProductQuantityInCart,
            this.CartColAddOne,
            this.CartColRemoveOne,
            this.CartColTotalAmount});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCart.Location = new System.Drawing.Point(12, 94);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(810, 506);
            this.dgvCart.TabIndex = 20;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            this.dgvCart.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellEndEdit);
            this.dgvCart.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCart_EditingControlShowing);
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
            // CartColProductName
            // 
            this.CartColProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CartColProductName.DataPropertyName = "ProductName";
            this.CartColProductName.FillWeight = 250F;
            this.CartColProductName.HeaderText = "Product Name";
            this.CartColProductName.MinimumWidth = 250;
            this.CartColProductName.Name = "CartColProductName";
            this.CartColProductName.ReadOnly = true;
            // 
            // CartColUnitPrice
            // 
            this.CartColUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CartColUnitPrice.DataPropertyName = "DealerUnitPrice";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CartColUnitPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.CartColUnitPrice.HeaderText = "Unt Prc";
            this.CartColUnitPrice.MinimumWidth = 100;
            this.CartColUnitPrice.Name = "CartColUnitPrice";
            this.CartColUnitPrice.ReadOnly = true;
            this.CartColUnitPrice.ToolTipText = "Unit Price";
            // 
            // CartColUnitPticeCode
            // 
            this.CartColUnitPticeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CartColUnitPticeCode.DataPropertyName = "DealerUnitPriceInCode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CartColUnitPticeCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.CartColUnitPticeCode.FillWeight = 120F;
            this.CartColUnitPticeCode.HeaderText = "Unt Prc Cde";
            this.CartColUnitPticeCode.MinimumWidth = 120;
            this.CartColUnitPticeCode.Name = "CartColUnitPticeCode";
            this.CartColUnitPticeCode.ReadOnly = true;
            this.CartColUnitPticeCode.ToolTipText = "Unit Price Code";
            this.CartColUnitPticeCode.Width = 120;
            // 
            // CartColUnitSellPrice
            // 
            this.CartColUnitSellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CartColUnitSellPrice.DataPropertyName = "SellingUnitPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.CartColUnitSellPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.CartColUnitSellPrice.FillWeight = 120F;
            this.CartColUnitSellPrice.HeaderText = "Unt Sel Prc";
            this.CartColUnitSellPrice.MaxInputLength = 9999;
            this.CartColUnitSellPrice.MinimumWidth = 120;
            this.CartColUnitSellPrice.Name = "CartColUnitSellPrice";
            this.CartColUnitSellPrice.ToolTipText = "Unit Sell Price";
            this.CartColUnitSellPrice.Width = 120;
            // 
            // CartColTotalQuantity
            // 
            this.CartColTotalQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CartColTotalQuantity.DataPropertyName = "AvailableQuantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CartColTotalQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.CartColTotalQuantity.HeaderText = "Avl Qty";
            this.CartColTotalQuantity.MinimumWidth = 100;
            this.CartColTotalQuantity.Name = "CartColTotalQuantity";
            this.CartColTotalQuantity.ReadOnly = true;
            this.CartColTotalQuantity.ToolTipText = "Available Quantity";
            // 
            // CartColProductQuantityInCart
            // 
            this.CartColProductQuantityInCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CartColProductQuantityInCart.DataPropertyName = "SellingQuantity";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.CartColProductQuantityInCart.DefaultCellStyle = dataGridViewCellStyle6;
            this.CartColProductQuantityInCart.FillWeight = 120F;
            this.CartColProductQuantityInCart.HeaderText = "Qty In Cart";
            this.CartColProductQuantityInCart.MinimumWidth = 120;
            this.CartColProductQuantityInCart.Name = "CartColProductQuantityInCart";
            this.CartColProductQuantityInCart.ToolTipText = "Quantity In Cart";
            this.CartColProductQuantityInCart.Width = 120;
            // 
            // CartColAddOne
            // 
            this.CartColAddOne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartColAddOne.DefaultCellStyle = dataGridViewCellStyle7;
            this.CartColAddOne.FillWeight = 60F;
            this.CartColAddOne.HeaderText = "Add";
            this.CartColAddOne.MinimumWidth = 60;
            this.CartColAddOne.Name = "CartColAddOne";
            this.CartColAddOne.ReadOnly = true;
            this.CartColAddOne.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CartColAddOne.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CartColAddOne.Text = "+";
            this.CartColAddOne.Width = 60;
            // 
            // CartColRemoveOne
            // 
            this.CartColRemoveOne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CartColRemoveOne.FillWeight = 70F;
            this.CartColRemoveOne.HeaderText = "Remove";
            this.CartColRemoveOne.MinimumWidth = 70;
            this.CartColRemoveOne.Name = "CartColRemoveOne";
            this.CartColRemoveOne.ReadOnly = true;
            this.CartColRemoveOne.Text = "-";
            this.CartColRemoveOne.Width = 70;
            // 
            // CartColTotalAmount
            // 
            this.CartColTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CartColTotalAmount.DataPropertyName = "SellingAmount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CartColTotalAmount.DefaultCellStyle = dataGridViewCellStyle8;
            this.CartColTotalAmount.HeaderText = "Total";
            this.CartColTotalAmount.MinimumWidth = 100;
            this.CartColTotalAmount.Name = "CartColTotalAmount";
            // 
            // CustomerCartDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnFindCustomer);
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
            this.Name = "CustomerCartDetailForm";
            this.Text = "CustomerCartForm";
            this.Load += new System.EventHandler(this.CustomerBillBreakListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindCustomer;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSNo;
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