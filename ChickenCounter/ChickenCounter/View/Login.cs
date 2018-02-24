﻿using System;
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
        }

        public bool IsSucessfull { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect UserName or Password");
                }
            }
        }
    }
}
