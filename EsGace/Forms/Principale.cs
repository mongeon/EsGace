using System;
using System.Windows.Forms;
using EsGaceEngin;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;

namespace EsGace.Forms
{
    public partial class PrincipaleForm : Form
    {
        #region Variables =========================================================================
        private ImageList imgArbre;
        private Engin m_moteur;
        #endregion

        public PrincipaleForm()
        {
            InitializeComponent();
        }

        #region Menus

        /// <summary>
        /// Quitte le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuPrincipalFichierQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Affiche le dialogue À Propos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuPrincipalAPAP_Click(object sender, EventArgs e)
        {
            APropos APForm = new APropos();
            APForm.ShowDialog();
        }
        #endregion

        private void PrincipaleForm_Load(object sender, EventArgs e)
        {

            tvEsGace.TreeViewNodeSorter = new NodeSorter();
            ChargementImage();
            m_moteur = new Engin();
            m_moteur.AnalyseCompleter += new Engin.EnginEventHandler(m_moteur_AnalyseCompleter);
            m_moteur.AnalyseProgression += new Engin.EnginProgressionEventHandler(m_moteur_AnalyseProgression);
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
        }

        /// <summary>
        /// Met à jour le statut de l'analyse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_moteur_AnalyseProgression(object sender, string e)
        {
            sbPrincipaleStatut.Text = e;
        }

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

        }

        void m_moteur_AnalysePartielCompleter(object sender, Item e)
        {
            System.Diagnostics.Debug.WriteLine(e.Nom + TransformerTailleEnTexte(e.Taille)); ;
        }




        private bool ChargementImage()
        {
            imgArbre = new ImageList();
            imgArbre.TransparentColor = Color.White;
            imgArbre.Images.Add("Erreur", Properties.Resources.Erreur);
            imgArbre.Images.Add("Lecteur", Properties.Resources.Lecteur);
            imgArbre.Images.Add("Lecteur_Erreur", Properties.Resources.Lecteur_Erreur );
            imgArbre.Images.Add("Repertoire", Properties.Resources.Repertoire);
            imgArbre.Images.Add("Fichier", Properties.Resources.Fichier);

            
            imgArbre.ImageSize = Properties.Resources.Erreur.Size;
            tvEsGace.ImageList = imgArbre;

            return true;
        }
        private bool AjouterItemArbre(TreeNode NoeudParent,EsGaceEngin.Item item)
        {

            TreeNode tn = new TreeNode(item.Nom);

            tn.Tag = item;



            if (item.Taille >= 0) 
            { 
                tn.Text = item.Nom + "  ["
                +TransformerTailleEnTexte( item.Taille)
                +"]"; 
            }
            if (item is Fichier == false){tn.Nodes.Add("Dummy");}
            
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

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
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

        private void mnuPrincipalOutilsOptions_Click(object sender, EventArgs e)
        {
            Options opt = new Options();

            opt.ShowDialog();
        }

        private void tlstrpMainAnalyseComplete_Click(object sender, EventArgs e)
        {
            m_moteur.Analyse();
        }

        private void tvEsGace_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Item)
	        {
		         Item item = (Item)e.Node.Tag;
                 txtDetails.Text = item.Nom;
                 txtDetails.Text += "\r\n"+item.Chemin;
                 if (item.Taille >=0 )
                     txtDetails.Text += "\r\nTaille : " + TransformerTailleEnTexte(item.Taille);
            }
            else
            {
                txtDetails.Text = "";
            }
            
        }

        private void tlstrpMainAnnulerAnalyse_Click(object sender, EventArgs e)
        {

            m_moteur.AnnulerAnalyse();
        }

        private void bgwAnalyse_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

                m_moteur.Analyse();
            
        }

        private void bgwAnalyse_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            sbPrincipaleStatut.Text = "Complété";
        }

    }
    // Create a node sorter that implements the IComparer interface.
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
