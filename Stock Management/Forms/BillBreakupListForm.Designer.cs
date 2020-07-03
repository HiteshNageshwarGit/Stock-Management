namespace Stock_Management.Forms
{
    partial class BillBreakupListForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBillBreakup = new System.Windows.Forms.Button();
            this.dgvBillBreakupList = new System.Windows.Forms.DataGridView();
            this.ColProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantityInBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBillDate = new System.Windows.Forms.TextBox();
            this.txtTotalBillAmount = new System.Windows.Forms.TextBox();
            this.txtTotalBreakupCount = new System.Windows.Forms.TextBox();
            this.txtTotalBreakupAmount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillBreakupList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAddBillBreakup);
            this.groupBox2.Controls.Add(this.dgvBillBreakupList);
            this.groupBox2.Location = new System.Drawing.Point(13, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 407);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill Breakup";
            // 
            // btnAddBillBreakup
            // 
            this.btnAddBillBreakup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBillBreakup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBillBreakup.Location = new System.Drawing.Point(603, 16);
            this.btnAddBillBreakup.Name = "btnAddBillBreakup";
            this.btnAddBillBreakup.Size = new System.Drawing.Size(130, 28);
            this.btnAddBillBreakup.TabIndex = 1;
            this.btnAddBillBreakup.Text = "Add Breakup";
            this.btnAddBillBreakup.UseVisualStyleBackColor = true;
            this.btnAddBillBreakup.Click += new System.EventHandler(this.btnAddBillBreakup_Click);
            // 
            // dgvBillBreakupList
            // 
            this.dgvBillBreakupList.AllowUserToAddRows = false;
            this.dgvBillBreakupList.AllowUserToDeleteRows = false;
            this.dgvBillBreakupList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillBreakupList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillBreakupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillBreakupList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProduct,
            this.ColTotalAmount,
            this.ColQuantityInBox,
            this.Col,
            this.ColTotalQuantity,
            this.ColUnitPrice,
            this.ColUnitSellingPrice,
            this.ColDetail});
            this.dgvBillBreakupList.Location = new System.Drawing.Point(6, 53);
            this.dgvBillBreakupList.Name = "dgvBillBreakupList";
            this.dgvBillBreakupList.ReadOnly = true;
            this.dgvBillBreakupList.RowHeadersVisible = false;
            this.dgvBillBreakupList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillBreakupList.Size = new System.Drawing.Size(727, 348);
            this.dgvBillBreakupList.TabIndex = 0;
            this.dgvBillBreakupList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillBreakupList_CellContentClick);
            // 
            // ColProduct
            // 
            this.ColProduct.DataPropertyName = "Product";
            this.ColProduct.FillWeight = 3F;
            this.ColProduct.HeaderText = "Product";
            this.ColProduct.Name = "ColProduct";
            this.ColProduct.ReadOnly = true;
            // 
            // ColTotalAmount
            // 
            this.ColTotalAmount.DataPropertyName = "TotalAmount";
            this.ColTotalAmount.FillWeight = 1F;
            this.ColTotalAmount.HeaderText = "Total Amount";
            this.ColTotalAmount.Name = "ColTotalAmount";
            this.ColTotalAmount.ReadOnly = true;
            // 
            // ColQuantityInBox
            // 
            this.ColQuantityInBox.DataPropertyName = "QuantityInBox";
            this.ColQuantityInBox.FillWeight = 1F;
            this.ColQuantityInBox.HeaderText = "Quantity In Box";
            this.ColQuantityInBox.Name = "ColQuantityInBox";
            this.ColQuantityInBox.ReadOnly = true;
            // 
            // Col
            // 
            this.Col.DataPropertyName = "TotalBoxes";
            this.Col.FillWeight = 1F;
            this.Col.HeaderText = "Total Boxes";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            // 
            // ColTotalQuantity
            // 
            this.ColTotalQuantity.DataPropertyName = "TotalQuantity";
            this.ColTotalQuantity.FillWeight = 1F;
            this.ColTotalQuantity.HeaderText = "Total Quantity";
            this.ColTotalQuantity.Name = "ColTotalQuantity";
            this.ColTotalQuantity.ReadOnly = true;
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.DataPropertyName = "UnitPrice";
            this.ColUnitPrice.FillWeight = 1F;
            this.ColUnitPrice.HeaderText = "Unit Price";
            this.ColUnitPrice.Name = "ColUnitPrice";
            this.ColUnitPrice.ReadOnly = true;
            // 
            // ColUnitSellingPrice
            // 
            this.ColUnitSellingPrice.DataPropertyName = "UnitSellPrice";
            this.ColUnitSellingPrice.FillWeight = 1F;
            this.ColUnitSellingPrice.HeaderText = "Sell Price";
            this.ColUnitSellingPrice.Name = "ColUnitSellingPrice";
            this.ColUnitSellingPrice.ReadOnly = true;
            // 
            // ColDetail
            // 
            this.ColDetail.FillWeight = 1F;
            this.ColDetail.HeaderText = "Action";
            this.ColDetail.Name = "ColDetail";
            this.ColDetail.ReadOnly = true;
            this.ColDetail.Text = "Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dealer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "No. Of Breakups";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bill Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bill Amount";
            // 
            // txtDealerName
            // 
            this.txtDealerName.Enabled = false;
            this.txtDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerName.Location = new System.Drawing.Point(100, 24);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(224, 23);
            this.txtDealerName.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(344, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "Total Breakup Amount";
            // 
            // txtBillDate
            // 
            this.txtBillDate.Enabled = false;
            this.txtBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillDate.Location = new System.Drawing.Point(100, 53);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.Size = new System.Drawing.Size(224, 23);
            this.txtBillDate.TabIndex = 13;
            // 
            // txtTotalBillAmount
            // 
            this.txtTotalBillAmount.Enabled = false;
            this.txtTotalBillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBillAmount.Location = new System.Drawing.Point(100, 82);
            this.txtTotalBillAmount.Name = "txtTotalBillAmount";
            this.txtTotalBillAmount.Size = new System.Drawing.Size(224, 23);
            this.txtTotalBillAmount.TabIndex = 14;
            // 
            // txtTotalBreakupCount
            // 
            this.txtTotalBreakupCount.Enabled = false;
            this.txtTotalBreakupCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBreakupCount.Location = new System.Drawing.Point(517, 21);
            this.txtTotalBreakupCount.Name = "txtTotalBreakupCount";
            this.txtTotalBreakupCount.Size = new System.Drawing.Size(137, 23);
            this.txtTotalBreakupCount.TabIndex = 15;
            // 
            // txtTotalBreakupAmount
            // 
            this.txtTotalBreakupAmount.Enabled = false;
            this.txtTotalBreakupAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBreakupAmount.Location = new System.Drawing.Point(517, 50);
            this.txtTotalBreakupAmount.Name = "txtTotalBreakupAmount";
            this.txtTotalBreakupAmount.Size = new System.Drawing.Size(137, 23);
            this.txtTotalBreakupAmount.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRemarks);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtTotalBreakupAmount);
            this.groupBox3.Controls.Add(this.txtTotalBreakupCount);
            this.groupBox3.Controls.Add(this.txtTotalBillAmount);
            this.groupBox3.Controls.Add(this.txtBillDate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtDealerName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 209);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dealer And Bill Details";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Enabled = false;
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(100, 120);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(554, 60);
            this.txtRemarks.TabIndex = 19;
            this.txtRemarks.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bill Remarks";
            // 
            // BillBreakupListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 642);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "BillBreakupListForm";
            this.Text = "Bill Breakup List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillBreakupListForm_FormClosing);
            this.Load += new System.EventHandler(this.BillBreakupListForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillBreakupList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBillBreakupList;
        private System.Windows.Forms.Button btnAddBillBreakup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBillDate;
        private System.Windows.Forms.TextBox txtTotalBillAmount;
        private System.Windows.Forms.TextBox txtTotalBreakupCount;
        private System.Windows.Forms.TextBox txtTotalBreakupAmount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtRemarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantityInBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitSellingPrice;
        private System.Windows.Forms.DataGridViewLinkColumn ColDetail;
    }
}