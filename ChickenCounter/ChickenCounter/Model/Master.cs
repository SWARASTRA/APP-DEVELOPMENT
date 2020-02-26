using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenCounter.Model
{
    static class Master
    {
        public static string GetNamebyID(int id)
        {
            string name = string.Empty;
            using (MyShopDB_Entities mse = new MyShopDB_Entities())
            {
                string fname = mse.Logins.Where(a => a.PersonID == id).Select(a => a.FirstName).FirstOrDefault();
                string lname = mse.Logins.Where(a => a.PersonID == id).Select(a => a.LastName).FirstOrDefault();

                name = fname + " " + lname;
            }
            return name;
        }
    }
}
