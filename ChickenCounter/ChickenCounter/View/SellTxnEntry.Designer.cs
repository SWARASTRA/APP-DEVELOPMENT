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
            this.lb_adminID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucSellEntry = new ChickenCounter.User_Controls.ucSellEntry();
            this.SuspendLayout();
            // 
            // lb_adminID
            // 
            this.lb_adminID.AutoSize = true;
            this.lb_adminID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lb_adminID.ForeColor = System.Drawing.Color.Red;
            this.lb_adminID.Location = new System.Drawing.Point(408, 6);
            this.lb_adminID.Name = "lb_adminID";
            this.lb_adminID.Size = new System.Drawing.Size(68, 19);
            this.lb_adminID.TabIndex = 17;
            this.lb_adminID.Text = "_adminID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Admin ID : ";
            // 
            // ucSellEntry1
            // 
            this.ucSellEntry.Location = new System.Drawing.Point(6, 28);
            this.ucSellEntry.Name = "ucSellEntry";
            this.ucSellEntry.Size = new System.Drawing.Size(508, 345);
            this.ucSellEntry.TabIndex = 18;
            // 
            // SellTxnEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(520, 386);
            this.Controls.Add(this.ucSellEntry);
            this.Controls.Add(this.lb_adminID);
            this.Controls.Add(this.label1);
            this.Name = "SellTxnEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_adminID;
        private System.Windows.Forms.Label label1;
        private User_Controls.ucSellEntry ucSellEntry;
    }
}