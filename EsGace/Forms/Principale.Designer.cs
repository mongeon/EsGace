namespace EsGace.Forms
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
            this.splMainHorizontal = new System.Windows.Forms.SplitContainer();
            this.tvEsGace = new System.Windows.Forms.TreeView();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.splMainVertical = new System.Windows.Forms.SplitContainer();
            this.tcOutilsAdditionnels = new EsGace.Composantes.TabControlOutils(this.components);
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.diPrincipale = new EsGace.Contrôles.DetailsItem();
            this.tpVisualisation = new System.Windows.Forms.TabPage();
            this.tmiPrincipale = new EsGace.Contrôles.TreeMapItem();
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
            this.minTempsEcoule = new System.Windows.Forms.Timer(this.components);
            this.cmnuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuNotifyOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuNotifyBar0 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuNotifyAnnulerAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuNotifyBar1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuNotifyQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.niEsGace = new System.Windows.Forms.NotifyIcon(this.components);
            this.splMainHorizontal.Panel1.SuspendLayout();
            this.splMainHorizontal.Panel2.SuspendLayout();
            this.splMainHorizontal.SuspendLayout();
            this.splMainVertical.Panel1.SuspendLayout();
            this.splMainVertical.Panel2.SuspendLayout();
            this.splMainVertical.SuspendLayout();
            this.tcOutilsAdditionnels.SuspendLayout();
            this.tpDetails.SuspendLayout();
            this.tpVisualisation.SuspendLayout();
            this.tspHaut.SuspendLayout();
            this.tlstrpMain.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.sbPrincipale.SuspendLayout();
            this.cmnuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // splMainHorizontal
            // 
            resources.ApplyResources(this.splMainHorizontal, "splMainHorizontal");
            this.splMainHorizontal.Name = "splMainHorizontal";
            // 
            // splMainHorizontal.Panel1
            // 
            this.splMainHorizontal.Panel1.Controls.Add(this.tvEsGace);
            // 
            // splMainHorizontal.Panel2
            // 
            this.splMainHorizontal.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splMainHorizontal.Panel2.Controls.Add(this.txtDetails);
            this.splMainHorizontal.Panel2Collapsed = true;
            // 
            // tvEsGace
            // 
            resources.ApplyResources(this.tvEsGace, "tvEsGace");
            this.tvEsGace.HideSelection = false;
            this.tvEsGace.Name = "tvEsGace";
            this.tvEsGace.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvEsGace_BeforeExpand);
            this.tvEsGace.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEsGace_AfterSelect);
            // 
            // txtDetails
            // 
            resources.ApplyResources(this.txtDetails, "txtDetails");
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            // 
            // splMainVertical
            // 
            resources.ApplyResources(this.splMainVertical, "splMainVertical");
            this.splMainVertical.Name = "splMainVertical";
            // 
            // splMainVertical.Panel1
            // 
            this.splMainVertical.Panel1.Controls.Add(this.splMainHorizontal);
            // 
            // splMainVertical.Panel2
            // 
            this.splMainVertical.Panel2.Controls.Add(this.tcOutilsAdditionnels);
            // 
            // tcOutilsAdditionnels
            // 
            this.tcOutilsAdditionnels.Controls.Add(this.tpDetails);
            this.tcOutilsAdditionnels.Controls.Add(this.tpVisualisation);
            resources.ApplyResources(this.tcOutilsAdditionnels, "tcOutilsAdditionnels");
            this.tcOutilsAdditionnels.Name = "tcOutilsAdditionnels";
            this.tcOutilsAdditionnels.SelectedIndex = 0;
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.diPrincipale);
            resources.ApplyResources(this.tpDetails, "tpDetails");
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // diPrincipale
            // 
            resources.ApplyResources(this.diPrincipale, "diPrincipale");
            this.diPrincipale.BackColor = System.Drawing.SystemColors.Control;
            this.diPrincipale.ItemCourant = null;
            this.diPrincipale.Name = "diPrincipale";
            // 
            // tpVisualisation
            // 
            this.tpVisualisation.Controls.Add(this.tmiPrincipale);
            resources.ApplyResources(this.tpVisualisation, "tpVisualisation");
            this.tpVisualisation.Name = "tpVisualisation";
            this.tpVisualisation.UseVisualStyleBackColor = true;
            // 
            // tmiPrincipale
            // 
            resources.ApplyResources(this.tmiPrincipale, "tmiPrincipale");
            this.tmiPrincipale.ItemCourant = null;
            this.tmiPrincipale.Name = "tmiPrincipale";
            // 
            // tspHaut
            // 
            this.tspHaut.Controls.Add(this.tlstrpMain);
            resources.ApplyResources(this.tspHaut, "tspHaut");
            this.tspHaut.Name = "tspHaut";
            this.tspHaut.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.tspHaut.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // tlstrpMain
            // 
            resources.ApplyResources(this.tlstrpMain, "tlstrpMain");
            this.tlstrpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpMainAnalyseComplete,
            this.tlstrpMainAnnulerAnalyse});
            this.tlstrpMain.Name = "tlstrpMain";
            this.tlstrpMain.Stretch = true;
            // 
            // tlstrpMainAnalyseComplete
            // 
            this.tlstrpMainAnalyseComplete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tlstrpMainAnalyseComplete, "tlstrpMainAnalyseComplete");
            this.tlstrpMainAnalyseComplete.Name = "tlstrpMainAnalyseComplete";
            this.tlstrpMainAnalyseComplete.Click += new System.EventHandler(this.mnuPrincipalAnalyseComplete_Click);
            // 
            // tlstrpMainAnnulerAnalyse
            // 
            this.tlstrpMainAnnulerAnalyse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tlstrpMainAnnulerAnalyse, "tlstrpMainAnnulerAnalyse");
            this.tlstrpMainAnnulerAnalyse.Image = global::EsGace.Properties.Resources.Analyse_Arret;
            this.tlstrpMainAnnulerAnalyse.Name = "tlstrpMainAnnulerAnalyse";
            this.tlstrpMainAnnulerAnalyse.Click += new System.EventHandler(this.mnuPrincipalAnalyseAnnuler_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalFichier,
            this.mnuPrincipalAnalyse,
            this.mnuPrincipalOutils,
            this.mnuPrincipalAP});
            resources.ApplyResources(this.mnuPrincipal, "mnuPrincipal");
            this.mnuPrincipal.Name = "mnuPrincipal";
            // 
            // mnuPrincipalFichier
            // 
            this.mnuPrincipalFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalFichierQuitter});
            this.mnuPrincipalFichier.Name = "mnuPrincipalFichier";
            resources.ApplyResources(this.mnuPrincipalFichier, "mnuPrincipalFichier");
            // 
            // mnuPrincipalFichierQuitter
            // 
            this.mnuPrincipalFichierQuitter.Image = global::EsGace.Properties.Resources.door_out;
            this.mnuPrincipalFichierQuitter.Name = "mnuPrincipalFichierQuitter";
            resources.ApplyResources(this.mnuPrincipalFichierQuitter, "mnuPrincipalFichierQuitter");
            this.mnuPrincipalFichierQuitter.Click += new System.EventHandler(this.mnuPrincipalFichierQuitter_Click);
            // 
            // mnuPrincipalAnalyse
            // 
            this.mnuPrincipalAnalyse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalAnalyseComplete,
            this.mnuPrincipalAnalyseAnnuler});
            this.mnuPrincipalAnalyse.Name = "mnuPrincipalAnalyse";
            resources.ApplyResources(this.mnuPrincipalAnalyse, "mnuPrincipalAnalyse");
            // 
            // mnuPrincipalAnalyseComplete
            // 
            resources.ApplyResources(this.mnuPrincipalAnalyseComplete, "mnuPrincipalAnalyseComplete");
            this.mnuPrincipalAnalyseComplete.Name = "mnuPrincipalAnalyseComplete";
            this.mnuPrincipalAnalyseComplete.Click += new System.EventHandler(this.mnuPrincipalAnalyseComplete_Click);
            // 
            // mnuPrincipalAnalyseAnnuler
            // 
            resources.ApplyResources(this.mnuPrincipalAnalyseAnnuler, "mnuPrincipalAnalyseAnnuler");
            this.mnuPrincipalAnalyseAnnuler.Image = global::EsGace.Properties.Resources.Analyse_Arret;
            this.mnuPrincipalAnalyseAnnuler.Name = "mnuPrincipalAnalyseAnnuler";
            this.mnuPrincipalAnalyseAnnuler.Click += new System.EventHandler(this.mnuPrincipalAnalyseAnnuler_Click);
            // 
            // mnuPrincipalOutils
            // 
            this.mnuPrincipalOutils.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalOutilsOptions});
            this.mnuPrincipalOutils.Name = "mnuPrincipalOutils";
            resources.ApplyResources(this.mnuPrincipalOutils, "mnuPrincipalOutils");
            // 
            // mnuPrincipalOutilsOptions
            // 
            this.mnuPrincipalOutilsOptions.Image = global::EsGace.Properties.Resources.wrench;
            this.mnuPrincipalOutilsOptions.Name = "mnuPrincipalOutilsOptions";
            resources.ApplyResources(this.mnuPrincipalOutilsOptions, "mnuPrincipalOutilsOptions");
            this.mnuPrincipalOutilsOptions.Click += new System.EventHandler(this.mnuPrincipalOutilsOptions_Click);
            // 
            // mnuPrincipalAP
            // 
            this.mnuPrincipalAP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalAPAP});
            this.mnuPrincipalAP.Name = "mnuPrincipalAP";
            resources.ApplyResources(this.mnuPrincipalAP, "mnuPrincipalAP");
            // 
            // mnuPrincipalAPAP
            // 
            this.mnuPrincipalAPAP.Image = global::EsGace.Properties.Resources.information;
            this.mnuPrincipalAPAP.Name = "mnuPrincipalAPAP";
            resources.ApplyResources(this.mnuPrincipalAPAP, "mnuPrincipalAPAP");
            this.mnuPrincipalAPAP.Click += new System.EventHandler(this.mnuPrincipalAPAP_Click);
            // 
            // sbPrincipale
            // 
            this.sbPrincipale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbPrincipaleStatut,
            this.sbPrincipaleTempsEcoule,
            this.sbPrincipaleMarquee});
            resources.ApplyResources(this.sbPrincipale, "sbPrincipale");
            this.sbPrincipale.Name = "sbPrincipale";
            this.sbPrincipale.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            // 
            // sbPrincipaleStatut
            // 
            this.sbPrincipaleStatut.Name = "sbPrincipaleStatut";
            resources.ApplyResources(this.sbPrincipaleStatut, "sbPrincipaleStatut");
            this.sbPrincipaleStatut.Spring = true;
            // 
            // sbPrincipaleTempsEcoule
            // 
            this.sbPrincipaleTempsEcoule.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sbPrincipaleTempsEcoule.Image = global::EsGace.Properties.Resources.Analyse_Arret;
            this.sbPrincipaleTempsEcoule.Name = "sbPrincipaleTempsEcoule";
            resources.ApplyResources(this.sbPrincipaleTempsEcoule, "sbPrincipaleTempsEcoule");
            // 
            // sbPrincipaleMarquee
            // 
            this.sbPrincipaleMarquee.Name = "sbPrincipaleMarquee";
            resources.ApplyResources(this.sbPrincipaleMarquee, "sbPrincipaleMarquee");
            this.sbPrincipaleMarquee.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // tspGauche
            // 
            resources.ApplyResources(this.tspGauche, "tspGauche");
            this.tspGauche.Name = "tspGauche";
            this.tspGauche.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tspGauche.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
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
            resources.ApplyResources(this.cmnuNotify, "cmnuNotify");
            // 
            // cmnuNotifyOuvrir
            // 
            this.cmnuNotifyOuvrir.Name = "cmnuNotifyOuvrir";
            resources.ApplyResources(this.cmnuNotifyOuvrir, "cmnuNotifyOuvrir");
            this.cmnuNotifyOuvrir.Click += new System.EventHandler(this.niEsGace_DoubleClick);
            // 
            // cmnuNotifyBar0
            // 
            this.cmnuNotifyBar0.Name = "cmnuNotifyBar0";
            resources.ApplyResources(this.cmnuNotifyBar0, "cmnuNotifyBar0");
            // 
            // cmnuNotifyAnnulerAnalyse
            // 
            resources.ApplyResources(this.cmnuNotifyAnnulerAnalyse, "cmnuNotifyAnnulerAnalyse");
            this.cmnuNotifyAnnulerAnalyse.Image = global::EsGace.Properties.Resources.Analyse_Arret;
            this.cmnuNotifyAnnulerAnalyse.Name = "cmnuNotifyAnnulerAnalyse";
            this.cmnuNotifyAnnulerAnalyse.Click += new System.EventHandler(this.mnuPrincipalAnalyseAnnuler_Click);
            // 
            // cmnuNotifyBar1
            // 
            this.cmnuNotifyBar1.Name = "cmnuNotifyBar1";
            resources.ApplyResources(this.cmnuNotifyBar1, "cmnuNotifyBar1");
            // 
            // cmnuNotifyQuitter
            // 
            this.cmnuNotifyQuitter.Image = global::EsGace.Properties.Resources.door_out;
            this.cmnuNotifyQuitter.Name = "cmnuNotifyQuitter";
            resources.ApplyResources(this.cmnuNotifyQuitter, "cmnuNotifyQuitter");
            this.cmnuNotifyQuitter.Click += new System.EventHandler(this.mnuPrincipalFichierQuitter_Click);
            // 
            // niEsGace
            // 
            this.niEsGace.ContextMenuStrip = this.cmnuNotify;
            resources.ApplyResources(this.niEsGace, "niEsGace");
            this.niEsGace.Visible = global::EsGace.Properties.Settings.Default.AfficherIconeNotification;
            this.niEsGace.DoubleClick += new System.EventHandler(this.niEsGace_DoubleClick);
            // 
            // PrincipaleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splMainVertical);
            this.Controls.Add(this.tspGauche);
            this.Controls.Add(this.sbPrincipale);
            this.Controls.Add(this.tspHaut);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "PrincipaleForm";
            this.Load += new System.EventHandler(this.PrincipaleForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipaleForm_FormClosing);
            this.Resize += new System.EventHandler(this.PrincipaleForm_Resize);
            this.splMainHorizontal.Panel1.ResumeLayout(false);
            this.splMainHorizontal.Panel2.ResumeLayout(false);
            this.splMainHorizontal.Panel2.PerformLayout();
            this.splMainHorizontal.ResumeLayout(false);
            this.splMainVertical.Panel1.ResumeLayout(false);
            this.splMainVertical.Panel2.ResumeLayout(false);
            this.splMainVertical.ResumeLayout(false);
            this.tcOutilsAdditionnels.ResumeLayout(false);
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.tpVisualisation.ResumeLayout(false);
            this.tspHaut.ResumeLayout(false);
            this.tspHaut.PerformLayout();
            this.tlstrpMain.ResumeLayout(false);
            this.tlstrpMain.PerformLayout();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.sbPrincipale.ResumeLayout(false);
            this.sbPrincipale.PerformLayout();
            this.cmnuNotify.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tpDetails;
        private EsGace.Contrôles.DetailsItem diPrincipale;
        private System.Windows.Forms.TabPage tpVisualisation;
        private EsGace.Contrôles.TreeMapItem tmiPrincipale;
    }
}