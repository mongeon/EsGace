
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EsGaceEngin;

//Private Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean
 
namespace EsGace.Forms
{
   
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Classe principale
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    public partial class PrincipaleForm : Form
    {
        #region Variables =========================================================================
        /// <summary>
        /// Liste des images dans l'arborescence
        /// </summary>
        private ImageList imgArbre;

        /// <summary>
        /// Engin d'analyse des répertoires.
        /// </summary>
        private Engin m_moteur;

        /// <summary>
        /// Temps de départ pour l'analyse, nécessaire lorsque l'analyse roule et on désire en 
        /// connaitre le temps écoulé.
        /// </summary>
        private DateTime m_HeureDepartAnalyse;
        #endregion

        #region Constructeurs ====================================================================
        public PrincipaleForm()
        {
            InitializeComponent();
        } 
        #endregion

        #region Menus =============================================================================

        ///****************************************************************************************
        /// <summary>
        /// Quitte le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///****************************************************************************************
        private void mnuPrincipalFichierQuitter_Click(object sender, EventArgs e)
        {
            FermerApplication();
        }
        ///****************************************************************************************
        /// <summary>
        /// Affiche le dialogue À Propos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///****************************************************************************************
        private void mnuPrincipalAPAP_Click(object sender, EventArgs e)
        {
            APropos APForm = new APropos();
            APForm.ShowDialog();
        }

        ///****************************************************************************************
        /// <summary>
        /// Affiche le dialogue des options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///****************************************************************************************
        private void mnuPrincipalOutilsOptions_Click(object sender, EventArgs e)
        {
            Options opt = new Options();
            opt.ShowDialog(this);

            niEsGace.Visible = Properties.Settings.Default.AfficherIconeNotification;
        }
        ///****************************************************************************************
        /// <summary>
        /// Lance l'analyse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///****************************************************************************************
        private void mnuPrincipalAnalyseComplete_Click(object sender, EventArgs e)
        {
            LancerAnalyseComplete();
        }
        ///****************************************************************************************
        /// <summary>
        /// Annule l'analyse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///****************************************************************************************
        private void mnuPrincipalAnalyseAnnuler_Click(object sender, EventArgs e)
        {
            AnnulerAnalyse();
        }
        #endregion

        #region Fenêtres ==========================================================================
        ///****************************************************************************************
        /// <summary>
        /// Chargement de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///****************************************************************************************
        private void PrincipaleForm_Load(object sender, EventArgs e)
        {
            

            tvEsGace.TreeViewNodeSorter = new NodeSorter();
            ChargementImage();
            m_moteur = new Engin();
            m_moteur.AnalyseCompleter += new Engin.EnginEventHandler(m_moteur_AnalyseCompleter);
            m_moteur.AnalyseProgression += new Engin.EnginProgressionEventHandler(m_moteur_AnalyseProgression);
            m_moteur.EtatModifier += new Engin.EnginEtatModifierEventHandler(m_moteur_EtatModifier);
            try
            {
                foreach (EsGaceEngin.Item disque in m_moteur.DisqueRacines)
                {
                    AjouterItemArbre(null, disque);

                }
            }
            catch (Exception)
            {

                throw;
            }

            // Affiche les bons contrôles disponibles
            AjusterFenetreSelonEtat();
        }
        ///****************************************************************************************
        /// <summary>
        /// Ajuste les options de la fenêtre selon l'état du moteur
        /// </summary>
        ///****************************************************************************************
        private void AjusterFenetreSelonEtat()
        {
            switch (m_moteur.EtatEngin)
            {
                case Engin.Etat.EnCours:
                    mnuPrincipalAnalyseAnnuler.Enabled = true;
                    mnuPrincipalAnalyseComplete.Enabled = false;
                    sbPrincipaleTempsEcoule.Image = Properties.Resources.Analyse_Go;
                    sbPrincipaleMarquee.Visible = true;
                    break;
                case Engin.Etat.Annuler:
                    mnuPrincipalAnalyseAnnuler.Enabled = false;
                    mnuPrincipalAnalyseComplete.Enabled = true;
                    sbPrincipaleTempsEcoule.Image = Properties.Resources.Analyse_Arret;
                    sbPrincipaleMarquee.Visible = false;
                    break;
                case Engin.Etat.AnnulationEnAttente:
                    mnuPrincipalAnalyseAnnuler.Enabled = false;
                    mnuPrincipalAnalyseComplete.Enabled = false;

                    break;
                case Engin.Etat.Erreur:
                    mnuPrincipalAnalyseAnnuler.Enabled = false;
                    mnuPrincipalAnalyseComplete.Enabled = true;
                    sbPrincipaleTempsEcoule.Image = Properties.Resources.Analyse_Erreur;
                    sbPrincipaleMarquee.Visible = false;
                    break;
                case Engin.Etat.EnAttente:
                    mnuPrincipalAnalyseAnnuler.Enabled = false;
                    mnuPrincipalAnalyseComplete.Enabled = true;
                    sbPrincipaleTempsEcoule.Image = Properties.Resources.Analyse_Arret;
                    sbPrincipaleMarquee.Visible = false;
                    break;
                default:
                    break;
            }
            // Copie l'état dans la toolbar.
            tlstrpMainAnalyseComplete.Enabled = mnuPrincipalAnalyseComplete.Enabled;
            tlstrpMainAnnulerAnalyse.Enabled = mnuPrincipalAnalyseAnnuler.Enabled;
            cmnuNotifyAnnulerAnalyse.Enabled = mnuPrincipalAnalyseAnnuler.Enabled;
            //niEsGace.Icon = sbPrincipaleTempsEcoule.Image.;
        }

        ///****************************************************************************************
        /// <summary>
        /// Détermine si on doit fermer ou seulement cacher la fenêtre.
        /// </summary>
        ///****************************************************************************************
        private void PrincipaleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                // Si c'est l'utilisateur qui ferme par le X, alors ne fait que minimiser
                case CloseReason.None:
                case CloseReason.UserClosing:
                    if ((Properties.Settings.Default.AfficherIconeNotification == true 
                        && Properties.Settings.Default.MinimizerLorsReduction == true))
                     {                        
                        e.Cancel = true;
                        this.WindowState = FormWindowState.Minimized;
                     }
                    else
                    {
                        FermerApplication();
                    }
                    break;
                default:
                    // Pour toutes les autres raisons, on quitte l'application.
                    FermerApplication();
                    break;
            }
        }
        ///****************************************************************************************
        /// <summary>
        /// Lors de la redimensionnement de la fenêtre
        /// </summary>
        ///****************************************************************************************
        private void PrincipaleForm_Resize(object sender, EventArgs e)
        {
            // Si l'état devient minimiser, alors on l'enlève de la barre de tâches et on la cache
            if (this.WindowState == FormWindowState.Minimized
                && (Properties.Settings.Default.AfficherIconeNotification == true && Properties.Settings.Default.MinimizerLorsReduction == true))
            {
                this.ShowInTaskbar = false;
                this.Hide();
            }
            // Sinon, on l'affiche dans la barre des taches et on la réafficher
            else
            {
                this.ShowInTaskbar = true;
                this.Show();
            }
        }

        #endregion

        #region Moteur / Engin ====================================================================

        ///****************************************************************************************
        /// <summary>
        /// Lorsque le moteur change d'état, on modifie l'interface pour l'interaction avec 
        /// l'usager.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="etat"></param>
        ///****************************************************************************************
        void m_moteur_EtatModifier(object sender, Engin.Etat etat)
        {
            AjusterFenetreSelonEtat();
        }

        ///****************************************************************************************
        /// <summary>
        /// Met à jour le statut de l'analyse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///****************************************************************************************
        void m_moteur_AnalyseProgression(object sender, string e)
        {
            if (Properties.Settings.Default.AfficherFichierAnalyse)
            {
                sbPrincipaleStatut.Text = e;
                sbPrincipaleStatut.ToolTipText = e;
            }
            else
            {
                sbPrincipaleStatut.Text = "";
                sbPrincipaleStatut.ToolTipText = "";
            }

            sbPrincipaleMarquee.Visible = true;

        }

        ///****************************************************************************************
        /// <summary>
        /// Lorsque l'analyse se termine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">L'item qui a été analyser</param>
        ///****************************************************************************************
        void m_moteur_AnalyseCompleter(object sender, Item e)
        {
            foreach (TreeNode tn in tvEsGace.Nodes)
            {
                foreach (Item item in ((Item)tn.Tag).GetEnfants)
                {
                    AjouterItemArbre(tn, item);
                }

            }

            tvEsGace.Sort();
            tvEsGace.Enabled = true;

            sbPrincipaleStatut.Text = "";
            sbPrincipaleStatut.ToolTipText = "";
            minTempsEcoule.Enabled = false;

        }
        #endregion

        #region Arbre =============================================================================
        ///****************************************************************************************
        /// <summary>
        /// Charge les images dans la liste pour permettre d'afficher ceux-ci dans l'arbre
        /// </summary>
        /// <returns>Vrai si chargement réussi</returns>
        ///****************************************************************************************
        private bool ChargementImage()
        {
            imgArbre = new ImageList();
            imgArbre.TransparentColor = Color.White;
            imgArbre.Images.Add("Erreur", Properties.Resources.Erreur);
            imgArbre.Images.Add("Lecteur", Properties.Resources.Lecteur);
            imgArbre.Images.Add("Lecteur_Erreur", Properties.Resources.Lecteur_Erreur);
            imgArbre.Images.Add("Repertoire", Properties.Resources.Repertoire);
            imgArbre.Images.Add("Fichier", Properties.Resources.Fichier);


            imgArbre.ImageSize = Properties.Resources.Erreur.Size;
            tvEsGace.ImageList = imgArbre;

            return true;
        }

        ///****************************************************************************************
        /// <summary>
        /// Ajoute un item dans l'arbre
        /// </summary>
        /// <param name="NoeudParent">Le noeud parent sous lequel on ajoute un noeud</param>
        /// <param name="item">Un item à ajouter</param>
        /// <returns>Vrai si l'ajout à été réussi.</returns>
        ///****************************************************************************************
        private bool AjouterItemArbre(TreeNode NoeudParent, EsGaceEngin.Item item)
        {

            TreeNode tn = new TreeNode(item.Nom);

            tn.Tag = item;
            if (item.Taille >= 0)
            {
                tn.Text = item.Nom + "  ["
                + TransformerTailleEnTexte(item.Taille)
                + "]";
            }
            if (item is Fichier == false) { tn.Nodes.Add("Dummy"); }

            AjouterImageNoeudArbre(tn);
            AjusterCouleurNoeudArbre(tn);

            if (NoeudParent == null)
            {
                tvEsGace.Nodes.Add(tn);
            }
            else
            {
                NoeudParent.Nodes.Add(tn);
            }

            return true;

        }

        private bool AjouterImageNoeudArbre(TreeNode NoeudArbre)
        {
            if (NoeudArbre.Tag is Lecteur)
            {
                NoeudArbre.ImageKey = "Lecteur";
            }
            else if (NoeudArbre.Tag is Fichier)
            {
                NoeudArbre.ImageKey = "Fichier";
            }
            else if (NoeudArbre.Tag is Repertoire)
            {
                NoeudArbre.ImageKey = "Repertoire";
            }

            return false;
        }
        private bool AjusterCouleurNoeudArbre(TreeNode NoeudArbre)
        {
            if (NoeudArbre.Tag != null && NoeudArbre.Tag is EsGaceEngin.Item)
            {
                if (NoeudArbre.Tag is EsGaceEngin.Lecteur && ((EsGaceEngin.Lecteur)NoeudArbre.Tag).EstActif == false)
                {
                    NoeudArbre.ImageKey = "Lecteur_Erreur";
                    NoeudArbre.ForeColor = Color.Orange;
                }
                return true;
            }
            else
            {
                NoeudArbre.ImageKey = "Erreur";
                NoeudArbre.ForeColor = Color.Red;
                return true;
            }
        }

        private void tvEsGace_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();

            //foreach (TreeNode tn in e.Node.Nodes)
            //{
            //    foreach (Item item in ((Item)tn.Tag).GetEnfants)
            //    {
            //        AjouterItemArbre(tn, item);
            //    }
            //}
            if (e.Node.Tag != null && e.Node.Tag is EsGaceEngin.Item)
            {

                List<Item> itemsEnfants = ((EsGaceEngin.Item)e.Node.Tag).GetEnfants;

                foreach (Item item in itemsEnfants)
                {
                    AjouterItemArbre(e.Node, item);
                }
            }


        }
        private void tvEsGace_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Item)
            {
                Item item = (Item)e.Node.Tag;
                txtDetails.Text = item.Nom;
                txtDetails.Text += "\r\n" + item.Chemin;
                if (item.Taille >= 0)
                    txtDetails.Text += "\r\nTaille : " + TransformerTailleEnTexte(item.Taille);
            }
            else
            {
                txtDetails.Text = "";
            }

        }

        #endregion

        ///****************************************************************************************
        /// <summary>
        /// Termine proprement l'application
        /// </summary>
        ///****************************************************************************************
        private void FermerApplication() {
            m_moteur.AnnulerAnalyse();
            Application.Exit(); 
        }

        private string TransformerTailleEnTexte(long taille)
        {
            Double TailleD = Convert.ToDouble(taille);
            int dec = Convert.ToInt32( Properties.Settings.Default.Decimal);
            if (TailleD <= 1024)
            {
                return Math.Round(TailleD, dec).ToString() + " o";
            }
            else if (TailleD <= 1024 * 1024)
            {
                return Math.Round((TailleD / 1024), dec).ToString() + " ko";
            }
            else if (TailleD <= 1024 * 1024 * 1024)
            {
                return Math.Round((TailleD / (1024 * 1024)), dec).ToString() + " mo";
            }
            else 
            {
                return Math.Round((TailleD / (1024 * 1024 * 1024)), dec).ToString() + " go";

            }

        }
        ///****************************************************************************************
        /// <summary>
        /// Lance l'analyse complète
        /// </summary>
        ///****************************************************************************************
        private void LancerAnalyseComplete()
        {
            m_HeureDepartAnalyse = new DateTime();
            m_HeureDepartAnalyse = DateTime.Now;
            minTempsEcoule.Enabled = true;
            m_moteur.Analyse();
        }
        ///****************************************************************************************
        /// <summary>
        /// Annule l'analyse en cours
        /// </summary>
        ///****************************************************************************************
        private void AnnulerAnalyse()
        {
            m_moteur.AnnulerAnalyse();
        }

        private void minTempsEcoule_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - m_HeureDepartAnalyse;
            sbPrincipaleTempsEcoule.Text = ts.ToString().Substring(0,8);//ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString();
        }

        #region NotifyIcon Et son menu contextuelle ===============================================
        ///****************************************************************************************
        /// <summary>
        /// Lorsque double cliquer, on réaffiche le
        /// </summary>
        ///****************************************************************************************
        private void niEsGace_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            
            this.Activate();
            
        }
        #endregion



    }
    /////////////////////////////////////////////////////////////////////////////////////////////// 
    /// <summary>
    /// Create a node sorter that implements the IComparer interface.
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    public class NodeSorter : IComparer
    {
        // Compare the length of the strings, or the strings
        // themselves, if they are the same length.
        public int Compare(object x, object y)
        {
            TreeNode tx = x as TreeNode;
            TreeNode ty = y as TreeNode;
            if (tx.Tag is Item && ty.Tag is Item)
            {
                
                if (((Item)tx.Tag).Taille == ((Item)ty.Tag).Taille)
                {
                    return string.Compare(tx.Text, ty.Text); ;
                }
                else if ((((Item)tx.Tag).Taille < ((Item)ty.Tag).Taille))
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (tx.Tag == null)
                {
                    return 1;
                }
                else if (ty.Tag == null)
                {
                    return -1;
                }
            }
            return string.Compare(tx.Text, ty.Text);;
        }
    }

}
