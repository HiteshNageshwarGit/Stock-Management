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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDealerList = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetailsLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColBillsLinl = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColSelectLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.lblSearchPerson = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealerList)).BeginInit();
            this.SuspendLayout();
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
            this.ColDetailsLink,
            this.ColBillsLinl,
            this.ColSelectLink});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDealerList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDealerList.Location = new System.Drawing.Point(12, 43);
            this.dgvDealerList.MinimumSize = new System.Drawing.Size(0, 140);
            this.dgvDealerList.MultiSelect = false;
            this.dgvDealerList.Name = "dgvDealerList";
            this.dgvDealerList.ReadOnly = true;
            this.dgvDealerList.RowHeadersVisible = false;
            this.dgvDealerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDealerList.Size = new System.Drawing.Size(820, 527);
            this.dgvDealerList.TabIndex = 4;
            this.dgvDealerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDealerList_CellContentClick);
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            this.ColName.FillWeight = 200F;
            this.ColName.HeaderText = "Dealer Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
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
            // 
            // ColDetailsLink
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDetailsLink.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColDetailsLink.FillWeight = 80F;
            this.ColDetailsLink.HeaderText = "Show";
            this.ColDetailsLink.MinimumWidth = 80;
            this.ColDetailsLink.Name = "ColDetailsLink";
            this.ColDetailsLink.ReadOnly = true;
            this.ColDetailsLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDetailsLink.Text = "Details";
            this.ColDetailsLink.UseColumnTextForLinkValue = true;
            // 
            // ColBillsLinl
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColBillsLinl.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColBillsLinl.FillWeight = 80F;
            this.ColBillsLinl.HeaderText = "Show";
            this.ColBillsLinl.MinimumWidth = 80;
            this.ColBillsLinl.Name = "ColBillsLinl";
            this.ColBillsLinl.ReadOnly = true;
            this.ColBillsLinl.Text = "Bills";
            this.ColBillsLinl.UseColumnTextForLinkValue = true;
            // 
            // ColSelectLink
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSelectLink.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColSelectLink.FillWeight = 80F;
            this.ColSelectLink.HeaderText = "Action";
            this.ColSelectLink.MinimumWidth = 80;
            this.ColSelectLink.Name = "ColSelectLink";
            this.ColSelectLink.ReadOnly = true;
            this.ColSelectLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSelectLink.Text = "Select";
            this.ColSelectLink.UseColumnTextForLinkValue = true;
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
            this.Controls.Add(this.dgvDealerList);
            this.Controls.Add(this.lblSearchPerson);
            this.Controls.Add(this.btnAddPerson);
            this.Name = "PersonListForm";
            this.Text = "Person List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonListForm_FormClosing);
            this.Load += new System.EventHandler(this.PersonListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDealerList;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label lblSearchPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewLinkColumn ColDetailsLink;
        private System.Windows.Forms.DataGridViewLinkColumn ColBillsLinl;
        private System.Windows.Forms.DataGridViewLinkColumn ColSelectLink;
    }
}