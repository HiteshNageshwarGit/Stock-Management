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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBillBreakup = new System.Windows.Forms.Button();
            this.dgvBillBreakupList = new System.Windows.Forms.DataGridView();
            this.ColSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantityInBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.grpBoxBrakupCount = new System.Windows.Forms.GroupBox();
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
            this.ColTotalQuantity,
            this.ColAvailableQuantity,
            this.ColUnitPrice,
            this.ColUnitSellingPrice,
            this.Col,
            this.ColQuantityInBox,
            this.ColDetail});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillBreakupList.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBillBreakupList.Location = new System.Drawing.Point(6, 53);
            this.dgvBillBreakupList.Name = "dgvBillBreakupList";
            this.dgvBillBreakupList.ReadOnly = true;
            this.dgvBillBreakupList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillBreakupList.Size = new System.Drawing.Size(727, 417);
            this.dgvBillBreakupList.TabIndex = 0;
            this.dgvBillBreakupList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillBreakupList_CellContentClick);
            this.dgvBillBreakupList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBillBreakupList_CellFormatting);
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
            this.ColTotalAmount.HeaderText = "Tot Amnt";
            this.ColTotalAmount.MinimumWidth = 80;
            this.ColTotalAmount.Name = "ColTotalAmount";
            this.ColTotalAmount.ReadOnly = true;
            this.ColTotalAmount.ToolTipText = "Total Amount";
            // 
            // ColTotalQuantity
            // 
            this.ColTotalQuantity.DataPropertyName = "TotalQuantity";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColTotalQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColTotalQuantity.FillWeight = 80F;
            this.ColTotalQuantity.HeaderText = "Tot Qty";
            this.ColTotalQuantity.MinimumWidth = 80;
            this.ColTotalQuantity.Name = "ColTotalQuantity";
            this.ColTotalQuantity.ReadOnly = true;
            this.ColTotalQuantity.ToolTipText = "Total Quantity";
            // 
            // ColAvailableQuantity
            // 
            this.ColAvailableQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColAvailableQuantity.DataPropertyName = "AvailableQuantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColAvailableQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColAvailableQuantity.FillWeight = 90F;
            this.ColAvailableQuantity.HeaderText = "Avl Qty";
            this.ColAvailableQuantity.MinimumWidth = 90;
            this.ColAvailableQuantity.Name = "ColAvailableQuantity";
            this.ColAvailableQuantity.ReadOnly = true;
            this.ColAvailableQuantity.ToolTipText = "Available Quantity";
            this.ColAvailableQuantity.Width = 90;
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColUnitPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColUnitPrice.FillWeight = 80F;
            this.ColUnitPrice.HeaderText = "Unt Prc";
            this.ColUnitPrice.MinimumWidth = 80;
            this.ColUnitPrice.Name = "ColUnitPrice";
            this.ColUnitPrice.ReadOnly = true;
            this.ColUnitPrice.ToolTipText = "Unit Price";
            // 
            // ColUnitSellingPrice
            // 
            this.ColUnitSellingPrice.DataPropertyName = "UnitSellPrice";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColUnitSellingPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColUnitSellingPrice.FillWeight = 80F;
            this.ColUnitSellingPrice.HeaderText = "Sell Prc";
            this.ColUnitSellingPrice.MinimumWidth = 80;
            this.ColUnitSellingPrice.Name = "ColUnitSellingPrice";
            this.ColUnitSellingPrice.ReadOnly = true;
            this.ColUnitSellingPrice.ToolTipText = "Sell Price";
            // 
            // Col
            // 
            this.Col.DataPropertyName = "TotalBoxes";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col.DefaultCellStyle = dataGridViewCellStyle7;
            this.Col.FillWeight = 80F;
            this.Col.HeaderText = "Tot Bxs";
            this.Col.MinimumWidth = 80;
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.ToolTipText = "Total Boxes";
            // 
            // ColQuantityInBox
            // 
            this.ColQuantityInBox.DataPropertyName = "QuantityInBox";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColQuantityInBox.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColQuantityInBox.FillWeight = 80F;
            this.ColQuantityInBox.HeaderText = "Qty in Bx ";
            this.ColQuantityInBox.MinimumWidth = 80;
            this.ColQuantityInBox.Name = "ColQuantityInBox";
            this.ColQuantityInBox.ReadOnly = true;
            this.ColQuantityInBox.ToolTipText = "Quantity In Box";
            // 
            // ColDetail
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDetail.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColDetail.FillWeight = 80F;
            this.ColDetail.HeaderText = "Action";
            this.ColDetail.MinimumWidth = 80;
            this.ColDetail.Name = "ColDetail";
            this.ColDetail.ReadOnly = true;
            this.ColDetail.Text = "Details";
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DealerBillBreakupListForm_FormClosing);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantityInBox;
        private System.Windows.Forms.DataGridViewLinkColumn ColDetail;
    }
}