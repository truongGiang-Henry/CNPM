using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
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
            if(ConfigurationManager.ConnectionStrings["Final_Project.Properties.Settings.QLPTConnectionString"].ConnectionString == "")
            {
                Application.Run(new CauHinh());
            }
            else
            {
                Application.Run(new Login());
            }
                 
        }
    }
}
