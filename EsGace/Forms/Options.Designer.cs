namespace EsGace.Forms
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tbGeneral = new System.Windows.Forms.TabPage();
            this.chkReduireZoneNotification = new System.Windows.Forms.CheckBox();
            this.lblReduireZoneNotification = new System.Windows.Forms.Label();
            this.chkAfficherNotifyIcon = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAfficherFichier = new System.Windows.Forms.CheckBox();
            this.lblAfficherFichier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDecimales = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tabOptions.SuspendLayout();
            this.tbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tbGeneral);
            resources.ApplyResources(this.tabOptions, "tabOptions");
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            // 
            // tbGeneral
            // 
            this.tbGeneral.Controls.Add(this.chkReduireZoneNotification);
            this.tbGeneral.Controls.Add(this.lblReduireZoneNotification);
            this.tbGeneral.Controls.Add(this.chkAfficherNotifyIcon);
            this.tbGeneral.Controls.Add(this.label2);
            this.tbGeneral.Controls.Add(this.chkAfficherFichier);
            this.tbGeneral.Controls.Add(this.lblAfficherFichier);
            this.tbGeneral.Controls.Add(this.label1);
            this.tbGeneral.Controls.Add(this.nudDecimales);
            resources.ApplyResources(this.tbGeneral, "tbGeneral");
            this.tbGeneral.Name = "tbGeneral";
            this.tbGeneral.UseVisualStyleBackColor = true;
            // 
            // chkReduireZoneNotification
            // 
            resources.ApplyResources(this.chkReduireZoneNotification, "chkReduireZoneNotification");
            this.chkReduireZoneNotification.Checked = global::EsGace.Properties.Settings.Default.MinimizerLorsReduction;
            this.chkReduireZoneNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReduireZoneNotification.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::EsGace.Properties.Settings.Default, "MinimizerLorsReduction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkReduireZoneNotification.Name = "chkReduireZoneNotification";
            this.chkReduireZoneNotification.UseVisualStyleBackColor = true;
            // 
            // lblReduireZoneNotification
            // 
            resources.ApplyResources(this.lblReduireZoneNotification, "lblReduireZoneNotification");
            this.lblReduireZoneNotification.Name = "lblReduireZoneNotification";
            // 
            // chkAfficherNotifyIcon
            // 
            resources.ApplyResources(this.chkAfficherNotifyIcon, "chkAfficherNotifyIcon");
            this.chkAfficherNotifyIcon.Checked = global::EsGace.Properties.Settings.Default.AfficherIconeNotification;
            this.chkAfficherNotifyIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAfficherNotifyIcon.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::EsGace.Properties.Settings.Default, "AfficherIconeNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAfficherNotifyIcon.Name = "chkAfficherNotifyIcon";
            this.chkAfficherNotifyIcon.UseVisualStyleBackColor = true;
            this.chkAfficherNotifyIcon.CheckedChanged += new System.EventHandler(this.chkAfficherNotifyIcon_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // chkAfficherFichier
            // 
            resources.ApplyResources(this.chkAfficherFichier, "chkAfficherFichier");
            this.chkAfficherFichier.Checked = global::EsGace.Properties.Settings.Default.AfficherFichierAnalyse;
            this.chkAfficherFichier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAfficherFichier.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::EsGace.Properties.Settings.Default, "AfficherFichierAnalyse", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAfficherFichier.Name = "chkAfficherFichier";
            this.chkAfficherFichier.UseVisualStyleBackColor = true;
            // 
            // lblAfficherFichier
            // 
            resources.ApplyResources(this.lblAfficherFichier, "lblAfficherFichier");
            this.lblAfficherFichier.Name = "lblAfficherFichier";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // nudDecimales
            // 
            this.nudDecimales.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.nudDecimales.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::EsGace.Properties.Settings.Default, "Decimal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.nudDecimales, "nudDecimales");
            this.nudDecimales.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDecimales.Name = "nudDecimales";
            this.nudDecimales.UseWaitCursor = true;
            this.nudDecimales.Value = global::EsGace.Properties.Settings.Default.Decimal;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Name = "panel1";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnuler
            // 
            resources.ApplyResources(this.btnAnnuler, "btnAnnuler");
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.Controls.Add(this.tabOptions);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.tabOptions.ResumeLayout(false);
            this.tbGeneral.ResumeLayout(false);
            this.tbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tbGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDecimales;
        private System.Windows.Forms.CheckBox chkAfficherFichier;
        private System.Windows.Forms.Label lblAfficherFichier;
        private System.Windows.Forms.CheckBox chkReduireZoneNotification;
        private System.Windows.Forms.Label lblReduireZoneNotification;
        private System.Windows.Forms.CheckBox chkAfficherNotifyIcon;
        private System.Windows.Forms.Label label2;
    }
}