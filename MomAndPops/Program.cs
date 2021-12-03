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
        
        public static LoginPage loginPageInstance;

        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                loginPageInstance = new LoginPage();
                Application.Run(loginPageInstance);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Message: " + e.Message + " > "  + e.StackTrace);
            }
        }
    }
}
