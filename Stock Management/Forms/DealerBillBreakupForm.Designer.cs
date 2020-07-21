namespace Stock_Management.Forms
{
    partial class DealerBillBreakupForm
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
            this.btnSaveBillBreakups = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindProduct = new System.Windows.Forms.Button();
            this.grpBoxBrakupCount = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveDBBNClose = new System.Windows.Forms.Button();
            this.numAvailableQuantity = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numUnitSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSelectedProductName = new System.Windows.Forms.TextBox();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.numTotalQuantity = new System.Windows.Forms.NumericUpDown();
            this.numQuantityInABox = new System.Windows.Forms.NumericUpDown();
            this.numTotalBoxes = new System.Windows.Forms.NumericUpDown();
            this.numTotalAmount = new System.Windows.Forms.NumericUpDown();
            this.txtBillBreakupRemarks = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityInABox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveBillBreakups
            // 
            this.btnSaveBillBreakups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBillBreakups.Location = new System.Drawing.Point(353, 328);
            this.btnSaveBillBreakups.Name = "btnSaveBillBreakups";
            this.btnSaveBillBreakups.Size = new System.Drawing.Size(112, 30);
            this.btnSaveBillBreakups.TabIndex = 8;
            this.btnSaveBillBreakups.Tag = "Ctrl + S";
            this.btnSaveBillBreakups.Text = "&Save + New";
            this.btnSaveBillBreakups.UseVisualStyleBackColor = true;
            this.btnSaveBillBreakups.Click += new System.EventHandler(this.btnSaveBillBreakups_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindProduct.Location = new System.Drawing.Point(328, 37);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(75, 28);
            this.btnFindProduct.TabIndex = 2;
            this.btnFindProduct.Tag = "Ctrl + F";
            this.btnFindProduct.Text = "&Find";
            this.btnFindProduct.UseVisualStyleBackColor = true;
            this.btnFindProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // grpBoxBrakupCount
            // 
            this.grpBoxBrakupCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxBrakupCount.Location = new System.Drawing.Point(12, 12);
            this.grpBoxBrakupCount.Name = "grpBoxBrakupCount";
            this.grpBoxBrakupCount.Size = new System.Drawing.Size(710, 122);
            this.grpBoxBrakupCount.TabIndex = 4;
            this.grpBoxBrakupCount.TabStop = false;
            this.grpBoxBrakupCount.Text = "Dealer And Bill Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveDBBNClose);
            this.groupBox2.Controls.Add(this.numAvailableQuantity);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.numUnitSellingPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSelectedProductName);
            this.groupBox2.Controls.Add(this.numUnitPrice);
            this.groupBox2.Controls.Add(this.numTotalQuantity);
            this.groupBox2.Controls.Add(this.numQuantityInABox);
            this.groupBox2.Controls.Add(this.numTotalBoxes);
            this.groupBox2.Controls.Add(this.numTotalAmount);
            this.groupBox2.Controls.Add(this.txtBillBreakupRemarks);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnSaveBillBreakups);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnFindProduct);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 382);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill Breakup Details";
            // 
            // btnSaveDBBNClose
            // 
            this.btnSaveDBBNClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDBBNClose.Location = new System.Drawing.Point(482, 328);
            this.btnSaveDBBNClose.Name = "btnSaveDBBNClose";
            this.btnSaveDBBNClose.Size = new System.Drawing.Size(124, 30);
            this.btnSaveDBBNClose.TabIndex = 9;
            this.btnSaveDBBNClose.Tag = "Ctrl + S";
            this.btnSaveDBBNClose.Text = "&Save + Close";
            this.btnSaveDBBNClose.UseVisualStyleBackColor = true;
            this.btnSaveDBBNClose.Click += new System.EventHandler(this.btnSaveDBBNClose_Click);
            // 
            // numAvailableQuantity
            // 
            this.numAvailableQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.numAvailableQuantity.Enabled = false;
            this.numAvailableQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAvailableQuantity.Location = new System.Drawing.Point(347, 160);
            this.numAvailableQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAvailableQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAvailableQuantity.Name = "numAvailableQuantity";
            this.numAvailableQuantity.Size = new System.Drawing.Size(221, 23);
            this.numAvailableQuantity.TabIndex = 24;
            this.numAvailableQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(344, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Available Quantity";
            // 
            // numUnitSellingPrice
            // 
            this.numUnitSellingPrice.BackColor = System.Drawing.SystemColors.Window;
            this.numUnitSellingPrice.DecimalPlaces = 2;
            this.numUnitSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUnitSellingPrice.Location = new System.Drawing.Point(347, 280);
            this.numUnitSellingPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUnitSellingPrice.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numUnitSellingPrice.Name = "numUnitSellingPrice";
            this.numUnitSellingPrice.Size = new System.Drawing.Size(221, 23);
            this.numUnitSellingPrice.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Unit Selling Price";
            // 
            // txtSelectedProductName
            // 
            this.txtSelectedProductName.Enabled = false;
            this.txtSelectedProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedProductName.Location = new System.Drawing.Point(6, 40);
            this.txtSelectedProductName.Name = "txtSelectedProductName";
            this.txtSelectedProductName.Size = new System.Drawing.Size(318, 24);
            this.txtSelectedProductName.TabIndex = 1;
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.DecimalPlaces = 2;
            this.numUnitPrice.Enabled = false;
            this.numUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUnitPrice.Location = new System.Drawing.Point(347, 220);
            this.numUnitPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUnitPrice.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.ReadOnly = true;
            this.numUnitPrice.Size = new System.Drawing.Size(221, 23);
            this.numUnitPrice.TabIndex = 20;
            // 
            // numTotalQuantity
            // 
            this.numTotalQuantity.Enabled = false;
            this.numTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotalQuantity.Location = new System.Drawing.Point(347, 102);
            this.numTotalQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTotalQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalQuantity.Name = "numTotalQuantity";
            this.numTotalQuantity.ReadOnly = true;
            this.numTotalQuantity.Size = new System.Drawing.Size(221, 23);
            this.numTotalQuantity.TabIndex = 19;
            this.numTotalQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numQuantityInABox
            // 
            this.numQuantityInABox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantityInABox.Location = new System.Drawing.Point(9, 220);
            this.numQuantityInABox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantityInABox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantityInABox.Name = "numQuantityInABox";
            this.numQuantityInABox.Size = new System.Drawing.Size(315, 23);
            this.numQuantityInABox.TabIndex = 5;
            this.numQuantityInABox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantityInABox.ValueChanged += new System.EventHandler(this.NumericControl_ValueChange);
            this.numQuantityInABox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumericControl_KeyUp);
            // 
            // numTotalBoxes
            // 
            this.numTotalBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotalBoxes.Location = new System.Drawing.Point(9, 160);
            this.numTotalBoxes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTotalBoxes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalBoxes.Name = "numTotalBoxes";
            this.numTotalBoxes.Size = new System.Drawing.Size(315, 23);
            this.numTotalBoxes.TabIndex = 4;
            this.numTotalBoxes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalBoxes.ValueChanged += new System.EventHandler(this.NumericControl_ValueChange);
            this.numTotalBoxes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumericControl_KeyUp);
            // 
            // numTotalAmount
            // 
            this.numTotalAmount.DecimalPlaces = 2;
            this.numTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotalAmount.Location = new System.Drawing.Point(9, 100);
            this.numTotalAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTotalAmount.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numTotalAmount.Name = "numTotalAmount";
            this.numTotalAmount.Size = new System.Drawing.Size(315, 24);
            this.numTotalAmount.TabIndex = 3;
            this.numTotalAmount.ValueChanged += new System.EventHandler(this.NumericControl_ValueChange);
            this.numTotalAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumericControl_KeyUp);
            // 
            // txtBillBreakupRemarks
            // 
            this.txtBillBreakupRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillBreakupRemarks.Location = new System.Drawing.Point(9, 280);
            this.txtBillBreakupRemarks.Name = "txtBillBreakupRemarks";
            this.txtBillBreakupRemarks.Size = new System.Drawing.Size(315, 96);
            this.txtBillBreakupRemarks.TabIndex = 6;
            this.txtBillBreakupRemarks.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "Remarks";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(344, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Unit Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(344, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quantity In Box";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Boxes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Amount";
            // 
            // DealerBillBreakupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBoxBrakupCount);
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "DealerBillBreakupForm";
            this.Text = "Dealer Bill Breakup";
            this.Load += new System.EventHandler(this.BillBreakupForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityInABox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveBillBreakups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindProduct;
        private System.Windows.Forms.GroupBox grpBoxBrakupCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtBillBreakupRemarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numTotalAmount;
        private System.Windows.Forms.NumericUpDown numUnitPrice;
        private System.Windows.Forms.NumericUpDown numTotalQuantity;
        private System.Windows.Forms.NumericUpDown numQuantityInABox;
        private System.Windows.Forms.NumericUpDown numTotalBoxes;
        private System.Windows.Forms.TextBox txtSelectedProductName;
        private System.Windows.Forms.NumericUpDown numUnitSellingPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numAvailableQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSaveDBBNClose;
    }
}