using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickenCounter.View
{
    public partial class AddVendorForm : Form
    {
        int AdminID;
        bool IsSuccessfulAdd = false;
        string ErrorMessages;
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

            Vendor ven = GetValidVendor();
            if(ven != null)
                AddVendor(ven);
            if(IsSuccessfulAdd)
            {
                this.Close();
                MessageBox.Show("Vendor Added Successfully with Id "+ ven.VendorID.ToString());
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
        private Vendor GetValidVendor()
        {
            ErrorMessages = string.Empty;
            Vendor _vendor = null;
            bool IsMobileNumber = Regex.Match(txt_Mno.Text, "^[7-9][0-9]{9}$").Success;
            if (IsMobileNumber)
            {
                bool ifExist = CheckIfVendorExists(txt_Mno.Text);
                if(!ifExist)
                {
                    bool IsFirstName = Regex.Match(txt_Fname.Text.ToUpper(), "^[A-Z][a-zA-Z]*$").Success;
                    bool IsLastName = Regex.Match(txt_Lname.Text.ToUpper(), "^[A-Z][a-zA-Z]*$").Success;
                    
                    if (!IsFirstName)
                    {
                        ErrorMessages += "- First Name is Not Correct \r\n";
                    }
                    if (!IsLastName)
                    {
                        ErrorMessages += "- Last Name is Not Correct \r\n";
                    }
                    bool IsCreditLimit = ValidateCreditLimit();
                }
            }
            else
            {
                ErrorMessages += "- Mobile Number is Not Correct \r\n";
            }
             
            if (!String.IsNullOrEmpty(ErrorMessages))
                MessageBox.Show(ErrorMessages, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int NewVendorId = GenerateVendorID();
                _vendor= new Vendor { VendorID = NewVendorId, FirstName = txt_Fname.Text.ToUpper(), LastName = txt_Lname.Text.ToUpper(), CreditLimit = int.Parse(txt_CrdtLmt.Text), MobileNo = txt_Mno.Text, AdminID = AdminID };
            }
            return _vendor;
        }

        private bool ValidateCreditLimit()
        {
            int Crdt_Limit;
            bool IsSusess = int.TryParse(txt_CrdtLmt.Text, out Crdt_Limit);
            if(!IsSusess)
            {
                ErrorMessages += "- Credit Limit Can not be Blank or Letter \r\n";
                return false;
            }
            if (IsSusess && Crdt_Limit > 25000)
            {
                ErrorMessages += "- Credit Limit Can not greater than 25000 \r\n";
                return false;
            }
            else
                return true;
        }
        private bool CheckIfVendorExists (string MobileNumber)
        {
            using (MyShopDB_Entities mse = new MyShopDB_Entities())
            {
                List<Vendor> vendr = mse.Vendors.Where(x => x.MobileNo == MobileNumber).ToList();
                if(vendr.Count()==0)
                {
                    return false;
                }
                else
                {
                    ErrorMessages += "- Vendor is Already Exists on this Mobile Number\r\n";
                    return true;
                }
            }
        }
    }
}
