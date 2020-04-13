using System;
using System.Windows.Forms;

namespace COMP3005
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //initialize pages
            UserPage user = new UserPage();
            Login login = new Login();

            Application.Run(login);
        }
    }
}