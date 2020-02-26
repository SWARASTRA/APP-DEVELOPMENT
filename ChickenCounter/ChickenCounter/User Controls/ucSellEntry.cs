using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ChickenCounter.User_Controls
{
    public partial class ucSellEntry : UserControl
    {
        bool IsSuccessfulEntry = false;
        string kg_price;
        string pc_price;
        string ErrorMessages;
        public ucSellEntry()
        {
            InitializeComponent();
            DefaultSet();
            btn_Search.Enabled = false;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

        }
        private void DefaultSet()
        {
            using (MyShopDB_Entities mse = new MyShopDB_Entities())
            {
                int kgid = (int)(mse.LOOKUP_CODE.Where(x => x.DESCRIPTION == "PER_KG_PRICE").Select(x => x.LOOKUP_CODE1).FirstOrDefault());
                kg_price = mse.LOOKUP_VALUE.Where(a=>a.LOOKUP_CODE_ID == kgid).Select(a=>a.DESCRIPTION).FirstOrDefault().ToString();

                int pcid = (int)(mse.LOOKUP_CODE.Where(x => x.DESCRIPTION == "PER_PIECE_PRICE").Select(x => x.LOOKUP_CODE1).FirstOrDefault());
                pc_price = mse.LOOKUP_VALUE.Where(a => a.LOOKUP_CODE_ID == pcid).Select(a => a.DESCRIPTION).FirstOrDefault().ToString();
            }

            txt_PerKgPrice.Text = "Rs. " + kg_price;
            txt_PerPcPrice.Text = "Rs. " + pc_price;
            txt_TotalKgs.Enabled = false;
            txt_TotalPiece.Enabled = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Vendor Vdr = null;
            if (!String.IsNullOrEmpty(txt_Mno.Text))
            {
                Vdr = VendorSearch(txt_Mno.Text);
            }

            if (Vdr != null)
            {
                txt_Fname.Text = Vdr.FirstName;
                txt_Lname.Text = Vdr.LastName;
                txt_CrdtLmt.Text = "Rs. " + Vdr.CreditLimit.ToString();
                txt_TotalKgs.Enabled = true;
                txt_TotalPiece.Enabled = true;
                if (Vdr.CreditLimit <= 100)
                {
                    txt_CrdtLmt.BackColor = Color.OrangeRed;
                }
            }

        }
        private Vendor VendorSearch(string Vendor_MobileNo)
        {
            using (MyShopDB_Entities mse = new MyShopDB_Entities())
            {
                Vendor Ven = mse.Vendors.Where(x => x.MobileNo == Vendor_MobileNo).FirstOrDefault();
                return Ven;
            }
        }

        private void txt_Mno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txt_Mno_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = false;
            if (!string.IsNullOrEmpty(txt_Fname.Text))
            {
                txt_Fname.Clear();
                txt_Lname.Clear();
                txt_CrdtLmt.Clear();
                txt_TotalKgs.Clear();
                txt_TotalPiece.Clear();
                txt_TotalKgs.Enabled = false;
                txt_TotalPiece.Enabled = false;
            }
            if (txt_Mno.TextLength == 10)
            {
                btn_Search.Enabled = true;
            }
        }
        private void AddVendorTransaction(VendorTransaction VndrTxn)
        {
            using (MyShopDB_Entities mse = new MyShopDB_Entities())
            {
                mse.VendorTransactions.Add(VndrTxn);
                mse.SaveChanges();
                IsSuccessfulEntry = true;
            }
        }
        private VendorTransaction GetValidVendorTxn()
        {
            ErrorMessages = string.Empty;
            VendorTransaction _vendorTxn = null;
            float TotalSellAmmount = GetTotalAmount();



            return _vendorTxn;

        }
        private float GetTotalAmount()
        {
            float Kgs = 0;
            float Piece = 0;

            float PerKgPrice = (float)(int.Parse(kg_price));
            float PerPiecePrice = (float)(int.Parse(pc_price));

            if (!string.IsNullOrEmpty(txt_TotalPiece.Text))
            {
                int _Piece = int.Parse(txt_TotalPiece.Text);
                Piece = (float)_Piece;
            }

            if (!string.IsNullOrEmpty(txt_TotalKgs.Text))
            {
                int _Kgs = int.Parse(txt_TotalKgs.Text);
                Kgs = (float)_Kgs;
            }
            float TotalSellPrice = (Piece * PerPiecePrice) + (Kgs * PerKgPrice);
            txt_TotalAmnt.Text = "Rs. " + TotalSellPrice.ToString();
            return TotalSellPrice;
        }

        private void txt_TotalPiece_TextChanged(object sender, EventArgs e)
        {
            GetTotalAmount();
        }
    }
}
