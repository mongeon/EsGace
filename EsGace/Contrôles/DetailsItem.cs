using System.Windows.Forms;
using EsGace.Classes;
using EsGace.Interface;
using EsGaceEngin;

namespace EsGace.Contrôles
{
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Contrôle affichant les détails de l'item courant en cours.
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    public partial class DetailsItem : UserControl,iControleItem
    {
        #region Variables =========================================================================
        Item m_itemCourant;
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
            ItemCourant = cItem;
        }


        private void AjusterControles()
        {
            // Ajustement de l'Accessibilité des contrôles.
            if (m_itemCourant == null || m_itemCourant.TypeItem == Item.eTypeItem.Indefini)
            {
                this.Enabled = false;
            }
            else
            {

                // Réactivation du contrôle.
                this.Enabled = true;
                lnkOuvrir.Enabled = true;

                switch (m_itemCourant.TypeItem)
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

        private void RemplirControles()
        {
            if (m_itemCourant == null || m_itemCourant.TypeItem == Item.eTypeItem.Indefini)
            {
                txtNom.Text = "";
                txtRepertoire.Text = "";
                txtTaille.Text = "";
            }
            else
            {

                txtNom.Text = m_itemCourant.Nom;
                txtRepertoire.Text = m_itemCourant.Chemin;
                txtTaille.Text = FonctionsGenerales.TransformerTailleEnTexte(m_itemCourant.Taille);
               
            }
        }
        #region iControleItem Membres =============================================================
        ///****************************************************************************************
        /// <summary>
        /// Item courant, celui affiché dans le contrôle.
        /// </summary>
        ///****************************************************************************************
        public Item ItemCourant
        {
            get
            {
                return m_itemCourant;
            }
            set
            {
                m_itemCourant = value;

                AjusterControles();
                RemplirControles();
            }
        }

        #endregion

        ///****************************************************************************************
        /// <summary>
        /// Ouvre le dossier de l'item.
        /// </summary>
        ///****************************************************************************************
        private void lnkOuvrirDossier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_itemCourant != null && m_itemCourant.Parent is Item)
            {
                System.Diagnostics.Process.Start(((Item)m_itemCourant.Parent).CheminComplet);
            }
        }

        ///****************************************************************************************
        /// <summary>
        /// Ouvre l'item.
        /// </summary>
        ///****************************************************************************************
        private void lnkOuvrir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_itemCourant != null )
            {
                System.Diagnostics.Process.Start(((Item)m_itemCourant).CheminComplet);
            }
        }
    }
}
