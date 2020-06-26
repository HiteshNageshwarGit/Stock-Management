namespace Stock_Management.Forms
{
    partial class BillDetailForm
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
            this.btnSaveBillDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.lblSelectedProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBillRemarks = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantityInBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalBoxes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBillDetailAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBillDetailRemarks = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveBillDetails
            // 
            this.btnSaveBillDetails.Location = new System.Drawing.Point(376, 312);
            this.btnSaveBillDetails.Name = "btnSaveBillDetails";
            this.btnSaveBillDetails.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBillDetails.TabIndex = 0;
            this.btnSaveBillDetails.Text = "Save";
            this.btnSaveBillDetails.UseVisualStyleBackColor = true;
            this.btnSaveBillDetails.Click += new System.EventHandler(this.btnSaveBillDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(249, 37);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProduct.TabIndex = 2;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // lblSelectedProductName
            // 
            this.lblSelectedProductName.AutoSize = true;
            this.lblSelectedProductName.Location = new System.Drawing.Point(106, 37);
            this.lblSelectedProductName.Name = "lblSelectedProductName";
            this.lblSelectedProductName.Size = new System.Drawing.Size(114, 13);
            this.lblSelectedProductName.TabIndex = 3;
            this.lblSelectedProductName.Text = "SelectedProductName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBillRemarks);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblBillAmount);
            this.groupBox1.Controls.Add(this.lblBillDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDealerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dealer And Bill Details";
            // 
            // lblBillRemarks
            // 
            this.lblBillRemarks.AutoSize = true;
            this.lblBillRemarks.Location = new System.Drawing.Point(118, 144);
            this.lblBillRemarks.Name = "lblBillRemarks";
            this.lblBillRemarks.Size = new System.Drawing.Size(65, 13);
            this.lblBillRemarks.TabIndex = 7;
            this.lblBillRemarks.Text = "Bill Remarks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bill Remarks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bill Amount";
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Location = new System.Drawing.Point(24, 102);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(59, 13);
            this.lblBillAmount.TabIndex = 4;
            this.lblBillAmount.Text = "Bill Amount";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Location = new System.Drawing.Point(118, 64);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(46, 13);
            this.lblBillDate.TabIndex = 3;
            this.lblBillDate.Text = "Bill Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bill Date";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Location = new System.Drawing.Point(118, 32);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(69, 13);
            this.lblDealerName.TabIndex = 1;
            this.lblDealerName.Text = "Dealer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dealer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBillDetailRemarks);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtUnitPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTotalQuantity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtQuantityInBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnSaveBillDetails);
            this.groupBox2.Controls.Add(this.txtTotalBoxes);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBillDetailAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblSelectedProductName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSearchProduct);
            this.groupBox2.Location = new System.Drawing.Point(26, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 370);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill Breakup Details";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(109, 238);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(215, 20);
            this.txtUnitPrice.TabIndex = 13;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Unit Price";
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Location = new System.Drawing.Point(109, 195);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.Size = new System.Drawing.Size(215, 20);
            this.txtTotalQuantity.TabIndex = 11;
            this.txtTotalQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total Quantity";
            // 
            // txtQuantityInBox
            // 
            this.txtQuantityInBox.Location = new System.Drawing.Point(109, 150);
            this.txtQuantityInBox.Name = "txtQuantityInBox";
            this.txtQuantityInBox.Size = new System.Drawing.Size(215, 20);
            this.txtQuantityInBox.TabIndex = 9;
            this.txtQuantityInBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quantity In Box";
            // 
            // txtTotalBoxes
            // 
            this.txtTotalBoxes.Location = new System.Drawing.Point(109, 111);
            this.txtTotalBoxes.Name = "txtTotalBoxes";
            this.txtTotalBoxes.Size = new System.Drawing.Size(215, 20);
            this.txtTotalBoxes.TabIndex = 7;
            this.txtTotalBoxes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Boxes";
            // 
            // txtBillDetailAmount
            // 
            this.txtBillDetailAmount.Location = new System.Drawing.Point(109, 70);
            this.txtBillDetailAmount.Name = "txtBillDetailAmount";
            this.txtBillDetailAmount.Size = new System.Drawing.Size(215, 20);
            this.txtBillDetailAmount.TabIndex = 5;
            this.txtBillDetailAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Remarks";
            // 
            // txtBillDetailRemarks
            // 
            this.txtBillDetailRemarks.Location = new System.Drawing.Point(109, 280);
            this.txtBillDetailRemarks.Name = "txtBillDetailRemarks";
            this.txtBillDetailRemarks.Size = new System.Drawing.Size(215, 61);
            this.txtBillDetailRemarks.TabIndex = 15;
            this.txtBillDetailRemarks.Text = "";
            // 
            // BillDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BillDetailForm";
            this.Text = "Bill Detail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillDetailForm_FormClosing);
            this.Load += new System.EventHandler(this.BillDetailForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveBillDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Label lblSelectedProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBillRemarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.TextBox txtTotalQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantityInBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalBoxes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBillDetailAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtBillDetailRemarks;
        private System.Windows.Forms.Label label11;
    }
}