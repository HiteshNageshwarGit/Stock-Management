namespace Stock_Management.Forms
{
    partial class AboutForm
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
            this.txtAppVersion = new System.Windows.Forms.TextBox();
            this.txtDBVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVersionHistory = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "App Version";
            // 
            // txtAppVersion
            // 
            this.txtAppVersion.Enabled = false;
            this.txtAppVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppVersion.Location = new System.Drawing.Point(225, 18);
            this.txtAppVersion.Name = "txtAppVersion";
            this.txtAppVersion.Size = new System.Drawing.Size(100, 23);
            this.txtAppVersion.TabIndex = 1;
            // 
            // txtDBVersion
            // 
            this.txtDBVersion.Enabled = false;
            this.txtDBVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBVersion.Location = new System.Drawing.Point(225, 59);
            this.txtDBVersion.Name = "txtDBVersion";
            this.txtDBVersion.Size = new System.Drawing.Size(100, 23);
            this.txtDBVersion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "DB Version";
            // 
            // txtVersionHistory
            // 
            this.txtVersionHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersionHistory.Enabled = false;
            this.txtVersionHistory.Location = new System.Drawing.Point(13, 107);
            this.txtVersionHistory.Name = "txtVersionHistory";
            this.txtVersionHistory.Size = new System.Drawing.Size(470, 331);
            this.txtVersionHistory.TabIndex = 4;
            this.txtVersionHistory.Text = "";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.txtVersionHistory);
            this.Controls.Add(this.txtDBVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAppVersion);
            this.Controls.Add(this.label1);
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAppVersion;
        private System.Windows.Forms.TextBox txtDBVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtVersionHistory;
    }
}