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
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tbGeneral = new System.Windows.Forms.TabPage();
            this.lblReduireZoneNotification = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAfficherFichier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.chkReduireZoneNotification = new System.Windows.Forms.CheckBox();
            this.chkAfficherNotifyIcon = new System.Windows.Forms.CheckBox();
            this.chkAfficherFichier = new System.Windows.Forms.CheckBox();
            this.nudDecimales = new System.Windows.Forms.NumericUpDown();
            this.tabOptions.SuspendLayout();
            this.tbGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimales)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tbGeneral);
            this.tabOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOptions.Location = new System.Drawing.Point(4, 4);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(253, 178);
            this.tabOptions.TabIndex = 0;
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
            this.tbGeneral.Location = new System.Drawing.Point(4, 22);
            this.tbGeneral.Name = "tbGeneral";
            this.tbGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbGeneral.Size = new System.Drawing.Size(245, 152);
            this.tbGeneral.TabIndex = 0;
            this.tbGeneral.Text = "Général";
            this.tbGeneral.UseVisualStyleBackColor = true;
            // 
            // lblReduireZoneNotification
            // 
            this.lblReduireZoneNotification.AutoSize = true;
            this.lblReduireZoneNotification.Location = new System.Drawing.Point(6, 72);
            this.lblReduireZoneNotification.Name = "lblReduireZoneNotification";
            this.lblReduireZoneNotification.Size = new System.Drawing.Size(176, 13);
            this.lblReduireZoneNotification.TabIndex = 6;
            this.lblReduireZoneNotification.Text = "Réduire dans la zone de notification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Afficher l\'icône de notification";
            // 
            // lblAfficherFichier
            // 
            this.lblAfficherFichier.AutoSize = true;
            this.lblAfficherFichier.Location = new System.Drawing.Point(6, 32);
            this.lblAfficherFichier.Name = "lblAfficherFichier";
            this.lblAfficherFichier.Size = new System.Drawing.Size(95, 13);
            this.lblAfficherFichier.TabIndex = 2;
            this.lblAfficherFichier.Text = "Afficher les fichiers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Décimales";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 182);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(253, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.AutoSize = true;
            this.btnOk.Location = new System.Drawing.Point(94, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.AutoSize = true;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(175, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 25);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // chkReduireZoneNotification
            // 
            this.chkReduireZoneNotification.AutoSize = true;
            this.chkReduireZoneNotification.Checked = global::EsGace.Properties.Settings.Default.MinimizerLorsReduction;
            this.chkReduireZoneNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReduireZoneNotification.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::EsGace.Properties.Settings.Default, "MinimizerLorsReduction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkReduireZoneNotification.Location = new System.Drawing.Point(196, 72);
            this.chkReduireZoneNotification.Name = "chkReduireZoneNotification";
            this.chkReduireZoneNotification.Size = new System.Drawing.Size(15, 14);
            this.chkReduireZoneNotification.TabIndex = 5;
            this.chkReduireZoneNotification.UseVisualStyleBackColor = true;
            // 
            // chkAfficherNotifyIcon
            // 
            this.chkAfficherNotifyIcon.AutoSize = true;
            this.chkAfficherNotifyIcon.Checked = global::EsGace.Properties.Settings.Default.AfficherIconeNotification;
            this.chkAfficherNotifyIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAfficherNotifyIcon.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::EsGace.Properties.Settings.Default, "AfficherIconeNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAfficherNotifyIcon.Location = new System.Drawing.Point(196, 52);
            this.chkAfficherNotifyIcon.Name = "chkAfficherNotifyIcon";
            this.chkAfficherNotifyIcon.Size = new System.Drawing.Size(15, 14);
            this.chkAfficherNotifyIcon.TabIndex = 3;
            this.chkAfficherNotifyIcon.UseVisualStyleBackColor = true;
            this.chkAfficherNotifyIcon.CheckedChanged += new System.EventHandler(this.chkAfficherNotifyIcon_CheckedChanged);
            // 
            // chkAfficherFichier
            // 
            this.chkAfficherFichier.AutoSize = true;
            this.chkAfficherFichier.Checked = global::EsGace.Properties.Settings.Default.AfficherFichierAnalyse;
            this.chkAfficherFichier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAfficherFichier.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::EsGace.Properties.Settings.Default, "AfficherFichierAnalyse", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAfficherFichier.Location = new System.Drawing.Point(196, 32);
            this.chkAfficherFichier.Name = "chkAfficherFichier";
            this.chkAfficherFichier.Size = new System.Drawing.Size(15, 14);
            this.chkAfficherFichier.TabIndex = 1;
            this.chkAfficherFichier.UseVisualStyleBackColor = true;
            // 
            // nudDecimales
            // 
            this.nudDecimales.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.nudDecimales.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::EsGace.Properties.Settings.Default, "Decimal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudDecimales.Location = new System.Drawing.Point(196, 6);
            this.nudDecimales.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDecimales.Name = "nudDecimales";
            this.nudDecimales.Size = new System.Drawing.Size(43, 20);
            this.nudDecimales.TabIndex = 0;
            this.nudDecimales.UseWaitCursor = true;
            this.nudDecimales.Value = global::EsGace.Properties.Settings.Default.Decimal;
            // 
            // Options
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(261, 221);
            this.Controls.Add(this.tabOptions);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.tabOptions.ResumeLayout(false);
            this.tbGeneral.ResumeLayout(false);
            this.tbGeneral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimales)).EndInit();
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