using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickenCounter.View
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            if(txtUserName.Text !=string.Empty && txtPassword.Text!=string.Empty)
            {
                btnSignIn.Enabled = true;
            }
        }

        public bool IsSucessfull { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AdminId { get; set; }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            using (MyShopDB_Entities mse = new MyShopDB_Entities())
            {
                Login _login = mse.Logins.Where(x => x.UserName.ToString().ToUpper() == txtUserName.Text.ToString().ToUpper()).FirstOrDefault();
                IsSucessfull = (_login.Password == txtPassword.Text);
                if (IsSucessfull)
                {
                    FirstName = _login.FirstName;
                    LastName = _login.LastName;
                    AdminId = _login.PersonID;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect UserName or Password");
                }
            }
        }

        //Used for Development Testing purpose
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtUserName.Text = "admin";
                txtPassword.Text = "admin";

            }
        }
    }
}
