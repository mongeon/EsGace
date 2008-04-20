using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using EsGace.Classes;
using EsGace.Forms;

namespace EsGace
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal du programme.
        /// </summary>
        [STAThread]
        static void Main()
        {
             // Test de culture anglaise
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-ca",false);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool isFirstInstance;
            // Utilisation d'un seul Mutex pour éviter les conflits
            using (Mutex mtx = new Mutex(true, "EsGace", out isFirstInstance))
            {
                if (isFirstInstance)
                {
                    Classes.SplashAppContext splashContext = 
                        new SplashAppContext(new Forms.PrincipaleForm(), new Demarrage());
                    Application.Run(splashContext);
                    //Application.Run(new Forms.PrincipaleForm());
                }
                else
                {
                    // The application is already running
                    // TODO: Display message box or change focus to existing application instance
                    MessageBox.Show("EsGace est déjà ouvert");

                }
            } // releases the Mutex
        }
    }
}
