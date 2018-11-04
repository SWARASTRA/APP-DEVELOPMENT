using ChickenCounter.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickenCounter
{
    public partial class MainView : Form
    {
        int LoginAdminId;
        public MainView(View.LogIn _loginInfo)
        {
            InitializeComponent();
            lbUserName.Text = _loginInfo.FirstName + " " + _loginInfo.LastName;
            LoginAdminId = _loginInfo.AdminId;
            this.WindowState = FormWindowState.Maximized;
        }

        private void addVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseTxn_Click(object sender, EventArgs e)
        {
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVendorForm addVendor = new View.AddVendorForm(LoginAdminId);
            addVendor.ShowDialog();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellTxnEntry sellEntry = new View.SellTxnEntry();
            sellEntry.ShowDialog();
        }
    }
}
