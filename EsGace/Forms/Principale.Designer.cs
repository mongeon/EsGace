﻿namespace EsGace.Forms
{
    partial class PrincipaleForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipaleForm));
            this.tspHaut = new System.Windows.Forms.ToolStripPanel();
            this.tlstrpMain = new System.Windows.Forms.ToolStrip();
            this.tlstrpMainAnalyseComplete = new System.Windows.Forms.ToolStripButton();
            this.tlstrpMainAnnulerAnalyse = new System.Windows.Forms.ToolStripButton();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuPrincipalFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAnalyseComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAnalyseAnnuler = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalOutils = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalOutilsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAPAP = new System.Windows.Forms.ToolStripMenuItem();
            this.sbPrincipale = new System.Windows.Forms.StatusStrip();
            this.sbPrincipaleStatut = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbPrincipaleTempsEcoule = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbPrincipaleMarquee = new System.Windows.Forms.ToolStripProgressBar();
            this.tspGauche = new System.Windows.Forms.ToolStripPanel();
            this.splMainHorizontal = new System.Windows.Forms.SplitContainer();
            this.tvEsGace = new System.Windows.Forms.TreeView();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.minTempsEcoule = new System.Windows.Forms.Timer(this.components);
            this.cmnuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuNotifyOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuNotifyBar0 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuNotifyAnnulerAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuNotifyBar1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuNotifyQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.niEsGace = new System.Windows.Forms.NotifyIcon(this.components);
            this.splMainVertical = new System.Windows.Forms.SplitContainer();
            this.tcOutilsAdditionnels = new EsGace.Composantes.TabControlOutils(this.components);
            this.tspHaut.SuspendLayout();
            this.tlstrpMain.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.sbPrincipale.SuspendLayout();
            this.splMainHorizontal.Panel1.SuspendLayout();
            this.splMainHorizontal.Panel2.SuspendLayout();
            this.splMainHorizontal.SuspendLayout();
            this.cmnuNotify.SuspendLayout();
            this.splMainVertical.Panel1.SuspendLayout();
            this.splMainVertical.Panel2.SuspendLayout();
            this.splMainVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspHaut
            // 
            this.tspHaut.Controls.Add(this.tlstrpMain);
            this.tspHaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.tspHaut.Location = new System.Drawing.Point(0, 24);
            this.tspHaut.Name = "tspHaut";
            this.tspHaut.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.tspHaut.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tspHaut.Size = new System.Drawing.Size(440, 25);
            // 
            // tlstrpMain
            // 
            this.tlstrpMain.Dock = System.Windows.Forms.DockStyle.None;
            this.tlstrpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpMainAnalyseComplete,
            this.tlstrpMainAnnulerAnalyse});
            this.tlstrpMain.Location = new System.Drawing.Point(0, 0);
            this.tlstrpMain.Name = "tlstrpMain";
            this.tlstrpMain.Size = new System.Drawing.Size(440, 25);
            this.tlstrpMain.Stretch = true;
            this.tlstrpMain.TabIndex = 0;
            // 
            // tlstrpMainAnalyseComplete
            // 
            this.tlstrpMainAnalyseComplete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrpMainAnalyseComplete.Enabled = false;
            this.tlstrpMainAnalyseComplete.Image = ((System.Drawing.Image)(resources.GetObject("tlstrpMainAnalyseComplete.Image")));
            this.tlstrpMainAnalyseComplete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrpMainAnalyseComplete.Name = "tlstrpMainAnalyseComplete";
            this.tlstrpMainAnalyseComplete.Size = new System.Drawing.Size(23, 22);
            this.tlstrpMainAnalyseComplete.Text = "&Analyse";
            this.tlstrpMainAnalyseComplete.Click += new System.EventHandler(this.mnuPrincipalAnalyseComplete_Click);
            // 
            // tlstrpMainAnnulerAnalyse
            // 
            this.tlstrpMainAnnulerAnalyse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrpMainAnnulerAnalyse.Enabled = false;
            this.tlstrpMainAnnulerAnalyse.Image = global::EsGace.Properties.Resources.Analyse_Arret;
            this.tlstrpMainAnnulerAnalyse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrpMainAnnulerAnalyse.Name = "tlstrpMainAnnulerAnalyse";
            this.tlstrpMainAnnulerAnalyse.Size = new System.Drawing.Size(23, 22);
            this.tlstrpMainAnnulerAnalyse.Text = "Annuler Analyse";
            this.tlstrpMainAnnulerAnalyse.Click += new System.EventHandler(this.mnuPrincipalAnalyseAnnuler_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalFichier,
            this.mnuPrincipalAnalyse,
            this.mnuPrincipalOutils,
            this.mnuPrincipalAP});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(440, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuPrincipalFichier
            // 
            this.mnuPrincipalFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalFichierQuitter});
            this.mnuPrincipalFichier.Name = "mnuPrincipalFichier";
            this.mnuPrincipalFichier.Size = new System.Drawing.Size(50, 20);
            this.mnuPrincipalFichier.Text = "&Fichier";
            // 
            // mnuPrincipalFichierQuitter
            // 
            this.mnuPrincipalFichierQuitter.Image = global::EsGace.Properties.Resources.door_out;
            this.mnuPrincipalFichierQuitter.Name = "mnuPrincipalFichierQuitter";
            this.mnuPrincipalFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuPrincipalFichierQuitter.Size = new System.Drawing.Size(161, 22);
            this.mnuPrincipalFichierQuitter.Text = "&Quitter";
            this.mnuPrincipalFichierQuitter.Click += new System.EventHandler(this.mnuPrincipalFichierQuitter_Click);
            // 
            // mnuPrincipalAnalyse
            // 
            this.mnuPrincipalAnalyse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalAnalyseComplete,
            this.mnuPrincipalAnalyseAnnuler});
            this.mnuPrincipalAnalyse.Name = "mnuPrincipalAnalyse";
            this.mnuPrincipalAnalyse.Size = new System.Drawing.Size(57, 20);
            this.mnuPrincipalAnalyse.Text = "&Analyse";
            // 
            // mnuPrincipalAnalyseComplete
            // 
            this.mnuPrincipalAnalyseComplete.Enabled = false;
            this.mnuPrincipalAnalyseComplete.Image = ((System.Drawing.Image)(resources.GetObject("mnuPrincipalAnalyseComplete.Image")));
            this.mnuPrincipalAnalyseComplete.Name = "mnuPrincipalAnalyseComplete";
            this.mnuPrincipalAnalyseComplete.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuPrincipalAnalyseComplete.Size = new System.Drawing.Size(190, 22);
            this.mnuPrincipalAnalyseComplete.Text = "Analyse &Complète";
            this.mnuPrincipalAnalyseComplete.Click += new System.EventHandler(this.mnuPrincipalAnalyseComplete_Click);
            // 
            // mnuPrincipalAnalyseAnnuler
            // 
            this.mnuPrincipalAnalyseAnnuler.Enabled = false;
            this.mnuPrincipalAnalyseAnnuler.Image = global::EsGace.Properties.Resources.Analyse_Arret;
            this.mnuPrincipalAnalyseAnnuler.Name = "mnuPrincipalAnalyseAnnuler";
            this.mnuPrincipalAnalyseAnnuler.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.mnuPrincipalAnalyseAnnuler.Size = new System.Drawing.Size(190, 22);
            this.mnuPrincipalAnalyseAnnuler.Text = "&Annuler";
            this.mnuPrincipalAnalyseAnnuler.Click += new System.EventHandler(this.mnuPrincipalAnalyseAnnuler_Click);
            // 
            // mnuPrincipalOutils
            // 
            this.mnuPrincipalOutils.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalOutilsOptions});
            this.mnuPrincipalOutils.Name = "mnuPrincipalOutils";
            this.mnuPrincipalOutils.Size = new System.Drawing.Size(46, 20);
            this.mnuPrincipalOutils.Text = "&Outils";
            // 
            // mnuPrincipalOutilsOptions
            // 
            this.mnuPrincipalOutilsOptions.Image = global::EsGace.Properties.Resources.wrench;
            this.mnuPrincipalOutilsOptions.Name = "mnuPrincipalOutilsOptions";
            this.mnuPrincipalOutilsOptions.Size = new System.Drawing.Size(134, 22);
            this.mnuPrincipalOutilsOptions.Text = "&Options...";
            this.mnuPrincipalOutilsOptions.Click += new System.EventHandler(this.mnuPrincipalOutilsOptions_Click);
            // 
            // mnuPrincipalAP
            // 
            this.mnuPrincipalAP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalAPAP});
            this.mnuPrincipalAP.Name = "mnuPrincipalAP";
            this.mnuPrincipalAP.Size = new System.Drawing.Size(24, 20);
            this.mnuPrincipalAP.Text = "&?";
            // 
            // mnuPrincipalAPAP
            // 
            this.mnuPrincipalAPAP.Image = global::EsGace.Properties.Resources.information;
            this.mnuPrincipalAPAP.Name = "mnuPrincipalAPAP";
            this.mnuPrincipalAPAP.Size = new System.Drawing.Size(140, 22);
            this.mnuPrincipalAPAP.Text = "À propos...";
            this.mnuPrincipalAPAP.Click += new System.EventHandler(this.mnuPrincipalAPAP_Click);
            // 
            // sbPrincipale
            // 
            this.sbPrincipale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbPrincipaleStatut,
            this.sbPrincipaleTempsEcoule,
            this.sbPrincipaleMarquee});
            this.sbPrincipale.Location = new System.Drawing.Point(0, 407);
            this.sbPrincipale.Name = "sbPrincipale";
            this.sbPrincipale.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.sbPrincipale.Size = new System.Drawing.Size(440, 25);
            this.sbPrincipale.TabIndex = 2;
            this.sbPrincipale.Text = "statusStrip1";
            // 
            // sbPrincipaleStatut
            // 
            this.sbPrincipaleStatut.Name = "sbPrincipaleStatut";
            this.sbPrincipaleStatut.Size = new System.Drawing.Size(405, 20);
            this.sbPrincipaleStatut.Spring = true;
            this.sbPrincipaleStatut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sbPrincipaleTempsEcoule
            // 
            this.sbPrincipaleTempsEcoule.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sbPrincipaleTempsEcoule.Image = global::EsGace.Properties.Resources.Analyse_Arret;
            this.sbPrincipaleTempsEcoule.Name = "sbPrincipaleTempsEcoule";
            this.sbPrincipaleTempsEcoule.Size = new System.Drawing.Size(20, 20);
            // 
            // sbPrincipaleMarquee
            // 
            this.sbPrincipaleMarquee.Name = "sbPrincipaleMarquee";
            this.sbPrincipaleMarquee.Size = new System.Drawing.Size(100, 19);
            this.sbPrincipaleMarquee.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.sbPrincipaleMarquee.Visible = false;
            // 
            // tspGauche
            // 
            this.tspGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.tspGauche.Location = new System.Drawing.Point(0, 49);
            this.tspGauche.Name = "tspGauche";
            this.tspGauche.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tspGauche.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tspGauche.Size = new System.Drawing.Size(0, 358);
            // 
            // splMainHorizontal
            // 
            this.splMainHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMainHorizontal.Location = new System.Drawing.Point(0, 0);
            this.splMainHorizontal.Name = "splMainHorizontal";
            this.splMainHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splMainHorizontal.Panel1
            // 
            this.splMainHorizontal.Panel1.Controls.Add(this.tvEsGace);
            // 
            // splMainHorizontal.Panel2
            // 
            this.splMainHorizontal.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splMainHorizontal.Panel2.Controls.Add(this.txtDetails);
            this.splMainHorizontal.Size = new System.Drawing.Size(224, 358);
            this.splMainHorizontal.SplitterDistance = 279;
            this.splMainHorizontal.TabIndex = 4;
            // 
            // tvEsGace
            // 
            this.tvEsGace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvEsGace.Enabled = false;
            this.tvEsGace.Location = new System.Drawing.Point(0, 0);
            this.tvEsGace.Name = "tvEsGace";
            this.tvEsGace.Size = new System.Drawing.Size(224, 279);
            this.tvEsGace.TabIndex = 0;
            this.tvEsGace.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvEsGace_BeforeExpand);
            this.tvEsGace.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEsGace_AfterSelect);
            // 
            // txtDetails
            // 
            this.txtDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetails.Location = new System.Drawing.Point(0, 0);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(224, 75);
            this.txtDetails.TabIndex = 0;
            // 
            // minTempsEcoule
            // 
            this.minTempsEcoule.Interval = 1000;
            this.minTempsEcoule.Tick += new System.EventHandler(this.minTempsEcoule_Tick);
            // 
            // cmnuNotify
            // 
            this.cmnuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuNotifyOuvrir,
            this.cmnuNotifyBar0,
            this.cmnuNotifyAnnulerAnalyse,
            this.cmnuNotifyBar1,
            this.cmnuNotifyQuitter});
            this.cmnuNotify.Name = "cmnuNotify";
            this.cmnuNotify.Size = new System.Drawing.Size(163, 82);
            // 
            // cmnuNotifyOuvrir
            // 
            this.cmnuNotifyOuvrir.Name = "cmnuNotifyOuvrir";
            this.cmnuNotifyOuvrir.Size = new System.Drawing.Size(162, 22);
            this.cmnuNotifyOuvrir.Text = "&Ouvrir";
            this.cmnuNotifyOuvrir.Click += new System.EventHandler(this.niEsGace_DoubleClick);
            // 
            // cmnuNotifyBar0
            // 
            this.cmnuNotifyBar0.Name = "cmnuNotifyBar0";
            this.cmnuNotifyBar0.Size = new System.Drawing.Size(159, 6);
            // 
            // cmnuNotifyAnnulerAnalyse
            // 
            this.cmnuNotifyAnnulerAnalyse.Enabled = false;
            this.cmnuNotifyAnnulerAnalyse.Image = global::EsGace.Properties.Resources.Analyse_Arret;
            this.cmnuNotifyAnnulerAnalyse.Name = "cmnuNotifyAnnulerAnalyse";
            this.cmnuNotifyAnnulerAnalyse.Size = new System.Drawing.Size(162, 22);
            this.cmnuNotifyAnnulerAnalyse.Text = "&Annuler analyse";
            this.cmnuNotifyAnnulerAnalyse.Click += new System.EventHandler(this.mnuPrincipalAnalyseAnnuler_Click);
            // 
            // cmnuNotifyBar1
            // 
            this.cmnuNotifyBar1.Name = "cmnuNotifyBar1";
            this.cmnuNotifyBar1.Size = new System.Drawing.Size(159, 6);
            // 
            // cmnuNotifyQuitter
            // 
            this.cmnuNotifyQuitter.Image = global::EsGace.Properties.Resources.door_out;
            this.cmnuNotifyQuitter.Name = "cmnuNotifyQuitter";
            this.cmnuNotifyQuitter.Size = new System.Drawing.Size(162, 22);
            this.cmnuNotifyQuitter.Text = "&Quitter";
            this.cmnuNotifyQuitter.Click += new System.EventHandler(this.mnuPrincipalFichierQuitter_Click);
            // 
            // niEsGace
            // 
            this.niEsGace.ContextMenuStrip = this.cmnuNotify;
            this.niEsGace.Icon = ((System.Drawing.Icon)(resources.GetObject("niEsGace.Icon")));
            this.niEsGace.Text = "EsGace";
            this.niEsGace.Visible = global::EsGace.Properties.Settings.Default.AfficherIconeNotification;
            this.niEsGace.DoubleClick += new System.EventHandler(this.niEsGace_DoubleClick);
            // 
            // splMainVertical
            // 
            this.splMainVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMainVertical.Location = new System.Drawing.Point(0, 49);
            this.splMainVertical.Name = "splMainVertical";
            // 
            // splMainVertical.Panel1
            // 
            this.splMainVertical.Panel1.Controls.Add(this.splMainHorizontal);
            // 
            // splMainVertical.Panel2
            // 
            this.splMainVertical.Panel2.Controls.Add(this.tcOutilsAdditionnels);
            this.splMainVertical.Size = new System.Drawing.Size(440, 358);
            this.splMainVertical.SplitterDistance = 224;
            this.splMainVertical.TabIndex = 7;
            // 
            // tcOutilsAdditionnels
            // 
            this.tcOutilsAdditionnels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcOutilsAdditionnels.Location = new System.Drawing.Point(0, 0);
            this.tcOutilsAdditionnels.Name = "tcOutilsAdditionnels";
            this.tcOutilsAdditionnels.SelectedIndex = 0;
            this.tcOutilsAdditionnels.Size = new System.Drawing.Size(212, 358);
            this.tcOutilsAdditionnels.TabIndex = 0;
            // 
            // PrincipaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 432);
            this.Controls.Add(this.splMainVertical);
            this.Controls.Add(this.tspGauche);
            this.Controls.Add(this.sbPrincipale);
            this.Controls.Add(this.tspHaut);
            this.Controls.Add(this.mnuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuPrincipal;
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "PrincipaleForm";
            this.Text = "EsGace";
            this.Load += new System.EventHandler(this.PrincipaleForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipaleForm_FormClosing);
            this.Resize += new System.EventHandler(this.PrincipaleForm_Resize);
            this.tspHaut.ResumeLayout(false);
            this.tspHaut.PerformLayout();
            this.tlstrpMain.ResumeLayout(false);
            this.tlstrpMain.PerformLayout();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.sbPrincipale.ResumeLayout(false);
            this.sbPrincipale.PerformLayout();
            this.splMainHorizontal.Panel1.ResumeLayout(false);
            this.splMainHorizontal.Panel2.ResumeLayout(false);
            this.splMainHorizontal.Panel2.PerformLayout();
            this.splMainHorizontal.ResumeLayout(false);
            this.cmnuNotify.ResumeLayout(false);
            this.splMainVertical.Panel1.ResumeLayout(false);
            this.splMainVertical.Panel2.ResumeLayout(false);
            this.splMainVertical.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel tspHaut;
        private System.Windows.Forms.ToolStrip tlstrpMain;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.StatusStrip sbPrincipale;
        private System.Windows.Forms.ToolStripPanel tspGauche;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalAP;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalAPAP;
        private System.Windows.Forms.SplitContainer splMainHorizontal;
        private System.Windows.Forms.TreeView tvEsGace;
        private System.Windows.Forms.ToolStripStatusLabel sbPrincipaleStatut;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalOutils;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalOutilsOptions;
        private System.Windows.Forms.ToolStripButton tlstrpMainAnalyseComplete;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.ToolStripButton tlstrpMainAnnulerAnalyse;
        private System.Windows.Forms.ToolStripStatusLabel sbPrincipaleTempsEcoule;
        private System.Windows.Forms.ToolStripProgressBar sbPrincipaleMarquee;
        private System.Windows.Forms.Timer minTempsEcoule;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalAnalyse;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalAnalyseComplete;
        private System.Windows.Forms.ToolStripMenuItem mnuPrincipalAnalyseAnnuler;
        private System.Windows.Forms.NotifyIcon niEsGace;
        private System.Windows.Forms.ContextMenuStrip cmnuNotify;
        private System.Windows.Forms.ToolStripMenuItem cmnuNotifyQuitter;
        private System.Windows.Forms.ToolStripMenuItem cmnuNotifyOuvrir;
        private System.Windows.Forms.ToolStripSeparator cmnuNotifyBar0;
        private System.Windows.Forms.ToolStripMenuItem cmnuNotifyAnnulerAnalyse;
        private System.Windows.Forms.ToolStripSeparator cmnuNotifyBar1;
        private System.Windows.Forms.SplitContainer splMainVertical;
        private EsGace.Composantes.TabControlOutils tcOutilsAdditionnels;
    }
}