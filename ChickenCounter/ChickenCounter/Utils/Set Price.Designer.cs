namespace ChickenCounter.Utils
{
    partial class Set_Price
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NewKgsPrice = new System.Windows.Forms.TextBox();
            this.txt_NewUnitPrice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_OldKgsPrice = new System.Windows.Forms.TextBox();
            this.txt_OldUnitPrice = new System.Windows.Forms.TextBox();
            this.btn_SetPrice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_adminID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Per Unit Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Per Kgs. Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Per Kgs. Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Per Unit Price :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NewKgsPrice);
            this.groupBox1.Controls.Add(this.txt_NewUnitPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(245, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Data";
            // 
            // txt_NewKgsPrice
            // 
            this.txt_NewKgsPrice.Location = new System.Drawing.Point(101, 50);
            this.txt_NewKgsPrice.Name = "txt_NewKgsPrice";
            this.txt_NewKgsPrice.Size = new System.Drawing.Size(108, 22);
            this.txt_NewKgsPrice.TabIndex = 9;
            // 
            // txt_NewUnitPrice
            // 
            this.txt_NewUnitPrice.Location = new System.Drawing.Point(101, 26);
            this.txt_NewUnitPrice.Name = "txt_NewUnitPrice";
            this.txt_NewUnitPrice.Size = new System.Drawing.Size(108, 22);
            this.txt_NewUnitPrice.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_OldKgsPrice);
            this.groupBox2.Controls.Add(this.txt_OldUnitPrice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Old Data";
            // 
            // txt_OldKgsPrice
            // 
            this.txt_OldKgsPrice.Location = new System.Drawing.Point(102, 49);
            this.txt_OldKgsPrice.Name = "txt_OldKgsPrice";
            this.txt_OldKgsPrice.ReadOnly = true;
            this.txt_OldKgsPrice.Size = new System.Drawing.Size(108, 22);
            this.txt_OldKgsPrice.TabIndex = 7;
            // 
            // txt_OldUnitPrice
            // 
            this.txt_OldUnitPrice.Location = new System.Drawing.Point(102, 25);
            this.txt_OldUnitPrice.Name = "txt_OldUnitPrice";
            this.txt_OldUnitPrice.ReadOnly = true;
            this.txt_OldUnitPrice.Size = new System.Drawing.Size(108, 22);
            this.txt_OldUnitPrice.TabIndex = 6;
            // 
            // btn_SetPrice
            // 
            this.btn_SetPrice.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetPrice.Location = new System.Drawing.Point(206, 132);
            this.btn_SetPrice.Name = "btn_SetPrice";
            this.btn_SetPrice.Size = new System.Drawing.Size(75, 23);
            this.btn_SetPrice.TabIndex = 6;
            this.btn_SetPrice.Text = "Update";
            this.btn_SetPrice.UseVisualStyleBackColor = true;
            this.btn_SetPrice.Click += new System.EventHandler(this.btnSetPrice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(343, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Admin ID : ";
            // 
            // lb_adminID
            // 
            this.lb_adminID.AccessibleName = "";
            this.lb_adminID.AutoSize = true;
            this.lb_adminID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lb_adminID.ForeColor = System.Drawing.Color.Red;
            this.lb_adminID.Location = new System.Drawing.Point(405, 154);
            this.lb_adminID.Name = "lb_adminID";
            this.lb_adminID.Size = new System.Drawing.Size(39, 19);
            this.lb_adminID.TabIndex = 14;
            this.lb_adminID.Text = "1234";
            // 
            // Set_Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(491, 179);
            this.Controls.Add(this.lb_adminID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_SetPrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Set_Price";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Price";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NewKgsPrice;
        private System.Windows.Forms.TextBox txt_NewUnitPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_OldKgsPrice;
        private System.Windows.Forms.TextBox txt_OldUnitPrice;
        private System.Windows.Forms.Button btn_SetPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_adminID;
    }
}