namespace Stock_Management.Forms
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
            this.btnAddDealer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDealerList = new System.Windows.Forms.DataGridView();
            this.dgvBillList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDealerShowLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBillShowLink = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDealer
            // 
            this.btnAddDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDealer.Location = new System.Drawing.Point(772, 14);
            this.btnAddDealer.Name = "btnAddDealer";
            this.btnAddDealer.Size = new System.Drawing.Size(88, 26);
            this.btnAddDealer.TabIndex = 1;
            this.btnAddDealer.Text = "Add Dealer";
            this.btnAddDealer.UseVisualStyleBackColor = true;
            this.btnAddDealer.Click += new System.EventHandler(this.btnAddDealer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dealer List";
            // 
            // dgvDealerList
            // 
            this.dgvDealerList.AllowUserToAddRows = false;
            this.dgvDealerList.AllowUserToDeleteRows = false;
            this.dgvDealerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDealerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColMobile,
            this.ColEmail,
            this.ColAddress,
            this.ColDealerShowLink});
            this.dgvDealerList.Location = new System.Drawing.Point(12, 46);
            this.dgvDealerList.MultiSelect = false;
            this.dgvDealerList.Name = "dgvDealerList";
            this.dgvDealerList.ReadOnly = true;
            this.dgvDealerList.RowHeadersVisible = false;
            this.dgvDealerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDealerList.Size = new System.Drawing.Size(848, 190);
            this.dgvDealerList.TabIndex = 0;
            this.dgvDealerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDealerList_CellClick);
            // 
            // dgvBillList
            // 
            this.dgvBillList.AllowUserToAddRows = false;
            this.dgvBillList.AllowUserToDeleteRows = false;
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
            this.ColBillShowLink});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillList.Location = new System.Drawing.Point(12, 276);
            this.dgvBillList.Name = "dgvBillList";
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
            this.dgvBillList.Size = new System.Drawing.Size(848, 235);
            this.dgvBillList.TabIndex = 0;
            this.dgvBillList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillList_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bill List: ";
            // 
            // btnAddBill
            // 
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(772, 242);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(88, 28);
            this.btnAddBill.TabIndex = 4;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Location = new System.Drawing.Point(90, 253);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(69, 13);
            this.lblDealerName.TabIndex = 6;
            this.lblDealerName.Text = "Dealer Name";
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            this.ColName.HeaderText = "Dealer Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 200;
            // 
            // ColMobile
            // 
            this.ColMobile.DataPropertyName = "Mobile";
            this.ColMobile.HeaderText = "Mobile";
            this.ColMobile.Name = "ColMobile";
            this.ColMobile.ReadOnly = true;
            // 
            // ColEmail
            // 
            this.ColEmail.DataPropertyName = "Email";
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            // 
            // ColAddress
            // 
            this.ColAddress.DataPropertyName = "Address";
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.ReadOnly = true;
            this.ColAddress.Width = 250;
            // 
            // ColDealerShowLink
            // 
            this.ColDealerShowLink.DataPropertyName = "Id";
            this.ColDealerShowLink.HeaderText = "Show";
            this.ColDealerShowLink.Name = "ColDealerShowLink";
            this.ColDealerShowLink.ReadOnly = true;
            this.ColDealerShowLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDealerShowLink.Text = "Details";
            // 
            // ColBillDate
            // 
            this.ColBillDate.DataPropertyName = "BillDate";
            this.ColBillDate.HeaderText = "Bill Date";
            this.ColBillDate.Name = "ColBillDate";
            // 
            // CollTotalAmount
            // 
            this.CollTotalAmount.DataPropertyName = "TotalAmount";
            this.CollTotalAmount.HeaderText = "Total Amount";
            this.CollTotalAmount.Name = "CollTotalAmount";
            // 
            // ColEntryDate
            // 
            this.ColEntryDate.DataPropertyName = "BillEntryDate";
            this.ColEntryDate.HeaderText = "Bill Entry Date";
            this.ColEntryDate.Name = "ColEntryDate";
            // 
            // ColRemarks
            // 
            this.ColRemarks.DataPropertyName = "Remarks";
            this.ColRemarks.HeaderText = "Remarks";
            this.ColRemarks.Name = "ColRemarks";
            // 
            // ColBillShowLink
            // 
            this.ColBillShowLink.HeaderText = "Action";
            this.ColBillShowLink.Name = "ColBillShowLink";
            this.ColBillShowLink.Text = "Add Breakups";
            // 
            // DealerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 523);
            this.Controls.Add(this.lblDealerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.dgvBillList);
            this.Controls.Add(this.dgvDealerList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddDealer);
            this.Name = "DealerListForm";
            this.Text = "Dealer List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddDealer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDealerList;
        private System.Windows.Forms.DataGridView dgvBillList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewLinkColumn ColDealerShowLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemarks;
        private System.Windows.Forms.DataGridViewLinkColumn ColBillShowLink;
    }
}