﻿namespace Stock_Management.Forms
{
    partial class DealerListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddDealer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDealerList = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDealerShowLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColSelect = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dgvBillList = new System.Windows.Forms.DataGridView();
            this.ColBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBillShowLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColShowBillBreakups = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddDealer
            // 
            this.btnAddDealer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDealer.Location = new System.Drawing.Point(713, 10);
            this.btnAddDealer.Name = "btnAddDealer";
            this.btnAddDealer.Size = new System.Drawing.Size(88, 28);
            this.btnAddDealer.TabIndex = 1;
            this.btnAddDealer.Text = "Add";
            this.btnAddDealer.UseVisualStyleBackColor = true;
            this.btnAddDealer.Click += new System.EventHandler(this.btnAddDealer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dealer List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDealerList
            // 
            this.dgvDealerList.AllowUserToAddRows = false;
            this.dgvDealerList.AllowUserToDeleteRows = false;
            this.dgvDealerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDealerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDealerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDealerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDealerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColMobile,
            this.ColEmail,
            this.ColAddress,
            this.ColDealerShowLink,
            this.ColSelect});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDealerList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDealerList.Location = new System.Drawing.Point(-1, 44);
            this.dgvDealerList.MinimumSize = new System.Drawing.Size(0, 140);
            this.dgvDealerList.MultiSelect = false;
            this.dgvDealerList.Name = "dgvDealerList";
            this.dgvDealerList.ReadOnly = true;
            this.dgvDealerList.RowHeadersVisible = false;
            this.dgvDealerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDealerList.Size = new System.Drawing.Size(810, 172);
            this.dgvDealerList.TabIndex = 0;
            this.dgvDealerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDealerList_CellClick);
            this.dgvDealerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDealerList_CellContentClick);
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            this.ColName.FillWeight = 3F;
            this.ColName.HeaderText = "Dealer Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColMobile
            // 
            this.ColMobile.DataPropertyName = "Mobile";
            this.ColMobile.FillWeight = 2F;
            this.ColMobile.HeaderText = "Mobile";
            this.ColMobile.Name = "ColMobile";
            this.ColMobile.ReadOnly = true;
            // 
            // ColEmail
            // 
            this.ColEmail.DataPropertyName = "Email";
            this.ColEmail.FillWeight = 3F;
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            // 
            // ColAddress
            // 
            this.ColAddress.DataPropertyName = "Address";
            this.ColAddress.FillWeight = 3F;
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.ReadOnly = true;
            // 
            // ColDealerShowLink
            // 
            this.ColDealerShowLink.DataPropertyName = "Id";
            this.ColDealerShowLink.FillWeight = 1F;
            this.ColDealerShowLink.HeaderText = "Show";
            this.ColDealerShowLink.Name = "ColDealerShowLink";
            this.ColDealerShowLink.ReadOnly = true;
            this.ColDealerShowLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDealerShowLink.Text = "Details";
            // 
            // ColSelect
            // 
            this.ColSelect.FillWeight = 1F;
            this.ColSelect.HeaderText = "Select";
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.ReadOnly = true;
            this.ColSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvBillList
            // 
            this.dgvBillList.AllowUserToAddRows = false;
            this.dgvBillList.AllowUserToDeleteRows = false;
            this.dgvBillList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBillDate,
            this.CollTotalAmount,
            this.ColEntryDate,
            this.ColRemarks,
            this.ColBillShowLink,
            this.ColShowBillBreakups});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBillList.Location = new System.Drawing.Point(-1, 56);
            this.dgvBillList.MinimumSize = new System.Drawing.Size(0, 200);
            this.dgvBillList.Name = "dgvBillList";
            this.dgvBillList.ReadOnly = true;
            this.dgvBillList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBillList.RowHeadersVisible = false;
            this.dgvBillList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillList.Size = new System.Drawing.Size(810, 260);
            this.dgvBillList.TabIndex = 0;
            this.dgvBillList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillList_CellClick);
            this.dgvBillList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillList_CellContentClick);
            // 
            // ColBillDate
            // 
            this.ColBillDate.DataPropertyName = "BillDate";
            this.ColBillDate.HeaderText = "Bill Date";
            this.ColBillDate.Name = "ColBillDate";
            this.ColBillDate.ReadOnly = true;
            // 
            // CollTotalAmount
            // 
            this.CollTotalAmount.DataPropertyName = "TotalAmount";
            this.CollTotalAmount.FillWeight = 80F;
            this.CollTotalAmount.HeaderText = "Amount";
            this.CollTotalAmount.Name = "CollTotalAmount";
            this.CollTotalAmount.ReadOnly = true;
            // 
            // ColEntryDate
            // 
            this.ColEntryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColEntryDate.DataPropertyName = "EntryDate";
            this.ColEntryDate.FillWeight = 120F;
            this.ColEntryDate.HeaderText = "Entry Date";
            this.ColEntryDate.Name = "ColEntryDate";
            this.ColEntryDate.ReadOnly = true;
            this.ColEntryDate.Width = 150;
            // 
            // ColRemarks
            // 
            this.ColRemarks.DataPropertyName = "Remarks";
            this.ColRemarks.FillWeight = 200F;
            this.ColRemarks.HeaderText = "Remarks";
            this.ColRemarks.Name = "ColRemarks";
            this.ColRemarks.ReadOnly = true;
            // 
            // ColBillShowLink
            // 
            this.ColBillShowLink.HeaderText = "Action";
            this.ColBillShowLink.Name = "ColBillShowLink";
            this.ColBillShowLink.ReadOnly = true;
            this.ColBillShowLink.Text = "Add Breakups";
            // 
            // ColShowBillBreakups
            // 
            this.ColShowBillBreakups.DataPropertyName = "Id";
            this.ColShowBillBreakups.FillWeight = 80F;
            this.ColShowBillBreakups.HeaderText = "Show";
            this.ColShowBillBreakups.Name = "ColShowBillBreakups";
            this.ColShowBillBreakups.ReadOnly = true;
            this.ColShowBillBreakups.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColShowBillBreakups.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColShowBillBreakups.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bill List: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(713, 16);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(88, 28);
            this.btnAddBill.TabIndex = 4;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvDealerList);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddDealer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtDealerName);
            this.splitContainer1.Panel2.Controls.Add(this.dgvBillList);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddBill);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(810, 538);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 7;
            // 
            // txtDealerName
            // 
            this.txtDealerName.Enabled = false;
            this.txtDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerName.Location = new System.Drawing.Point(80, 20);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(286, 23);
            this.txtDealerName.TabIndex = 7;
            this.txtDealerName.TextChanged += new System.EventHandler(this.txtDealerName_TextChanged);
            // 
            // DealerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "DealerListForm";
            this.Text = "Dealer List";
            this.Load += new System.EventHandler(this.DealerListForm_Load);
            this.Shown += new System.EventHandler(this.DealerListForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddDealer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDealerList;
        private System.Windows.Forms.DataGridView dgvBillList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemarks;
        private System.Windows.Forms.DataGridViewLinkColumn ColBillShowLink;
        private System.Windows.Forms.DataGridViewLinkColumn ColShowBillBreakups;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewLinkColumn ColDealerShowLink;
        private System.Windows.Forms.DataGridViewLinkColumn ColSelect;
    }
}