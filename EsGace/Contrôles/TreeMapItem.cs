using System.Windows.Forms;
using EsGace.Classes;
using EsGace.Interface;
using EsGaceEngin;
namespace EsGace.Contrôles
{
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Génère un treemap pour un répertoire.
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    public partial class TreeMapItem : UserControl, iControleItem
    {
        #region Variables =========================================================================
        Item m_itemCourant;
        #endregion
        ///****************************************************************************************
        /// <summary>
        /// Constructeur par défaut. Initialise l'item par null
        /// </summary>
        ///****************************************************************************************
        public TreeMapItem() : this(null) { }

        ///****************************************************************************************
        /// <summary>
        /// Constructeur, initialise l'item courant avec le paramètre
        /// </summary>
        /// <param name="cItem">Item Courant</param>
        ///****************************************************************************************
        public TreeMapItem(Item cItem)
        {
            InitializeComponent();

            // Initialisation de l'item courant.
            ItemCourant = cItem;
        }

        #region iControleItem Membres

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
                tmcCtl.Clear();
                if (m_itemCourant is Item)
                {
                    tmcCtl.MinColorMetric = -1;
                    tmcCtl.MaxColorMetric = m_itemCourant.Taille;
                    AjouterNoeud(null, 0);
                }
                //AjusterControles();
                //RemplirControles();
            }
        }
        private void AjouterNoeud(Microsoft.Research.CommunityTechnologies.Treemap.Node noeudParent, int Profondeur)
        {
            Item ItemParent;

            if (noeudParent == null)
            {
                ItemParent = m_itemCourant;
            }
            else if (noeudParent.Tag is Item)
            {

                ItemParent = (Item)noeudParent.Tag;
            }
            else
            {
                return;
            }

            switch (ItemParent.TypeItem)
            {
                case Item.eTypeItem.Lecteur:
                case Item.eTypeItem.Repertoire:


                    foreach (Item item in ItemParent.GetEnfants)
                    {
                        long lTaille;
                        long lMetricColor;
                        if (item.Taille <= 0)
                        {
                            lMetricColor = -1;
                            lTaille = 0;
                        }
                        else
                        {
                            lMetricColor = item.Taille;
                            lTaille = item.Taille;
                        }

                        string sNom = item.Nom + " [" + FonctionsGenerales.TransformerTailleEnTexte(item.Taille) + "]";
                        Microsoft.Research.CommunityTechnologies.Treemap.Node node =
                             new Microsoft.Research.CommunityTechnologies.Treemap.Node(sNom, lTaille, lMetricColor);
                        node.ToolTip = sNom;
                        node.Tag = item;


                        if (noeudParent == null)
                        {
                            tmcCtl.Nodes.Add(node);
                        }
                        else
                        {
                            noeudParent.Nodes.Add(node);
                        }
                        if ( Profondeur < Properties.Settings.Default.TreeMapProfondeur)
	                    {
                            AjouterNoeud(node, Profondeur + 1);
	                    }
                        
                        
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void tmcCtl_NodeDoubleClick(object sender, Microsoft.Research.CommunityTechnologies.Treemap.NodeEventArgs nodeEventArgs)
        {
            if (tmcCtl.CanZoomIn(nodeEventArgs.Node))
            {
                tmcCtl.ZoomIn(nodeEventArgs.Node);
            }
            else if (tmcCtl.CanZoomOut())
            {
                tmcCtl.ZoomOut();
            }

        }
    }
}
