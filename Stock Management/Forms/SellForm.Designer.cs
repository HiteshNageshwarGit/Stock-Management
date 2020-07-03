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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDealerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPriceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemainingQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProductList);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductName,
            this.ColDealerName,
            this.ColBillDate,
            this.ColSellingPrice,
            this.ColUnitPrice,
            this.ColUnitPriceCode,
            this.ColTotalQuantity,
            this.ColRemainingQuantity,
            this.ColAdd,
            this.ColRemove});
            this.dgvProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductList.Location = new System.Drawing.Point(3, 16);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.Size = new System.Drawing.Size(763, 375);
            this.dgvProductList.TabIndex = 0;
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
            this.ColBillDate.DataPropertyName = "BillDate";
            this.ColBillDate.HeaderText = "Bill Date";
            this.ColBillDate.Name = "ColBillDate";
            this.ColBillDate.ReadOnly = true;
            // 
            // ColSellingPrice
            // 
            this.ColSellingPrice.DataPropertyName = "UnitSellPrice";
            this.ColSellingPrice.HeaderText = "Uni Selling Price";
            this.ColSellingPrice.Name = "ColSellingPrice";
            this.ColSellingPrice.ReadOnly = true;
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.DataPropertyName = "UnitPrice";
            this.ColUnitPrice.HeaderText = "Unit Price";
            this.ColUnitPrice.Name = "ColUnitPrice";
            this.ColUnitPrice.ReadOnly = true;
            // 
            // ColUnitPriceCode
            // 
            this.ColUnitPriceCode.HeaderText = "Unit Price Code";
            this.ColUnitPriceCode.Name = "ColUnitPriceCode";
            this.ColUnitPriceCode.ReadOnly = true;
            // 
            // ColTotalQuantity
            // 
            this.ColTotalQuantity.DataPropertyName = "TotalQuantity";
            this.ColTotalQuantity.HeaderText = "Total Quantity";
            this.ColTotalQuantity.Name = "ColTotalQuantity";
            this.ColTotalQuantity.ReadOnly = true;
            // 
            // ColRemainingQuantity
            // 
            this.ColRemainingQuantity.DataPropertyName = "RemainigQuantity";
            this.ColRemainingQuantity.HeaderText = "Reamining Quanitity";
            this.ColRemainingQuantity.Name = "ColRemainingQuantity";
            this.ColRemainingQuantity.ReadOnly = true;
            // 
            // ColAdd
            // 
            this.ColAdd.FillWeight = 50F;
            this.ColAdd.HeaderText = "Add";
            this.ColAdd.Name = "ColAdd";
            this.ColAdd.ReadOnly = true;
            this.ColAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAdd.Text = "+";
            // 
            // ColRemove
            // 
            this.ColRemove.FillWeight = 50F;
            this.ColRemove.HeaderText = "Remove";
            this.ColRemove.Name = "ColRemove";
            this.ColRemove.ReadOnly = true;
            this.ColRemove.Text = "-";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(13, 13);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(300, 23);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 462);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "SellForm";
            this.Text = "Sell";
            this.Load += new System.EventHandler(this.SellForm_Load);
            this.Shown += new System.EventHandler(this.SellForm_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDealerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPriceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemainingQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn ColAdd;
        private System.Windows.Forms.DataGridViewButtonColumn ColRemove;
        private System.Windows.Forms.TextBox txtProductName;
    }
}