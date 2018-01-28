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
        }
        
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            using (MyShopDB_Entities mse = new MyShopDB_Entities())
            {
                Login _login = mse.Logins.Where(x => x.UserName.ToString().ToUpper() == txtUserName.Text.ToString().ToUpper()).FirstOrDefault();
                if (_login.Password==txtPassword.Text)
                {
                    MainView mv = new MainView((_login.FirstName +" "+ _login.LastName).ToString());
                    mv.Show();
                    mv.WindowState = FormWindowState.Maximized;
                    
                }
                else
                {
                    MessageBox.Show("Incorrect UserName or Password");
                }
            }
        }
    }
}
