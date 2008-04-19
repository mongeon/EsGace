using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace EsGace.Forms
{
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Classe contenant toutes les options disponibles dans l'application
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Decimal = nudDecimales.Value;
            
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            this.Close();
        }
        ///****************************************************************************************
        /// <summary>
        /// Change l'état lorsque on clic sur la case
        /// </summary>
        ///****************************************************************************************
        private void chkAfficherNotifyIcon_CheckedChanged(object sender, EventArgs e)
        {
            lblReduireZoneNotification.Enabled = chkAfficherNotifyIcon.Checked;
            chkReduireZoneNotification.Enabled = chkAfficherNotifyIcon.Checked;
        }
    }
}
