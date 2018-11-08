namespace ChickenCounter.View
{
    partial class AddVendorForm
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMobileNumber = new System.Windows.Forms.Label();
            this.labelCreditLimit = new System.Windows.Forms.Label();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.txt_Mno = new System.Windows.Forms.TextBox();
            this.txt_CrdtLmt = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_adminID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelFirstName.Location = new System.Drawing.Point(3, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(96, 21);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name :";
            this.labelFirstName.Click += new System.EventHandler(this.labelFirstName_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelLastName.Location = new System.Drawing.Point(3, 36);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(94, 21);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name :";
            // 
            // labelMobileNumber
            // 
            this.labelMobileNumber.AutoSize = true;
            this.labelMobileNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelMobileNumber.Location = new System.Drawing.Point(3, 72);
            this.labelMobileNumber.Name = "labelMobileNumber";
            this.labelMobileNumber.Size = new System.Drawing.Size(134, 21);
            this.labelMobileNumber.TabIndex = 2;
            this.labelMobileNumber.Text = "Mobile Number :";
            // 
            // labelCreditLimit
            // 
            this.labelCreditLimit.AutoSize = true;
            this.labelCreditLimit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelCreditLimit.Location = new System.Drawing.Point(3, 108);
            this.labelCreditLimit.Name = "labelCreditLimit";
            this.labelCreditLimit.Size = new System.Drawing.Size(103, 21);
            this.labelCreditLimit.TabIndex = 3;
            this.labelCreditLimit.Text = "Credit Limit :";
            // 
            // txt_Fname
            // 
            this.txt_Fname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Fname.Location = new System.Drawing.Point(176, 3);
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(195, 29);
            this.txt_Fname.TabIndex = 4;
            this.txt_Fname.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // txt_Lname
            // 
            this.txt_Lname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Lname.Location = new System.Drawing.Point(176, 39);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(195, 29);
            this.txt_Lname.TabIndex = 5;
            // 
            // txt_Mno
            // 
            this.txt_Mno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Mno.Location = new System.Drawing.Point(176, 75);
            this.txt_Mno.Name = "txt_Mno";
            this.txt_Mno.Size = new System.Drawing.Size(195, 29);
            this.txt_Mno.TabIndex = 6;
            // 
            // txt_CrdtLmt
            // 
            this.txt_CrdtLmt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_CrdtLmt.Location = new System.Drawing.Point(176, 111);
            this.txt_CrdtLmt.Name = "txt_CrdtLmt";
            this.txt_CrdtLmt.Size = new System.Drawing.Size(195, 29);
            this.txt_CrdtLmt.TabIndex = 7;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Submit.Location = new System.Drawing.Point(323, 173);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 32);
            this.btn_Submit.TabIndex = 8;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.12963F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.87037F));
            this.tableLayoutPanel1.Controls.Add(this.txt_CrdtLmt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelMobileNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Mno, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCreditLimit, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Lname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Fname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLastName, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 146);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Admin ID : ";
            // 
            // lb_adminID
            // 
            this.lb_adminID.AutoSize = true;
            this.lb_adminID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lb_adminID.ForeColor = System.Drawing.Color.Red;
            this.lb_adminID.Location = new System.Drawing.Point(63, 214);
            this.lb_adminID.Name = "lb_adminID";
            this.lb_adminID.Size = new System.Drawing.Size(0, 19);
            this.lb_adminID.TabIndex = 13;
            // 
            // AddVendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(479, 232);
            this.Controls.Add(this.lb_adminID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_Submit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(495, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(495, 271);
            this.Name = "AddVendorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddVendorForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMobileNumber;
        private System.Windows.Forms.Label labelCreditLimit;
        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.TextBox txt_Mno;
        private System.Windows.Forms.TextBox txt_CrdtLmt;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_adminID;
    }
}