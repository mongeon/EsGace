

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EsGace.Forms;

namespace EsGace.Classes
{
    /// <summary>
    /// This class come from John Conwell example
    /// http://www.c-sharpcorner.com/UploadFile/johnconwell/ApplicationContexttoEncapsulateSplashScreenFunctionality11232005041406AM/ApplicationContexttoEncapsulateSplashScreenFunctionality.aspx
    /// </summary>
    class SplashAppContext : ApplicationContext
    {
        Form  mainForm = null;
        Timer splashTimer = new Timer();
        public SplashAppContext(Form mainForm, Form splashForm)
            : base(splashForm)
        {
            this.mainForm = mainForm;
            splashTimer.Tick += new EventHandler(SplashTimeUp);
            
            splashTimer.Interval = 2000;
            splashTimer.Enabled = true;
        }

        private void SplashTimeUp(object sender, EventArgs e)
        {
            splashTimer.Enabled = false;
            splashTimer.Dispose();
            base.MainForm.Close();
        }
        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            if (sender is Demarrage)
            {
                base.MainForm = this.mainForm;
                base.MainForm.Show();
            }
            else if (sender is PrincipaleForm)
            {
                base.OnMainFormClosed(sender, e);
            }
        }
        public int SecondsSplashShown
        {
            set
            {
                splashTimer.Interval = value * 1000;
            }
        }
    }
}
