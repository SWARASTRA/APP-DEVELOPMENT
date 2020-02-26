using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using ChickenCounter.Model;

namespace ChickenCounter.Utils
{
    public partial class Set_Price : Form
    {
        string kg_price;
        string pc_price;
        int kgid;
        int pcid;
        int AdminId;
        public Set_Price(int Id)
        {
            InitializeComponent();
            AdminId = Id;
            lb_adminID.Text = AdminId.ToString();
            using (MyShopDB_Entities mse = new MyShopDB_Entities())
            {
                kgid = (int)(mse.LOOKUP_CODE.Where(x => x.DESCRIPTION == "PER_KG_PRICE").Select(x => x.LOOKUP_CODE1).FirstOrDefault());
                kg_price = mse.LOOKUP_VALUE.Where(a => a.LOOKUP_CODE_ID == kgid).Select(a => a.DESCRIPTION).FirstOrDefault().ToString();

                pcid = (int)(mse.LOOKUP_CODE.Where(x => x.DESCRIPTION == "PER_PIECE_PRICE").Select(x => x.LOOKUP_CODE1).FirstOrDefault());
                pc_price = mse.LOOKUP_VALUE.Where(a => a.LOOKUP_CODE_ID == pcid).Select(a => a.DESCRIPTION).FirstOrDefault().ToString();
            }

            txt_OldKgsPrice.Text = "Rs. " + kg_price;
            txt_OldUnitPrice.Text= "Rs. " + pc_price;
        }

        private void btnSetPrice_Click(object sender, EventArgs e)
        {
            if (txt_NewKgsPrice != null && txt_NewUnitPrice != null)
            {
                float kgp;
                float up;
                bool kgppasssed = float.TryParse(txt_NewKgsPrice.Text, out kgp);
                bool uppassed = float.TryParse(txt_NewUnitPrice.Text, out up);

                if(kgppasssed && uppassed)
                {
                    UpdateDB(kgp, up);
                }
            }
        }
        private void UpdateDB(float kgp, float up)
        {
            try
            {
                using (MyShopDB_Entities mse = new MyShopDB_Entities())
                {
                    LOOKUP_VALUE kglv = mse.LOOKUP_VALUE.Where(a => a.LOOKUP_CODE_ID == kgid).FirstOrDefault();
                    LOOKUP_VALUE pclv = mse.LOOKUP_VALUE.Where(a => a.LOOKUP_CODE_ID == pcid).FirstOrDefault();
                    kglv.DESCRIPTION = kgp.ToString();
                    kglv.MODIFIED_ON = System.DateTime.Now;
                    kglv.MODIFIED_BY = Master.GetNamebyID(AdminId);
                    pclv.DESCRIPTION = up.ToString();
                    pclv.MODIFIED_ON = System.DateTime.Now;
                    pclv.MODIFIED_BY = Master.GetNamebyID(AdminId);
                    mse.SaveChanges();
                }
                MessageBox.Show("Updated Sucessfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

        }
    }
}
