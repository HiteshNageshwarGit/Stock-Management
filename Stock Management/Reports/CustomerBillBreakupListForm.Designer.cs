namespace Stock_Management.Forms
{
    partial class CustomerBillBreakupListForm
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
            this.dgvCustomerBillBreakupList = new System.Windows.Forms.DataGridView();
            this.ColRSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerBillBreakupList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerBillBreakupList
            // 
            this.dgvCustomerBillBreakupList.AllowUserToAddRows = false;
            this.dgvCustomerBillBreakupList.AllowUserToDeleteRows = false;
            this.dgvCustomerBillBreakupList.AllowUserToOrderColumns = true;
            this.dgvCustomerBillBreakupList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerBillBreakupList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerBillBreakupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerBillBreakupList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRSNo,
            this.ColProductName1,
            this.ColUnitPrice,
            this.ColTotalQuantity,
            this.ColTotalAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerBillBreakupList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerBillBreakupList.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomerBillBreakupList.Name = "dgvCustomerBillBreakupList";
            this.dgvCustomerBillBreakupList.ReadOnly = true;
            this.dgvCustomerBillBreakupList.Size = new System.Drawing.Size(760, 438);
            this.dgvCustomerBillBreakupList.TabIndex = 0;
            // 
            // ColRSNo
            // 
            this.ColRSNo.DataPropertyName = "SNo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColRSNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColRSNo.FillWeight = 50F;
            this.ColRSNo.HeaderText = "S.No.";
            this.ColRSNo.Name = "ColRSNo";
            this.ColRSNo.ReadOnly = true;
            // 
            // ColProductName1
            // 
            this.ColProductName1.DataPropertyName = "ProductName";
            this.ColProductName1.FillWeight = 200F;
            this.ColProductName1.HeaderText = "Product Name";
            this.ColProductName1.Name = "ColProductName1";
            this.ColProductName1.ReadOnly = true;
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.DataPropertyName = "UnitPrice";
            this.ColUnitPrice.HeaderText = "Unit Price";
            this.ColUnitPrice.Name = "ColUnitPrice";
            this.ColUnitPrice.ReadOnly = true;
            // 
            // ColTotalQuantity
            // 
            this.ColTotalQuantity.DataPropertyName = "TotalQuantity";
            this.ColTotalQuantity.HeaderText = "Total Quantity";
            this.ColTotalQuantity.Name = "ColTotalQuantity";
            this.ColTotalQuantity.ReadOnly = true;
            // 
            // ColTotalAmount
            // 
            this.ColTotalAmount.DataPropertyName = "TotalAmount";
            this.ColTotalAmount.HeaderText = "Total Amount";
            this.ColTotalAmount.Name = "ColTotalAmount";
            this.ColTotalAmount.ReadOnly = true;
            // 
            // CustomerBillBreakupListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.dgvCustomerBillBreakupList);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "CustomerBillBreakupListForm";
            this.Text = "Customer Bill Breakup List";
            this.Load += new System.EventHandler(this.CustomerBillBreakupListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerBillBreakupList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerBillBreakupList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalAmount;
    }
}