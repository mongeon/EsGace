using System.Windows.Forms;
using EsGace.Classes;
using EsGace.Interface;
using EsGaceEngin;
using EsGace.Composantes;

namespace EsGace.Contrôles
{
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Contrôle affichant les détails de l'item courant en cours.
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    public partial class DetailsItem : TabPageOutils
    {
        
        #region Variables =========================================================================
        //Item m_itemCourant;
        #endregion
        ///****************************************************************************************
        /// <summary>
        /// Constructeur par défaut. Initialise l'item par null
        /// </summary>
        ///****************************************************************************************
        public DetailsItem() : this(null) { }

        ///****************************************************************************************
        /// <summary>
        /// Constructeur, initialise l'item courant avec le paramètre
        /// </summary>
        /// <param name="cItem">Item Courant</param>
        ///****************************************************************************************
        public DetailsItem(Item cItem)
        {
            InitializeComponent();

            // Initialisation de l'item courant.
            m_ItemCourant = cItem;
            
        }

        ///****************************************************************************************
        /// <summary>
        /// Ajuste les contrôles selon l'item courant.
        /// </summary>
        ///****************************************************************************************
        private void AjusterControles()
        {
            // Ajustement de l'Accessibilité des contrôles.
            if (m_ItemCourant == null || m_ItemCourant.TypeItem == Item.eTypeItem.Indefini)
            {
                this.Enabled = false;
            }
            else
            {

                // Réactivation du contrôle.
                this.Enabled = true;
                lnkOuvrir.Enabled = true;

                switch (m_ItemCourant.TypeItem)
                {
                    case Item.eTypeItem.Lecteur:
                        lnkOuvrirDossier.Enabled = false;
                        break;
                    case Item.eTypeItem.Repertoire:
                        lnkOuvrirDossier.Enabled = true;
                        break;
                    case Item.eTypeItem.Fichier:
                        lnkOuvrirDossier.Enabled = true;
                        break;
                }
            }
        }


        ///****************************************************************************************
        /// <summary>
        /// REmplit les contrôles d'informations concernant l'item courant
        /// </summary>
        ///****************************************************************************************
        private void RemplirControles()
        {
            if (m_ItemCourant == null || m_ItemCourant.TypeItem == Item.eTypeItem.Indefini)
            {
                txtNom.Text = "";
                txtRepertoire.Text = "";
                txtTaille.Text = "";
            }
            else
            {

                txtNom.Text = m_ItemCourant.Nom;
                txtRepertoire.Text = m_ItemCourant.Chemin;
                txtTaille.Text = FonctionsGenerales.TransformerTailleEnTexte(m_ItemCourant.Taille);
               
            }
        }


        ///****************************************************************************************
        /// <summary>
        /// Ouvre le dossier de l'item.
        /// </summary>
        ///****************************************************************************************
        private void lnkOuvrirDossier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_ItemCourant != null && m_ItemCourant.Parent is Item)
            {
                System.Diagnostics.Process.Start(((Item)m_ItemCourant.Parent).CheminComplet);
            }
        }

        ///****************************************************************************************
        /// <summary>
        /// Ouvre l'item.
        /// </summary>
        ///****************************************************************************************
        private void lnkOuvrir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_ItemCourant != null)
            {
                System.Diagnostics.Process.Start(((Item)m_ItemCourant).CheminComplet);
            }
        }
        public override void SetItemDansTabPage()
        {
            AjusterControles();
            RemplirControles();
        }
    }
}
