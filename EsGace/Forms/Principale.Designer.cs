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
            this.tspHaut = new System.Windows.Forms.ToolStripPanel();
            this.tlstrpMain = new System.Windows.Forms.ToolStrip();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuPrincipalFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalOutils = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAP = new System.Windows.Forms.ToolStripMenuItem();
            this.sbPrincipale = new System.Windows.Forms.StatusStrip();
            this.sbPrincipaleStatut = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbPrincipaleMarquee = new System.Windows.Forms.ToolStripProgressBar();
            this.tspGauche = new System.Windows.Forms.ToolStripPanel();
            this.splMainHorizontal = new System.Windows.Forms.SplitContainer();
            this.tvEsGace = new System.Windows.Forms.TreeView();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.minTempsEcoule = new System.Windows.Forms.Timer(this.components);
            this.cmnuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuNotifyOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuNotifyBar0 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuNotifyBar1 = new System.Windows.Forms.ToolStripSeparator();
            this.niEsGace = new System.Windows.Forms.NotifyIcon(this.components);
            this.splMainVertical = new System.Windows.Forms.SplitContainer();
            this.tcOutilsAdditionnels = new EsGace.Composantes.TabControlOutils(this.components);
            this.sbPrincipaleTempsEcoule = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlstrpMainAnalyseComplete = new System.Windows.Forms.ToolStripButton();
            this.tlstrpMainAnnulerAnalyse = new System.Windows.Forms.ToolStripButton();
            this.mnuPrincipalFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAnalyseComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAnalyseAnnuler = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalOutilsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipalAPAP = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuNotifyAnnulerAnalyse = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuNotifyQuitter = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tspHaut.AccessibleDescription = null;
            this.tspHaut.AccessibleName = null;
            resources.ApplyResources(this.tspHaut, "tspHaut");
            this.tspHaut.BackgroundImage = null;
            this.tspHaut.Controls.Add(this.tlstrpMain);
            this.tspHaut.Font = null;
            this.tspHaut.Name = "tspHaut";
            this.tspHaut.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.tspHaut.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // tlstrpMain
            // 
            this.tlstrpMain.AccessibleDescription = null;
            this.tlstrpMain.AccessibleName = null;
            resources.ApplyResources(this.tlstrpMain, "tlstrpMain");
            this.tlstrpMain.BackgroundImage = null;
            this.tlstrpMain.Font = null;
            this.tlstrpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpMainAnalyseComplete,
            this.tlstrpMainAnnulerAnalyse});
            this.tlstrpMain.Name = "tlstrpMain";
            this.tlstrpMain.Stretch = true;
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.AccessibleDescription = null;
            this.mnuPrincipal.AccessibleName = null;
            resources.ApplyResources(this.mnuPrincipal, "mnuPrincipal");
            this.mnuPrincipal.BackgroundImage = null;
            this.mnuPrincipal.Font = null;
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalFichier,
            this.mnuPrincipalAnalyse,
            this.mnuPrincipalOutils,
            this.mnuPrincipalAP});
            this.mnuPrincipal.Name = "mnuPrincipal";
            // 
            // mnuPrincipalFichier
            // 
            this.mnuPrincipalFichier.AccessibleDescription = null;
            this.mnuPrincipalFichier.AccessibleName = null;
            resources.ApplyResources(this.mnuPrincipalFichier, "mnuPrincipalFichier");
            this.mnuPrincipalFichier.BackgroundImage = null;
            this.mnuPrincipalFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalFichierQuitter});
            this.mnuPrincipalFichier.Name = "mnuPrincipalFichier";
            this.mnuPrincipalFichier.ShortcutKeyDisplayString = null;
            // 
            // mnuPrincipalAnalyse
            // 
            this.mnuPrincipalAnalyse.AccessibleDescription = null;
            this.mnuPrincipalAnalyse.AccessibleName = null;
            resources.ApplyResources(this.mnuPrincipalAnalyse, "mnuPrincipalAnalyse");
            this.mnuPrincipalAnalyse.BackgroundImage = null;
            this.mnuPrincipalAnalyse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalAnalyseComplete,
            this.mnuPrincipalAnalyseAnnuler});
            this.mnuPrincipalAnalyse.Name = "mnuPrincipalAnalyse";
            this.mnuPrincipalAnalyse.ShortcutKeyDisplayString = null;
            // 
            // mnuPrincipalOutils
            // 
            this.mnuPrincipalOutils.AccessibleDescription = null;
            this.mnuPrincipalOutils.AccessibleName = null;
            resources.ApplyResources(this.mnuPrincipalOutils, "mnuPrincipalOutils");
            this.mnuPrincipalOutils.BackgroundImage = null;
            this.mnuPrincipalOutils.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalOutilsOptions});
            this.mnuPrincipalOutils.Name = "mnuPrincipalOutils";
            this.mnuPrincipalOutils.ShortcutKeyDisplayString = null;
            // 
            // mnuPrincipalAP
            // 
            this.mnuPrincipalAP.AccessibleDescription = null;
            this.mnuPrincipalAP.AccessibleName = null;
            resources.ApplyResources(this.mnuPrincipalAP, "mnuPrincipalAP");
            this.mnuPrincipalAP.BackgroundImage = null;
            this.mnuPrincipalAP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrincipalAPAP});
            this.mnuPrincipalAP.Name = "mnuPrincipalAP";
            this.mnuPrincipalAP.ShortcutKeyDisplayString = null;
            // 
            // sbPrincipale
            // 
            this.sbPrincipale.AccessibleDescription = null;
            this.sbPrincipale.AccessibleName = null;
            resources.ApplyResources(this.sbPrincipale, "sbPrincipale");
            this.sbPrincipale.BackgroundImage = null;
            this.sbPrincipale.Font = null;
            this.sbPrincipale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbPrincipaleStatut,
            this.sbPrincipaleTempsEcoule,
            this.sbPrincipaleMarquee});
            this.sbPrincipale.Name = "sbPrincipale";
            this.sbPrincipale.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            // 
            // sbPrincipaleStatut
            // 
            this.sbPrincipaleStatut.AccessibleDescription = null;
            this.sbPrincipaleStatut.AccessibleName = null;
            resources.ApplyResources(this.sbPrincipaleStatut, "sbPrincipaleStatut");
            this.sbPrincipaleStatut.BackgroundImage = null;
            this.sbPrincipaleStatut.Name = "sbPrincipaleStatut";
            this.sbPrincipaleStatut.Spring = true;
            // 
            // sbPrincipaleMarquee
            // 
            this.sbPrincipaleMarquee.AccessibleDescription = null;
            this.sbPrincipaleMarquee.AccessibleName = null;
            resources.ApplyResources(this.sbPrincipaleMarquee, "sbPrincipaleMarquee");
            this.sbPrincipaleMarquee.Name = "sbPrincipaleMarquee";
            this.sbPrincipaleMarquee.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // tspGauche
            // 
            this.tspGauche.AccessibleDescription = null;
            this.tspGauche.AccessibleName = null;
            resources.ApplyResources(this.tspGauche, "tspGauche");
            this.tspGauche.BackgroundImage = null;
            this.tspGauche.Font = null;
            this.tspGauche.Name = "tspGauche";
            this.tspGauche.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tspGauche.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            // 
            // splMainHorizontal
            // 
            this.splMainHorizontal.AccessibleDescription = null;
            this.splMainHorizontal.AccessibleName = null;
            resources.ApplyResources(this.splMainHorizontal, "splMainHorizontal");
            this.splMainHorizontal.BackgroundImage = null;
            this.splMainHorizontal.Font = null;
            this.splMainHorizontal.Name = "splMainHorizontal";
            // 
            // splMainHorizontal.Panel1
            // 
            this.splMainHorizontal.Panel1.AccessibleDescription = null;
            this.splMainHorizontal.Panel1.AccessibleName = null;
            resources.ApplyResources(this.splMainHorizontal.Panel1, "splMainHorizontal.Panel1");
            this.splMainHorizontal.Panel1.BackgroundImage = null;
            this.splMainHorizontal.Panel1.Controls.Add(this.tvEsGace);
            this.splMainHorizontal.Panel1.Font = null;
            // 
            // splMainHorizontal.Panel2
            // 
            this.splMainHorizontal.Panel2.AccessibleDescription = null;
            this.splMainHorizontal.Panel2.AccessibleName = null;
            resources.ApplyResources(this.splMainHorizontal.Panel2, "splMainHorizontal.Panel2");
            this.splMainHorizontal.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splMainHorizontal.Panel2.BackgroundImage = null;
            this.splMainHorizontal.Panel2.Controls.Add(this.txtDetails);
            this.splMainHorizontal.Panel2.Font = null;
            // 
            // tvEsGace
            // 
            this.tvEsGace.AccessibleDescription = null;
            this.tvEsGace.AccessibleName = null;
            resources.ApplyResources(this.tvEsGace, "tvEsGace");
            this.tvEsGace.BackgroundImage = null;
            this.tvEsGace.Font = null;
            this.tvEsGace.Name = "tvEsGace";
            this.tvEsGace.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvEsGace_BeforeExpand);
            this.tvEsGace.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEsGace_AfterSelect);
            // 
            // txtDetails
            // 
            this.txtDetails.AccessibleDescription = null;
            this.txtDetails.AccessibleName = null;
            resources.ApplyResources(this.txtDetails, "txtDetails");
            this.txtDetails.BackgroundImage = null;
            this.txtDetails.Font = null;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            // 
            // minTempsEcoule
            // 
            this.minTempsEcoule.Interval = 1000;
            this.minTempsEcoule.Tick += new System.EventHandler(this.minTempsEcoule_Tick);
            // 
            // cmnuNotify
            // 
            this.cmnuNotify.AccessibleDescription = null;
            this.cmnuNotify.AccessibleName = null;
            resources.ApplyResources(this.cmnuNotify, "cmnuNotify");
            this.cmnuNotify.BackgroundImage = null;
            this.cmnuNotify.Font = null;
            this.cmnuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuNotifyOuvrir,
            this.cmnuNotifyBar0,
            this.cmnuNotifyAnnulerAnalyse,
            this.cmnuNotifyBar1,
            this.cmnuNotifyQuitter});
            this.cmnuNotify.Name = "cmnuNotify";
            // 
            // cmnuNotifyOuvrir
            // 
            this.cmnuNotifyOuvrir.AccessibleDescription = null;
            this.cmnuNotifyOuvrir.AccessibleName = null;
            resources.ApplyResources(this.cmnuNotifyOuvrir, "cmnuNotifyOuvrir");
            this.cmnuNotifyOuvrir.BackgroundImage = null;
            this.cmnuNotifyOuvrir.Name = "cmnuNotifyOuvrir";
            this.cmnuNotifyOuvrir.ShortcutKeyDisplayString = null;
            this.cmnuNotifyOuvrir.Click += new System.EventHandler(this.niEsGace_DoubleClick);
            // 
            // cmnuNotifyBar0
            // 
            this.cmnuNotifyBar0.AccessibleDescription = null;
            this.cmnuNotifyBar0.AccessibleName = null;
            resources.ApplyResources(this.cmnuNotifyBar0, "cmnuNotifyBar0");
            this.cmnuNotifyBar0.Name = "cmnuNotifyBar0";
            // 
            // cmnuNotifyBar1
            // 
            this.cmnuNotifyBar1.AccessibleDescription = null;
            this.cmnuNotifyBar1.AccessibleName = null;
            resources.ApplyResources(this.cmnuNotifyBar1, "cmnuNotifyBar1");
            this.cmnuNotifyBar1.Name = "cmnuNotifyBar1";
            // 
            // niEsGace
            // 
            resources.ApplyResources(this.niEsGace, "niEsGace");
            this.niEsGace.ContextMenuStrip = this.cmnuNotify;
            this.niEsGace.Visible = global::EsGace.Properties.Settings.Default.AfficherIconeNotification;
            this.niEsGace.DoubleClick += new System.EventHandler(this.niEsGace_DoubleClick);
            // 
            // splMainVertical
            // 
            this.splMainVertical.AccessibleDescription = null;
            this.splMainVertical.AccessibleName = null;
            resources.ApplyResources(this.splMainVertical, "splMainVertical");
            this.splMainVertical.BackgroundImage = null;
            this.splMainVertical.Font = null;
            this.splMainVertical.Name = "splMainVertical";
            // 
            // splMainVertical.Panel1
            // 
            this.splMainVertical.Panel1.AccessibleDescription = null;
            this.splMainVertical.Panel1.AccessibleName = null;
            resources.ApplyResources(this.splMainVertical.Panel1, "splMainVertical.Panel1");
            this.splMainVertical.Panel1.BackgroundImage = null;
            this.splMainVertical.Panel1.Controls.Add(this.splMainHorizontal);
            this.splMainVertical.Panel1.Font = null;
            // 
            // splMainVertical.Panel2
            // 
            this.splMainVertical.Panel2.AccessibleDescription = null;
            this.splMainVertical.Panel2.AccessibleName = null;
            resources.ApplyResources(this.splMainVertical.Panel2, "splMainVertical.Panel2");
            this.splMainVertical.Panel2.BackgroundImage = null;
            this.splMainVertical.Panel2.Controls.Add(this.tcOutilsAdditionnels);
            this.splMainVertical.Panel2.Font = null;
            this.splMainVertical.Panel2Collapsed = true;
            // 
            // tcOutilsAdditionnels
            // 
            this.tcOutilsAdditionnels.AccessibleDescription = null;
            this.tcOutilsAdditionnels.AccessibleName = null;
            resources.ApplyResources(this.tcOutilsAdditionnels, "tcOutilsAdditionnels");
            this.tcOutilsAdditionnels.BackgroundImage = null;
            this.tcOutilsAdditionnels.Font = null;
            this.tcOutilsAdditionnels.Name = "tcOutilsAdditionnels";
            this.tcOutilsAdditionnels.SelectedIndex = 0;
            // 
            // sbPrincipaleTempsEcoule
            // 
            this.sbPrincipaleTempsEcoule.AccessibleDescription = null;
            this.sbPrincipaleTempsEcoule.AccessibleName = null;
            resources.ApplyResources(this.sbPrincipaleTempsEcoule, "sbPrincipaleTempsEcoule");
            this.sbPrincipaleTempsEcoule.BackgroundImage = null;
            this.sbPrincipaleTempsEcoule.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sbPrincipaleTempsEcoule.Image = global::EsGace.Properties.Resources.Analyse_Arret;
            this.sbPrincipaleTempsEcoule.Name = "sbPrincipaleTempsEcoule";
            // 
            // tlstrpMainAnalyseComplete
            // 
            this.tlstrpMainAnalyseComplete.AccessibleDescription = null;
            this.tlstrpMainAnalyseComplete.AccessibleName = null;
            resources.ApplyResources(this.tlstrpMainAnalyseComplete, "tlstrpMainAnalyseComplete");
            this.tlstrpMainAnalyseComplete.BackgroundImage = null;
            this.tlstrpMainAnalyseComplete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrpMainAnalyseComplete.Name = "tlstrpMainAnalyseComplete";
            this.tlstrpMainAnalyseComplete.Click += new System.EventHandler(this.mnuPrincipalAnalyseComplete_Click);
            // 
            // tlstrpMainAnnulerAnalyse
            // 
            this.tlstrpMainAnnulerAnalyse.AccessibleDescription = null;
            this.tlstrpMainAnnulerAnalyse.AccessibleName = null;
            resources.ApplyResources(this.tlstrpMainAnnulerAnalyse, "tlstrpMainAnnulerAnalyse");
            this.tlstrpMainAnnulerAnalyse.BackgroundImage = null;
            this.tlstrpMainAnnulerAnalyse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrpMainAnnulerAnalyse.Image = global::EsGace.Properties.Resources.Analyse_Arret;
            this.tlstrpMainAnnulerAnalyse.Name = "tlstrpMainAnnulerAnalyse";
            this.tlstrpMainAnnulerAnalyse.Click += new System.EventHandler(this.mnuPrincipalAnalyseAnnuler_Click);
            // 
            // mnuPrincipalFichierQuitter
            // 
            this.mnuPrincipalFichierQuitter.AccessibleDescription = null;
            this.mnuPrincipalFichierQuitter.AccessibleName = null;
            resources.ApplyResources(this.mnuPrincipalFichierQuitter, "mnuPrincipalFichierQuitter");
            this.mnuPrincipalFichierQuitter.BackgroundImage = null;
            this.mnuPrincipalFichierQuitter.Image = global::EsGace.Properties.Resources.door_out;
            this.mnuPrincipalFichierQuitter.Name = "mnuPrincipalFichierQuitter";
            this.mnuPrincipalFichierQuitter.ShortcutKeyDisplayString = null;
            this.mnuPrincipalFichierQuitter.Click += new System.EventHandler(this.mnuPrincipalFichierQuitter_Click);
            // 
            // mnuPrincipalAnalyseComplete
            // 
            this.mnuPrincipalAnalyseComplete.AccessibleDescription = null;
            this.mnuPrincipalAnalyseComplete.AccessibleName = null;
            resources.ApplyResources(this.mnuPrincipalAnalyseComplete, "mnuPrincipalAnalyseComplete");
            this.mnuPrincipalAnalyseComplete.BackgroundImage = null;
            this.mnuPrincipalAnalyseComplete.Name = "mnuPrincipalAnalyseComplete";
            this.mnuPrincipalAnalyseComplete.ShortcutKeyDisplayString = null;
            this.mnuPrincipalAnalyseComplete.Click += new System.EventHandler(this.mnuPrincipalAnalyseComplete_Click);
            // 
            // mnuPrincipalAnalyseAnnuler
            // 
            this.mnuPrincipalAnalyseAnnuler.AccessibleDescription = null;
            this.mnuPrincipalAnalyseAnnuler.AccessibleName = null;
            resources.ApplyResources(this.mnuPrincipalAnalyseAnnuler, "mnuPrincipalAnalyseAnnuler");
            this.mnuPrincipalAnalyseAnnuler.BackgroundImage = null;
            this.mnuPrincipalAnalyseAnnuler.Image = global::EsGace.Properties.Resources.Analyse_Arret;
            this.mnuPrincipalAnalyseAnnuler.Name = "mnuPrincipalAnalyseAnnuler";
            this.mnuPrincipalAnalyseAnnuler.ShortcutKeyDisplayString = null;
            this.mnuPrincipalAnalyseAnnuler.Click += new System.EventHandler(this.mnuPrincipalAnalyseAnnuler_Click);
            // 
            // mnuPrincipalOutilsOptions
            // 
            this.mnuPrincipalOutilsOptions.AccessibleDescription = null;
            this.mnuPrincipalOutilsOptions.AccessibleName = null;
            resources.ApplyResources(this.mnuPrincipalOutilsOptions, "mnuPrincipalOutilsOptions");
            this.mnuPrincipalOutilsOptions.BackgroundImage = null;
            this.mnuPrincipalOutilsOptions.Image = global::EsGace.Properties.Resources.wrench;
            this.mnuPrincipalOutilsOptions.Name = "mnuPrincipalOutilsOptions";
            this.mnuPrincipalOutilsOptions.ShortcutKeyDisplayString = null;
            this.mnuPrincipalOutilsOptions.Click += new System.EventHandler(this.mnuPrincipalOutilsOptions_Click);
            // 
            // mnuPrincipalAPAP
            // 
            this.mnuPrincipalAPAP.AccessibleDescription = null;
            this.mnuPrincipalAPAP.AccessibleName = null;
            resources.ApplyResources(this.mnuPrincipalAPAP, "mnuPrincipalAPAP");
            this.mnuPrincipalAPAP.BackgroundImage = null;
            this.mnuPrincipalAPAP.Image = global::EsGace.Properties.Resources.information;
            this.mnuPrincipalAPAP.Name = "mnuPrincipalAPAP";
            this.mnuPrincipalAPAP.ShortcutKeyDisplayString = null;
            this.mnuPrincipalAPAP.Click += new System.EventHandler(this.mnuPrincipalAPAP_Click);
            // 
            // cmnuNotifyAnnulerAnalyse
            // 
            this.cmnuNotifyAnnulerAnalyse.AccessibleDescription = null;
            this.cmnuNotifyAnnulerAnalyse.AccessibleName = null;
            resources.ApplyResources(this.cmnuNotifyAnnulerAnalyse, "cmnuNotifyAnnulerAnalyse");
            this.cmnuNotifyAnnulerAnalyse.BackgroundImage = null;
            this.cmnuNotifyAnnulerAnalyse.Image = global::EsGace.Properties.Resources.Analyse_Arret;
            this.cmnuNotifyAnnulerAnalyse.Name = "cmnuNotifyAnnulerAnalyse";
            this.cmnuNotifyAnnulerAnalyse.ShortcutKeyDisplayString = null;
            this.cmnuNotifyAnnulerAnalyse.Click += new System.EventHandler(this.mnuPrincipalAnalyseAnnuler_Click);
            // 
            // cmnuNotifyQuitter
            // 
            this.cmnuNotifyQuitter.AccessibleDescription = null;
            this.cmnuNotifyQuitter.AccessibleName = null;
            resources.ApplyResources(this.cmnuNotifyQuitter, "cmnuNotifyQuitter");
            this.cmnuNotifyQuitter.BackgroundImage = null;
            this.cmnuNotifyQuitter.Image = global::EsGace.Properties.Resources.door_out;
            this.cmnuNotifyQuitter.Name = "cmnuNotifyQuitter";
            this.cmnuNotifyQuitter.ShortcutKeyDisplayString = null;
            this.cmnuNotifyQuitter.Click += new System.EventHandler(this.mnuPrincipalFichierQuitter_Click);
            // 
            // PrincipaleForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.splMainVertical);
            this.Controls.Add(this.tspGauche);
            this.Controls.Add(this.sbPrincipale);
            this.Controls.Add(this.tspHaut);
            this.Controls.Add(this.mnuPrincipal);
            this.Font = null;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "PrincipaleForm";
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