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
    public partial class AddVendorForm : Form
    {
        int AdminID;
        bool IsSuccessfulAdd = false;
        public AddVendorForm(int Id)
        {
            InitializeComponent();
            AdminID = Id;
            lb_adminID.Text = AdminID.ToString();
        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int NewVendorId = GenerateVendorID();
            Vendor ven = new Vendor { VendorID = NewVendorId, FirstName = txt_Fname.Text, LastName = txt_Lname.Text, CreditLimit = int.Parse(txt_CrdtLmt.Text), MobileNo = txt_Mno.Text, AdminID = AdminID };
            AddVendor(ven);
            if(IsSuccessfulAdd)
            {
                this.Close();
                MessageBox.Show("Vendor Added Successfully with Id "+ NewVendorId.ToString());
            }
        }

        private void AddVendor(Vendor Vndr)
        {
            using (MyShopDB_Entities mse = new MyShopDB_Entities())
            {
                mse.Vendors.Add(Vndr);
                mse.SaveChanges();
                IsSuccessfulAdd = true;
            }
        }
        private int GenerateVendorID()
        {
            int Old_id;
            using (MyShopDB_Entities mse = new MyShopDB_Entities())
            {
                Old_id = mse.Vendors.Max(x => (int)x.VendorID);
            }
            int New_Id = Old_id + 1;

            return New_Id;
        }
    }
}
