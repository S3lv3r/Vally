using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jungle_Math
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Boolean IsEmpty = false;
            using(StreamReader SR = new StreamReader("UsernameDB.txt"))
            {
                string m = SR.ReadToEnd();
                if (string.IsNullOrWhiteSpace(m))
                {
                    IsEmpty = true;
                }
            }
            if (IsEmpty)
            {
                Application.Run(new FrmUser());
            }
            else
            {
                Application.Run(new MainMenu());
            }
            
        }
    }
}
