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
            this.vendor_Search1 = new ChickenCounter.User_Controls.ucVendorSearch();
            this.SuspendLayout();
            // 
            // vendor_Search1
            // 
            this.vendor_Search1.Location = new System.Drawing.Point(12, 12);
            this.vendor_Search1.Name = "vendor_Search1";
            this.vendor_Search1.Size = new System.Drawing.Size(876, 225);
            this.vendor_Search1.TabIndex = 0;
            // 
            // SellTxnEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 332);
            this.Controls.Add(this.vendor_Search1);
            this.Name = "SellTxnEntry";
            this.Text = "Sell Entry";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.ucVendorSearch vendor_Search1;
    }
}