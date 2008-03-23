﻿using System;
using System.Threading;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool isFirstInstance;
            // Utilisation d'un seul Mutex pour éviter les conflits
            using (Mutex mtx = new Mutex(true, "EsGace", out isFirstInstance))
            {
                if (isFirstInstance)
                {
                    Application.Run(new Forms.PrincipaleForm());
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
