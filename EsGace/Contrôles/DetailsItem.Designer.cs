namespace EsGace.Contrôles
{
    partial class DetailsItem
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsItem));
            this.lblRepertoire = new System.Windows.Forms.Label();
            this.txtRepertoire = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.lblTaille = new System.Windows.Forms.Label();
            this.lnkOuvrirDossier = new EsGace.Composantes.LinkEsGace(this.components);
            this.lnkOuvrir = new EsGace.Composantes.LinkEsGace(this.components);
            this.SuspendLayout();
            // 
            // lblRepertoire
            // 
            this.lblRepertoire.AccessibleDescription = null;
            this.lblRepertoire.AccessibleName = null;
            resources.ApplyResources(this.lblRepertoire, "lblRepertoire");
            this.lblRepertoire.Font = null;
            this.lblRepertoire.Name = "lblRepertoire";
            // 
            // txtRepertoire
            // 
            this.txtRepertoire.AccessibleDescription = null;
            this.txtRepertoire.AccessibleName = null;
            resources.ApplyResources(this.txtRepertoire, "txtRepertoire");
            this.txtRepertoire.BackgroundImage = null;
            this.txtRepertoire.Font = null;
            this.txtRepertoire.Name = "txtRepertoire";
            this.txtRepertoire.ReadOnly = true;
            // 
            // txtNom
            // 
            this.txtNom.AccessibleDescription = null;
            this.txtNom.AccessibleName = null;
            resources.ApplyResources(this.txtNom, "txtNom");
            this.txtNom.BackgroundImage = null;
            this.txtNom.Font = null;
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            // 
            // lblNom
            // 
            this.lblNom.AccessibleDescription = null;
            this.lblNom.AccessibleName = null;
            resources.ApplyResources(this.lblNom, "lblNom");
            this.lblNom.Font = null;
            this.lblNom.Name = "lblNom";
            // 
            // txtTaille
            // 
            this.txtTaille.AccessibleDescription = null;
            this.txtTaille.AccessibleName = null;
            resources.ApplyResources(this.txtTaille, "txtTaille");
            this.txtTaille.BackgroundImage = null;
            this.txtTaille.Font = null;
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.ReadOnly = true;
            // 
            // lblTaille
            // 
            this.lblTaille.AccessibleDescription = null;
            this.lblTaille.AccessibleName = null;
            resources.ApplyResources(this.lblTaille, "lblTaille");
            this.lblTaille.Font = null;
            this.lblTaille.Name = "lblTaille";
            // 
            // lnkOuvrirDossier
            // 
            this.lnkOuvrirDossier.AccessibleDescription = null;
            this.lnkOuvrirDossier.AccessibleName = null;
            resources.ApplyResources(this.lnkOuvrirDossier, "lnkOuvrirDossier");
            this.lnkOuvrirDossier.Font = null;
            this.lnkOuvrirDossier.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkOuvrirDossier.Name = "lnkOuvrirDossier";
            this.lnkOuvrirDossier.TabStop = true;
            this.lnkOuvrirDossier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOuvrirDossier_LinkClicked);
            // 
            // lnkOuvrir
            // 
            this.lnkOuvrir.AccessibleDescription = null;
            this.lnkOuvrir.AccessibleName = null;
            resources.ApplyResources(this.lnkOuvrir, "lnkOuvrir");
            this.lnkOuvrir.Font = null;
            this.lnkOuvrir.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkOuvrir.Name = "lnkOuvrir";
            this.lnkOuvrir.TabStop = true;
            this.lnkOuvrir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOuvrir_LinkClicked);
            // 
            // DetailsItem
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.lblTaille);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtRepertoire);
            this.Controls.Add(this.lblRepertoire);
            this.Controls.Add(this.lnkOuvrirDossier);
            this.Controls.Add(this.lnkOuvrir);
            this.Font = null;
            this.Name = "DetailsItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EsGace.Composantes.LinkEsGace lnkOuvrir;
        private EsGace.Composantes.LinkEsGace lnkOuvrirDossier;
        private System.Windows.Forms.Label lblRepertoire;
        private System.Windows.Forms.TextBox txtRepertoire;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.Label lblTaille;
    }
}
