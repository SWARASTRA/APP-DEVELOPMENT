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
    public partial class SellTxnEntry : Form
    {
        public SellTxnEntry(int Id)
        {
            InitializeComponent();
            lb_adminID.Text = Id.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
