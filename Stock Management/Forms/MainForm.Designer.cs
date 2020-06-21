namespace Stock_Management
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBillToolStripMenuItemfffffffff = new System.Windows.Forms.ToolStripMenuItem();
            this.dealersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBillDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.dealersToolStripMenuItem,
            this.billToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBillToolStripMenuItemfffffffff});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.dealersToolStripMenuItem_Click);
            // 
            // addBillToolStripMenuItemfffffffff
            // 
            this.addBillToolStripMenuItemfffffffff.Name = "addBillToolStripMenuItemfffffffff";
            this.addBillToolStripMenuItemfffffffff.Size = new System.Drawing.Size(115, 22);
            this.addBillToolStripMenuItemfffffffff.Text = "Add Bill";
            this.addBillToolStripMenuItemfffffffff.Click += new System.EventHandler(this.addBillToolStripMenuItem_Click);
            // 
            // dealersToolStripMenuItem
            // 
            this.dealersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dealerListToolStripMenuItem});
            this.dealersToolStripMenuItem.Name = "dealersToolStripMenuItem";
            this.dealersToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.dealersToolStripMenuItem.Text = "Dealers";
            // 
            // dealerListToolStripMenuItem
            // 
            this.dealerListToolStripMenuItem.Name = "dealerListToolStripMenuItem";
            this.dealerListToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.dealerListToolStripMenuItem.Text = "Dealer List";
            this.dealerListToolStripMenuItem.Click += new System.EventHandler(this.dealerListToolStripMenuItem_Click);
            // 
            // billToolStripMenuItem
            // 
            this.billToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billListToolStripMenuItem,
            this.addBillToolStripMenuItem,
            this.addBillDetailsToolStripMenuItem});
            this.billToolStripMenuItem.Name = "billToolStripMenuItem";
            this.billToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.billToolStripMenuItem.Text = "Bill";
            // 
            // addBillToolStripMenuItem
            // 
            this.addBillToolStripMenuItem.Name = "addBillToolStripMenuItem";
            this.addBillToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBillToolStripMenuItem.Text = "Add Bill";
            this.addBillToolStripMenuItem.Click += new System.EventHandler(this.addBillToolStripMenuItem_Click);
            // 
            // addBillDetailsToolStripMenuItem
            // 
            this.addBillDetailsToolStripMenuItem.Name = "addBillDetailsToolStripMenuItem";
            this.addBillDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBillDetailsToolStripMenuItem.Text = "Add Bill Details";
            // 
            // billListToolStripMenuItem
            // 
            this.billListToolStripMenuItem.Name = "billListToolStripMenuItem";
            this.billListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.billListToolStripMenuItem.Text = "Bill List";
            this.billListToolStripMenuItem.Click += new System.EventHandler(this.billListToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 517);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Stock Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBillToolStripMenuItemfffffffff;
        private System.Windows.Forms.ToolStripMenuItem dealersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dealerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBillDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billListToolStripMenuItem;
    }
}

