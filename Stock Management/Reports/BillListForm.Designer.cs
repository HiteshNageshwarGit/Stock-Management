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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBillList = new System.Windows.Forms.DataGridView();
            this.ColSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBreakupSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBreakupCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColShowBillBreakupsLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColBillShowLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColRemarsk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonName
            // 
            this.txtPersonName.BackColor = System.Drawing.SystemColors.Control;
            this.txtPersonName.Enabled = false;
            this.txtPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonName.Location = new System.Drawing.Point(93, 21);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(286, 23);
            this.txtPersonName.TabIndex = 11;
            // 
            // btnAddBill
            // 
            this.btnAddBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(602, 17);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(162, 34);
            this.btnAddBill.TabIndex = 9;
            this.btnAddBill.Tag = "Ctrl + N";
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
            // dgvBillList
            // 
            this.dgvBillList.AllowUserToAddRows = false;
            this.dgvBillList.AllowUserToDeleteRows = false;
            this.dgvBillList.AllowUserToOrderColumns = true;
            this.dgvBillList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSNo,
            this.ColBillDate,
            this.ColTotalAmount,
            this.ColBreakupSum,
            this.ColBreakupCount,
            this.ColShowBillBreakupsLink,
            this.ColBillShowLink,
            this.ColRemarsk});
            this.dgvBillList.Location = new System.Drawing.Point(12, 57);
            this.dgvBillList.Name = "dgvBillList";
            this.dgvBillList.ReadOnly = true;
            this.dgvBillList.Size = new System.Drawing.Size(760, 493);
            this.dgvBillList.TabIndex = 12;
            this.dgvBillList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillList_CellContentClick);
            this.dgvBillList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBillList_CellFormatting);
            // 
            // ColSNo
            // 
            this.ColSNo.DataPropertyName = "SNo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColSNo.HeaderText = "S.No.";
            this.ColSNo.MinimumWidth = 80;
            this.ColSNo.Name = "ColSNo";
            this.ColSNo.ReadOnly = true;
            this.ColSNo.Width = 80;
            // 
            // ColBillDate
            // 
            this.ColBillDate.DataPropertyName = "BillDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColBillDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColBillDate.HeaderText = "Bill Date";
            this.ColBillDate.MinimumWidth = 150;
            this.ColBillDate.Name = "ColBillDate";
            this.ColBillDate.ReadOnly = true;
            this.ColBillDate.Width = 150;
            // 
            // ColTotalAmount
            // 
            this.ColTotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColTotalAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColTotalAmount.HeaderText = "Amount";
            this.ColTotalAmount.MinimumWidth = 100;
            this.ColTotalAmount.Name = "ColTotalAmount";
            this.ColTotalAmount.ReadOnly = true;
            // 
            // ColBreakupSum
            // 
            this.ColBreakupSum.DataPropertyName = "BreakupSum";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColBreakupSum.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColBreakupSum.HeaderText = "Brkp SUM";
            this.ColBreakupSum.MinimumWidth = 100;
            this.ColBreakupSum.Name = "ColBreakupSum";
            this.ColBreakupSum.ReadOnly = true;
            // 
            // ColBreakupCount
            // 
            this.ColBreakupCount.DataPropertyName = "BreakupCount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColBreakupCount.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColBreakupCount.HeaderText = "Brkp Count";
            this.ColBreakupCount.MinimumWidth = 100;
            this.ColBreakupCount.Name = "ColBreakupCount";
            this.ColBreakupCount.ReadOnly = true;
            // 
            // ColShowBillBreakupsLink
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColShowBillBreakupsLink.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColShowBillBreakupsLink.HeaderText = "Action";
            this.ColShowBillBreakupsLink.MinimumWidth = 100;
            this.ColShowBillBreakupsLink.Name = "ColShowBillBreakupsLink";
            this.ColShowBillBreakupsLink.ReadOnly = true;
            this.ColShowBillBreakupsLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColShowBillBreakupsLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColShowBillBreakupsLink.Text = "Breakups";
            // 
            // ColBillShowLink
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColBillShowLink.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColBillShowLink.HeaderText = "Show";
            this.ColBillShowLink.MinimumWidth = 100;
            this.ColBillShowLink.Name = "ColBillShowLink";
            this.ColBillShowLink.ReadOnly = true;
            this.ColBillShowLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColBillShowLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColBillShowLink.Text = "Details";
            // 
            // ColRemarsk
            // 
            this.ColRemarsk.DataPropertyName = "Remarks";
            this.ColRemarsk.FillWeight = 200F;
            this.ColRemarsk.HeaderText = "Remarks";
            this.ColRemarsk.MinimumWidth = 100;
            this.ColRemarsk.Name = "ColRemarsk";
            this.ColRemarsk.ReadOnly = true;
            // 
            // BillListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgvBillList);
            this.Controls.Add(this.txtPersonName);
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

        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBillList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBreakupSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBreakupCount;
        private System.Windows.Forms.DataGridViewLinkColumn ColShowBillBreakupsLink;
        private System.Windows.Forms.DataGridViewLinkColumn ColBillShowLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemarsk;
    }
}