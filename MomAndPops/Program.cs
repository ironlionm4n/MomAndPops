using MomAndPops.Resources;
using System;
using System.Windows.Forms;

namespace MomAndPops
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
            //Application.Run(new LoginPage());
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            Application.Run();
        }
    }
}
