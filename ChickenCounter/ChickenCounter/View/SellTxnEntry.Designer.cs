namespace ChickenCounter.View
{
    partial class SellTxnEntry
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucVendorSearch1 = new ChickenCounter.User_Controls.ucVendorSearch();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ucVendorSearch1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(927, 238);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ucVendorSearch1
            // 
            this.ucVendorSearch1.AutoSize = true;
            this.ucVendorSearch1.Location = new System.Drawing.Point(3, 3);
            this.ucVendorSearch1.Name = "ucVendorSearch1";
            this.ucVendorSearch1.Size = new System.Drawing.Size(807, 194);
            this.ucVendorSearch1.TabIndex = 0;
            // 
            // SellTxnEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 238);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SellTxnEntry";
            this.Text = "Sell Entry";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private User_Controls.ucVendorSearch ucVendorSearch1;
    }
}