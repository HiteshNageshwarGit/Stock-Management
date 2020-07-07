namespace Stock_Management.Forms
{
    partial class BillListForm
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
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.dgvBillList = new System.Windows.Forms.DataGridView();
            this.ColBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBillShowLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColShowBillBreakups = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDealerName
            // 
            this.txtDealerName.BackColor = System.Drawing.SystemColors.Control;
            this.txtDealerName.Enabled = false;
            this.txtDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerName.Location = new System.Drawing.Point(93, 21);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(286, 23);
            this.txtDealerName.TabIndex = 11;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBillDate,
            this.CollTotalAmount,
            this.ColEntryDate,
            this.ColRemarks,
            this.ColBillShowLink,
            this.ColShowBillBreakups});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillList.Location = new System.Drawing.Point(12, 57);
            this.dgvBillList.MinimumSize = new System.Drawing.Size(0, 200);
            this.dgvBillList.Name = "dgvBillList";
            this.dgvBillList.ReadOnly = true;
            this.dgvBillList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBillList.RowHeadersVisible = false;
            this.dgvBillList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillList.Size = new System.Drawing.Size(760, 493);
            this.dgvBillList.TabIndex = 8;
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
            // btnAddBill
            // 
            this.btnAddBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(648, 17);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(116, 34);
            this.btnAddBill.TabIndex = 9;
            this.btnAddBill.Text = "Add Dealer Bill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bill List: ";
            // 
            // BillListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.txtDealerName);
            this.Controls.Add(this.dgvBillList);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BillListForm";
            this.Text = "Bill List";
            this.Load += new System.EventHandler(this.BillListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.DataGridView dgvBillList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemarks;
        private System.Windows.Forms.DataGridViewLinkColumn ColBillShowLink;
        private System.Windows.Forms.DataGridViewLinkColumn ColShowBillBreakups;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Label label2;
    }
}