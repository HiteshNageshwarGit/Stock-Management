﻿namespace Stock_Management.Forms
{
    partial class ProductListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.ColSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSelect = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColLowerLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUpperLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetails = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAddNewProduct);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearchProduct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvProductList);
            this.splitContainer1.Size = new System.Drawing.Size(690, 468);
            this.splitContainer1.SplitterDistance = 52;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProduct.Location = new System.Drawing.Point(563, 9);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(122, 28);
            this.btnAddNewProduct.TabIndex = 3;
            this.btnAddNewProduct.Text = "Add Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(111, 14);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(282, 23);
            this.txtSearchProduct.TabIndex = 1;
            this.txtSearchProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchProduct_KeyUp);
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AllowUserToOrderColumns = true;
            this.dgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSNo,
            this.ColName,
            this.ColAvailableQuantity,
            this.ColSelect,
            this.ColLowerLimit,
            this.ColUpperLimit,
            this.ColDetails});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductList.Location = new System.Drawing.Point(-1, 3);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(690, 408);
            this.dgvProductList.TabIndex = 1;
            this.dgvProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellClick);
            this.dgvProductList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductList_CellFormatting);
            // 
            // ColSNo
            // 
            this.ColSNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSNo.DataPropertyName = "SNo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColSNo.FillWeight = 50F;
            this.ColSNo.HeaderText = "S.No.";
            this.ColSNo.MinimumWidth = 50;
            this.ColSNo.Name = "ColSNo";
            this.ColSNo.ReadOnly = true;
            this.ColSNo.Width = 75;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.DataPropertyName = "ProductName";
            this.ColName.FillWeight = 250F;
            this.ColName.HeaderText = "Product Name";
            this.ColName.MinimumWidth = 250;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColAvailableQuantity
            // 
            this.ColAvailableQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColAvailableQuantity.DataPropertyName = "AvailableQuantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColAvailableQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColAvailableQuantity.FillWeight = 80F;
            this.ColAvailableQuantity.HeaderText = "Avl Qty";
            this.ColAvailableQuantity.MinimumWidth = 80;
            this.ColAvailableQuantity.Name = "ColAvailableQuantity";
            this.ColAvailableQuantity.ReadOnly = true;
            this.ColAvailableQuantity.ToolTipText = "Available Quantity";
            this.ColAvailableQuantity.Width = 80;
            // 
            // ColSelect
            // 
            this.ColSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSelect.DataPropertyName = "Id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSelect.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColSelect.FillWeight = 80F;
            this.ColSelect.HeaderText = "Select";
            this.ColSelect.MinimumWidth = 80;
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.ReadOnly = true;
            this.ColSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSelect.Text = "Select";
            this.ColSelect.Width = 80;
            // 
            // ColLowerLimit
            // 
            this.ColLowerLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColLowerLimit.DataPropertyName = "LowerLimit";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColLowerLimit.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColLowerLimit.FillWeight = 80F;
            this.ColLowerLimit.HeaderText = "Lwr Lmt";
            this.ColLowerLimit.MinimumWidth = 80;
            this.ColLowerLimit.Name = "ColLowerLimit";
            this.ColLowerLimit.ReadOnly = true;
            this.ColLowerLimit.Width = 80;
            // 
            // ColUpperLimit
            // 
            this.ColUpperLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUpperLimit.DataPropertyName = "UpperLimit";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColUpperLimit.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColUpperLimit.FillWeight = 80F;
            this.ColUpperLimit.HeaderText = "Upr Lmt";
            this.ColUpperLimit.MinimumWidth = 80;
            this.ColUpperLimit.Name = "ColUpperLimit";
            this.ColUpperLimit.ReadOnly = true;
            this.ColUpperLimit.Width = 80;
            // 
            // ColDetails
            // 
            this.ColDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColDetails.DataPropertyName = "Id";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColDetails.FillWeight = 80F;
            this.ColDetails.HeaderText = "Details";
            this.ColDetails.MinimumWidth = 80;
            this.ColDetails.Name = "ColDetails";
            this.ColDetails.ReadOnly = true;
            this.ColDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDetails.Text = "Details";
            this.ColDetails.Width = 80;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 492);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(730, 530);
            this.Name = "ProductListForm";
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAvailableQuantity;
        private System.Windows.Forms.DataGridViewLinkColumn ColSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLowerLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUpperLimit;
        private System.Windows.Forms.DataGridViewLinkColumn ColDetails;
    }
}