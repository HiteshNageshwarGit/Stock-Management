namespace Stock_Management.Forms
{
    partial class DealerBillBreakupListForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBillBreakup = new System.Windows.Forms.Button();
            this.dgvBillBreakupList = new System.Windows.Forms.DataGridView();
            this.grpBoxBrakupCount = new System.Windows.Forms.GroupBox();
            this.ColSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantityInBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillBreakupList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAddBillBreakup);
            this.groupBox2.Controls.Add(this.dgvBillBreakupList);
            this.groupBox2.Location = new System.Drawing.Point(13, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 476);
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
            this.dgvBillBreakupList.AllowUserToOrderColumns = true;
            this.dgvBillBreakupList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillBreakupList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillBreakupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillBreakupList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSNo,
            this.ColProduct,
            this.ColTotalAmount,
            this.ColQuantityInBox,
            this.Col,
            this.ColTotalQuantity,
            this.ColUnitPrice,
            this.ColUnitSellingPrice,
            this.ColDetail});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillBreakupList.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBillBreakupList.Location = new System.Drawing.Point(6, 53);
            this.dgvBillBreakupList.Name = "dgvBillBreakupList";
            this.dgvBillBreakupList.ReadOnly = true;
            this.dgvBillBreakupList.RowHeadersVisible = false;
            this.dgvBillBreakupList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillBreakupList.Size = new System.Drawing.Size(727, 417);
            this.dgvBillBreakupList.TabIndex = 0;
            this.dgvBillBreakupList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillBreakupList_CellContentClick);
            // 
            // grpBoxBrakupCount
            // 
            this.grpBoxBrakupCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxBrakupCount.Location = new System.Drawing.Point(12, 12);
            this.grpBoxBrakupCount.Name = "grpBoxBrakupCount";
            this.grpBoxBrakupCount.Size = new System.Drawing.Size(734, 122);
            this.grpBoxBrakupCount.TabIndex = 5;
            this.grpBoxBrakupCount.TabStop = false;
            this.grpBoxBrakupCount.Text = "Dealer And Bill Details";
            // 
            // ColSNo
            // 
            this.ColSNo.DataPropertyName = "SNo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColSNo.FillWeight = 80F;
            this.ColSNo.HeaderText = "S.No.";
            this.ColSNo.MinimumWidth = 80;
            this.ColSNo.Name = "ColSNo";
            this.ColSNo.ReadOnly = true;
            // 
            // ColProduct
            // 
            this.ColProduct.DataPropertyName = "Product";
            this.ColProduct.FillWeight = 350F;
            this.ColProduct.HeaderText = "Product Name";
            this.ColProduct.MinimumWidth = 250;
            this.ColProduct.Name = "ColProduct";
            this.ColProduct.ReadOnly = true;
            // 
            // ColTotalAmount
            // 
            this.ColTotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColTotalAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColTotalAmount.FillWeight = 80F;
            this.ColTotalAmount.HeaderText = "Total Amount";
            this.ColTotalAmount.MinimumWidth = 80;
            this.ColTotalAmount.Name = "ColTotalAmount";
            this.ColTotalAmount.ReadOnly = true;
            // 
            // ColQuantityInBox
            // 
            this.ColQuantityInBox.DataPropertyName = "QuantityInBox";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColQuantityInBox.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColQuantityInBox.FillWeight = 80F;
            this.ColQuantityInBox.HeaderText = "Quantity In Box";
            this.ColQuantityInBox.MinimumWidth = 80;
            this.ColQuantityInBox.Name = "ColQuantityInBox";
            this.ColQuantityInBox.ReadOnly = true;
            // 
            // Col
            // 
            this.Col.DataPropertyName = "TotalBoxes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col.DefaultCellStyle = dataGridViewCellStyle4;
            this.Col.FillWeight = 80F;
            this.Col.HeaderText = "Total Boxes";
            this.Col.MinimumWidth = 80;
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            // 
            // ColTotalQuantity
            // 
            this.ColTotalQuantity.DataPropertyName = "TotalQuantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColTotalQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColTotalQuantity.FillWeight = 80F;
            this.ColTotalQuantity.HeaderText = "Total Quantity";
            this.ColTotalQuantity.MinimumWidth = 80;
            this.ColTotalQuantity.Name = "ColTotalQuantity";
            this.ColTotalQuantity.ReadOnly = true;
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColUnitPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColUnitPrice.FillWeight = 80F;
            this.ColUnitPrice.HeaderText = "Unit Price";
            this.ColUnitPrice.MinimumWidth = 80;
            this.ColUnitPrice.Name = "ColUnitPrice";
            this.ColUnitPrice.ReadOnly = true;
            // 
            // ColUnitSellingPrice
            // 
            this.ColUnitSellingPrice.DataPropertyName = "UnitSellPrice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColUnitSellingPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColUnitSellingPrice.FillWeight = 80F;
            this.ColUnitSellingPrice.HeaderText = "Sell Price";
            this.ColUnitSellingPrice.MinimumWidth = 80;
            this.ColUnitSellingPrice.Name = "ColUnitSellingPrice";
            this.ColUnitSellingPrice.ReadOnly = true;
            // 
            // ColDetail
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDetail.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColDetail.FillWeight = 80F;
            this.ColDetail.HeaderText = "Action";
            this.ColDetail.MinimumWidth = 80;
            this.ColDetail.Name = "ColDetail";
            this.ColDetail.ReadOnly = true;
            this.ColDetail.Text = "Details";
            // 
            // DealerBillBreakupListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 642);
            this.Controls.Add(this.grpBoxBrakupCount);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "DealerBillBreakupListForm";
            this.Text = "Dealer Bill Breakup List";
            this.Load += new System.EventHandler(this.BillBreakupListForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillBreakupList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBillBreakupList;
        private System.Windows.Forms.Button btnAddBillBreakup;
        private System.Windows.Forms.GroupBox grpBoxBrakupCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSNo;
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