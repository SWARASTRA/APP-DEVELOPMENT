using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenCounter.Model
{
    class Vendor
    {
        public Vendor(int vendorID, string firstName, string lastName, string mobileNo, int creditLimit)
        {
            Vendor_ID = vendorID;
            Vendor_Fname = firstName;
            Vendor_Lname = lastName;
            Vendor_MobNo = mobileNo;
            Vendor_CrdtLimit = creditLimit;
        }

        private int Vendor_ID;

        public int VendorID
        {
            get { return Vendor_ID; }
            set { Vendor_ID = value; }
        }

        private string Vendor_Fname;

        public string VendorFirstName
        {
            get { return Vendor_Fname; }
            set { Vendor_Fname = value; }
        }

        private string Vendor_Lname;

        public string VendorLastName
        {
            get { return Vendor_Lname; }
            set { Vendor_Lname = value; }
        }

        private string Vendor_MobNo;

        public string VendorMobileNo
        {
            get { return Vendor_MobNo; }
            set { Vendor_MobNo = value; }
        }

        private int Vendor_CrdtLimit;

        public int VendorCreditLimit
        {
            get { return Vendor_CrdtLimit; }
            set { Vendor_CrdtLimit = value; }
        }


    }
}
