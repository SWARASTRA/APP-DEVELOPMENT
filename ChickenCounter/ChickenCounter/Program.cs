using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickenCounter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            View.LogIn _login = new View.LogIn();
            Application.Run(_login);
            if(_login.IsSucessfull)
            {
                Application.Run(new MainView(_login));
            }
        }
    }
}
