namespace Stock_Management.Forms
{
    partial class BillForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBillDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.numBillAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtBillEntryDate = new System.Windows.Forms.DateTimePicker();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBillAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entry Date";
            // 
            // dtBillDate
            // 
            this.dtBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBillDate.Location = new System.Drawing.Point(9, 100);
            this.dtBillDate.Name = "dtBillDate";
            this.dtBillDate.Size = new System.Drawing.Size(345, 24);
            this.dtBillDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bill Date";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(6, 140);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(91, 15);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBill.Location = new System.Drawing.Point(236, 392);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(118, 28);
            this.btnSaveBill.TabIndex = 12;
            this.btnSaveBill.Text = "Save";
            this.btnSaveBill.UseVisualStyleBackColor = true;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(6, 281);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(348, 90);
            this.txtRemarks.TabIndex = 11;
            this.txtRemarks.Text = "";
            // 
            // numBillAmount
            // 
            this.numBillAmount.DecimalPlaces = 2;
            this.numBillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBillAmount.Location = new System.Drawing.Point(9, 160);
            this.numBillAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numBillAmount.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numBillAmount.Name = "numBillAmount";
            this.numBillAmount.Size = new System.Drawing.Size(345, 24);
            this.numBillAmount.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtBillEntryDate);
            this.groupBox1.Controls.Add(this.btnSaveBill);
            this.groupBox1.Controls.Add(this.txtDealerName);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.numBillAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtBillDate);
            this.groupBox1.Controls.Add(this.lblTotalAmount);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 438);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // dtBillEntryDate
            // 
            this.dtBillEntryDate.Enabled = false;
            this.dtBillEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBillEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBillEntryDate.Location = new System.Drawing.Point(9, 220);
            this.dtBillEntryDate.Name = "dtBillEntryDate";
            this.dtBillEntryDate.Size = new System.Drawing.Size(345, 24);
            this.dtBillEntryDate.TabIndex = 9;
            // 
            // txtDealerName
            // 
            this.txtDealerName.BackColor = System.Drawing.SystemColors.Control;
            this.txtDealerName.Enabled = false;
            this.txtDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerName.Location = new System.Drawing.Point(9, 36);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(345, 24);
            this.txtDealerName.TabIndex = 1;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "BillForm";
            this.Text = "Bill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillForm_FormClosing);
            this.Load += new System.EventHandler(this.BillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBillAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBillDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtRemarks;
        private System.Windows.Forms.NumericUpDown numBillAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.DateTimePicker dtBillEntryDate;
    }
}