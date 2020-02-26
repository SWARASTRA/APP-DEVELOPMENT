namespace ChickenCounter.User_Controls
{
    partial class ucSellEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMobileNumber = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Mno = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_CrdtAmnt = new System.Windows.Forms.TextBox();
            this.txt_TotalAmnt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PaidAmnt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelCreditLimit = new System.Windows.Forms.Label();
            this.txt_CrdtLmt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_PerKgPrice = new System.Windows.Forms.TextBox();
            this.txt_PerPcPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TotalKgs = new System.Windows.Forms.TextBox();
            this.txt_TotalPiece = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 290);
            this.panel1.TabIndex = 27;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.labelMobileNumber, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Search, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_Mno, 1, 0);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(470, 38);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // labelMobileNumber
            // 
            this.labelMobileNumber.AutoSize = true;
            this.labelMobileNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelMobileNumber.Location = new System.Drawing.Point(3, 0);
            this.labelMobileNumber.Name = "labelMobileNumber";
            this.labelMobileNumber.Size = new System.Drawing.Size(134, 21);
            this.labelMobileNumber.TabIndex = 2;
            this.labelMobileNumber.Text = "Mobile Number :";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(344, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(115, 32);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Mno
            // 
            this.txt_Mno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Mno.Location = new System.Drawing.Point(143, 3);
            this.txt_Mno.MaxLength = 10;
            this.txt_Mno.Name = "txt_Mno";
            this.txt_Mno.Size = new System.Drawing.Size(195, 29);
            this.txt_Mno.TabIndex = 6;
            this.txt_Mno.TextChanged += new System.EventHandler(this.txt_Mno_TextChanged);
            this.txt_Mno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Mno_KeyPress);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.txt_CrdtAmnt, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_TotalAmnt, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_PaidAmnt, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 239);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(470, 39);
            this.tableLayoutPanel4.TabIndex = 25;
            // 
            // txt_CrdtAmnt
            // 
            this.txt_CrdtAmnt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CrdtAmnt.ForeColor = System.Drawing.Color.Red;
            this.txt_CrdtAmnt.Location = new System.Drawing.Point(385, 3);
            this.txt_CrdtAmnt.Name = "txt_CrdtAmnt";
            this.txt_CrdtAmnt.ReadOnly = true;
            this.txt_CrdtAmnt.Size = new System.Drawing.Size(83, 23);
            this.txt_CrdtAmnt.TabIndex = 26;
            // 
            // txt_TotalAmnt
            // 
            this.txt_TotalAmnt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalAmnt.ForeColor = System.Drawing.Color.Red;
            this.txt_TotalAmnt.Location = new System.Drawing.Point(223, 3);
            this.txt_TotalAmnt.Name = "txt_TotalAmnt";
            this.txt_TotalAmnt.ReadOnly = true;
            this.txt_TotalAmnt.Size = new System.Drawing.Size(83, 23);
            this.txt_TotalAmnt.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Paid Amt :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Credit Amt :";
            // 
            // txt_PaidAmnt
            // 
            this.txt_PaidAmnt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PaidAmnt.Location = new System.Drawing.Point(67, 3);
            this.txt_PaidAmnt.Name = "txt_PaidAmnt";
            this.txt_PaidAmnt.Size = new System.Drawing.Size(83, 23);
            this.txt_PaidAmnt.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(156, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Total Amt :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.12963F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.87037F));
            this.tableLayoutPanel1.Controls.Add(this.txt_Lname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Fname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCreditLimit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_CrdtLmt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFirstName, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 90);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(3, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(93, 21);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name :";
            // 
            // txt_Lname
            // 
            this.txt_Lname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lname.Location = new System.Drawing.Point(201, 32);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.ReadOnly = true;
            this.txt_Lname.Size = new System.Drawing.Size(163, 23);
            this.txt_Lname.TabIndex = 5;
            // 
            // txt_Fname
            // 
            this.txt_Fname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fname.Location = new System.Drawing.Point(201, 3);
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.ReadOnly = true;
            this.txt_Fname.Size = new System.Drawing.Size(163, 23);
            this.txt_Fname.TabIndex = 4;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(3, 29);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(91, 21);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name :";
            // 
            // labelCreditLimit
            // 
            this.labelCreditLimit.AutoSize = true;
            this.labelCreditLimit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreditLimit.Location = new System.Drawing.Point(3, 58);
            this.labelCreditLimit.Name = "labelCreditLimit";
            this.labelCreditLimit.Size = new System.Drawing.Size(98, 21);
            this.labelCreditLimit.TabIndex = 3;
            this.labelCreditLimit.Text = "Credit Limit :";
            // 
            // txt_CrdtLmt
            // 
            this.txt_CrdtLmt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CrdtLmt.Location = new System.Drawing.Point(201, 61);
            this.txt_CrdtLmt.Name = "txt_CrdtLmt";
            this.txt_CrdtLmt.ReadOnly = true;
            this.txt_CrdtLmt.Size = new System.Drawing.Size(163, 23);
            this.txt_CrdtLmt.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.txt_PerKgPrice, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_PerPcPrice, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_TotalKgs, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_TotalPiece, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 158);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(470, 65);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // txt_PerKgPrice
            // 
            this.txt_PerKgPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PerKgPrice.ForeColor = System.Drawing.Color.Red;
            this.txt_PerKgPrice.Location = new System.Drawing.Point(332, 32);
            this.txt_PerKgPrice.Name = "txt_PerKgPrice";
            this.txt_PerKgPrice.ReadOnly = true;
            this.txt_PerKgPrice.Size = new System.Drawing.Size(135, 23);
            this.txt_PerKgPrice.TabIndex = 25;
            // 
            // txt_PerPcPrice
            // 
            this.txt_PerPcPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PerPcPrice.ForeColor = System.Drawing.Color.Red;
            this.txt_PerPcPrice.Location = new System.Drawing.Point(332, 3);
            this.txt_PerPcPrice.Name = "txt_PerPcPrice";
            this.txt_PerPcPrice.ReadOnly = true;
            this.txt_PerPcPrice.Size = new System.Drawing.Size(135, 23);
            this.txt_PerPcPrice.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Pieces :";
            // 
            // txt_TotalKgs
            // 
            this.txt_TotalKgs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalKgs.Location = new System.Drawing.Point(97, 32);
            this.txt_TotalKgs.Name = "txt_TotalKgs";
            this.txt_TotalKgs.Size = new System.Drawing.Size(135, 23);
            this.txt_TotalKgs.TabIndex = 5;
            this.txt_TotalKgs.TextChanged += new System.EventHandler(this.txt_TotalPiece_TextChanged);
            // 
            // txt_TotalPiece
            // 
            this.txt_TotalPiece.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalPiece.Location = new System.Drawing.Point(97, 3);
            this.txt_TotalPiece.Name = "txt_TotalPiece";
            this.txt_TotalPiece.Size = new System.Drawing.Size(135, 23);
            this.txt_TotalPiece.TabIndex = 4;
            this.txt_TotalPiece.TextChanged += new System.EventHandler(this.txt_TotalPiece_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Kgs :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(238, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Price Per Piece :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Price Per Kgs :";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Submit.Location = new System.Drawing.Point(408, 304);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 32);
            this.btn_Submit.TabIndex = 16;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // ucSellEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Submit);
            this.Name = "ucSellEntry";
            this.Size = new System.Drawing.Size(508, 342);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelMobileNumber;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Mno;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txt_CrdtAmnt;
        private System.Windows.Forms.TextBox txt_TotalAmnt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PaidAmnt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelCreditLimit;
        private System.Windows.Forms.TextBox txt_CrdtLmt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_PerKgPrice;
        private System.Windows.Forms.TextBox txt_PerPcPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TotalKgs;
        private System.Windows.Forms.TextBox txt_TotalPiece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
