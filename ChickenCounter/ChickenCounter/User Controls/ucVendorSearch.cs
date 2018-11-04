using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickenCounter.User_Controls
{
    public partial class ucVendorSearch : UserControl
    {
        public ucVendorSearch()
        {
            InitializeComponent();
            ValidateSearchOption();
        }

        private void ValidateSearchOption()
        {
            if (txtVendorID.Text!="")
            {
                txtFName.Enabled = false;
                txtLName.Enabled = false;
                txtMobileNo.Enabled = false;
                btn_Search.Enabled = true;
            }
            else if (txtFName.Text != "")
            {
                txtVendorID.Enabled = false;
                txtLName.Enabled = false;
                txtMobileNo.Enabled = false;
                btn_Search.Enabled = true;
            }
            else if (txtLName.Text != "")
            {
                txtVendorID.Enabled = false;
                txtFName.Enabled = false;
                txtMobileNo.Enabled = false;
                btn_Search.Enabled = true;
            }
            else if (txtMobileNo.Text != "")
            {
                txtVendorID.Enabled = false;
                txtFName.Enabled = false;
                txtLName.Enabled = false;
                btn_Search.Enabled = true;
            }
            else
            {
                txtVendorID.Enabled = true;
                txtFName.Enabled = true;
                txtLName.Enabled = true;
                txtMobileNo.Enabled = true;
                btn_Search.Enabled = false;

            }
        }
          
        private void btn_Serach_Click(object sender, EventArgs e)
        {
            List<Model.Vendor> Vendor = VendorSearch(txtFName.Text);

            if(Vendor.Count != 0)
                dgVendor.DataSource = Vendor;
        }

        private List<Model.Vendor> VendorSearch(int VendorId)
        {
            List<Model.Vendor> Ven = new List<Model.Vendor>();

            using (MyShopDB_Entities mse = new MyShopDB_Entities())
            {
                List<Vendor> dbData = mse.Vendors.Where(x => x.VendorID == VendorId).ToList();
                foreach (var i in dbData)
                {
                    Model.Vendor vn = new Model.Vendor(i.VendorID, i.FirstName, i.LastName, i.MobileNo, i.CreditLimit);
                    Ven.Add(vn);
                }
            }
            return Ven;
        }
        private List<Model.Vendor> VendorSearch(string Vendor_name)
        {
            List<Model.Vendor> Ven = new List<Model.Vendor>();

            using (MyShopDB_Entities mse = new MyShopDB_Entities())
            {
                List<Vendor> dbData = mse.Vendors.Where(x => x.FirstName == Vendor_name || x.LastName == Vendor_name).ToList();
                foreach (var i in dbData)
                {
                    Model.Vendor vn = new Model.Vendor(i.VendorID, i.FirstName, i.LastName, i.MobileNo, i.CreditLimit);
                    Ven.Add(vn);
                }
            }
            return Ven;
        }

        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            ValidateSearchOption();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            ValidateSearchOption();
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            ValidateSearchOption();
        }

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {
            ValidateSearchOption();
        }
    }
}
