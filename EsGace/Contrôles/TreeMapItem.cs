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
                    switch (m_itemCourant.TypeItem)
                    {
                        case Item.eTypeItem.Lecteur:
                        case Item.eTypeItem.Repertoire:
                            tmcCtl.MinColorMetric = -1;
                            tmcCtl.MaxColorMetric = m_itemCourant.Taille;

                            foreach (Item item in m_itemCourant.GetEnfants)
                            {
                                long lTaille;
                                long lMetricColor;
                                if (item.Taille <=0)
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
                               Microsoft.Research.CommunityTechnologies.Treemap.Node  node =
                                    new Microsoft.Research.CommunityTechnologies.Treemap.Node(sNom, lTaille, lMetricColor);
                                node.ToolTip =sNom;
                                tmcCtl.Nodes.Add(node);
                            }
                            break;
                        default:
                            break;
                    }
                }
                //AjusterControles();
                //RemplirControles();
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
