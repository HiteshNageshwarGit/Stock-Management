namespace Stock_Management.Forms
{
    partial class PersonListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPersonList = new System.Windows.Forms.DataGridView();
            this.ColRowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSelectLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColBillsLinl = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColDetailsLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.lblSearchPerson = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonList
            // 
            this.dgvPersonList.AllowUserToAddRows = false;
            this.dgvPersonList.AllowUserToDeleteRows = false;
            this.dgvPersonList.AllowUserToOrderColumns = true;
            this.dgvPersonList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRowNo,
            this.ColName,
            this.ColMobile,
            this.ColEmail,
            this.ColAddress,
            this.ColSelectLink,
            this.ColBillsLinl,
            this.ColDetailsLink});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            //dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPersonList.Location = new System.Drawing.Point(12, 43);
            this.dgvPersonList.MinimumSize = new System.Drawing.Size(0, 140);
            this.dgvPersonList.MultiSelect = false;
            this.dgvPersonList.Name = "dgvPersonList";
            this.dgvPersonList.ReadOnly = true;
            this.dgvPersonList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonList.Size = new System.Drawing.Size(820, 527);
            this.dgvPersonList.TabIndex = 4;
            this.dgvPersonList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDealerList_CellContentClick);
            this.dgvPersonList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPersonList_CellFormatting);
            // 
            // ColRowNo
            // 
            this.ColRowNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColRowNo.DataPropertyName = "SNo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColRowNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColRowNo.FillWeight = 80F;
            this.ColRowNo.HeaderText = "S.No.";
            this.ColRowNo.MinimumWidth = 80;
            this.ColRowNo.Name = "ColRowNo";
            this.ColRowNo.ReadOnly = true;
            this.ColRowNo.Width = 80;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            this.ColName.FillWeight = 200F;
            this.ColName.HeaderText = "Dealer Name";
            this.ColName.MinimumWidth = 200;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColMobile
            // 
            this.ColMobile.DataPropertyName = "Mobile";
            this.ColMobile.HeaderText = "Mobile";
            this.ColMobile.MinimumWidth = 100;
            this.ColMobile.Name = "ColMobile";
            this.ColMobile.ReadOnly = true;
            // 
            // ColEmail
            // 
            this.ColEmail.DataPropertyName = "Email";
            this.ColEmail.FillWeight = 50F;
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.MinimumWidth = 100;
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            // 
            // ColAddress
            // 
            this.ColAddress.DataPropertyName = "Address";
            this.ColAddress.FillWeight = 50F;
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.MinimumWidth = 100;
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.ReadOnly = true;
            // 
            // ColSelectLink
            // 
            this.ColSelectLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSelectLink.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColSelectLink.FillWeight = 80F;
            this.ColSelectLink.HeaderText = "Action";
            this.ColSelectLink.MinimumWidth = 80;
            this.ColSelectLink.Name = "ColSelectLink";
            this.ColSelectLink.ReadOnly = true;
            this.ColSelectLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSelectLink.Text = "Select";
            this.ColSelectLink.UseColumnTextForLinkValue = true;
            this.ColSelectLink.Width = 80;
            // 
            // ColBillsLinl
            // 
            this.ColBillsLinl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColBillsLinl.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColBillsLinl.FillWeight = 80F;
            this.ColBillsLinl.HeaderText = "Action";
            this.ColBillsLinl.MinimumWidth = 80;
            this.ColBillsLinl.Name = "ColBillsLinl";
            this.ColBillsLinl.ReadOnly = true;
            this.ColBillsLinl.Text = "Bills";
            this.ColBillsLinl.UseColumnTextForLinkValue = true;
            this.ColBillsLinl.Width = 80;
            // 
            // ColDetailsLink
            // 
            this.ColDetailsLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDetailsLink.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColDetailsLink.FillWeight = 80F;
            this.ColDetailsLink.HeaderText = "Show";
            this.ColDetailsLink.MinimumWidth = 80;
            this.ColDetailsLink.Name = "ColDetailsLink";
            this.ColDetailsLink.ReadOnly = true;
            this.ColDetailsLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDetailsLink.Text = "Details";
            this.ColDetailsLink.UseColumnTextForLinkValue = true;
            this.ColDetailsLink.Width = 80;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.Location = new System.Drawing.Point(718, 9);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(114, 28);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // lblSearchPerson
            // 
            this.lblSearchPerson.AutoSize = true;
            this.lblSearchPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPerson.Location = new System.Drawing.Point(9, 9);
            this.lblSearchPerson.Name = "lblSearchPerson";
            this.lblSearchPerson.Size = new System.Drawing.Size(59, 17);
            this.lblSearchPerson.TabIndex = 6;
            this.lblSearchPerson.Text = "Search";
            // 
            // PersonListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 582);
            this.Controls.Add(this.dgvPersonList);
            this.Controls.Add(this.lblSearchPerson);
            this.Controls.Add(this.btnAddPerson);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "PersonListForm";
            this.Text = "Person List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonListForm_FormClosing);
            this.Load += new System.EventHandler(this.PersonListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonList;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label lblSearchPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewLinkColumn ColSelectLink;
        private System.Windows.Forms.DataGridViewLinkColumn ColBillsLinl;
        private System.Windows.Forms.DataGridViewLinkColumn ColDetailsLink;
    }
}