﻿using ChickenCounter.View;
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
        public MainView(string UserName)
        {
            InitializeComponent();
            lbUserName.Text = UserName;
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
            AddVendorForm addVendor = new View.AddVendorForm();
            addVendor.ShowDialog();
        }
    }
}
