using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static bool IsAdminRole()
        {
            return Properties.Settings.Default.IsAdmin;
                
        }
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            if (Properties.Settings.Default.RememberMe)
            {
                // If "RememberCredentials" is true, open the form for password entry
                Application.Run(new MainMenu());
              
         
            }
            else
            {
                // If "RememberCredentials" is false, open the regular login form
                Application.Run(new NGOManagementSystem());
            }

        }
    }
}
