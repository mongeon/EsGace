using System.ComponentModel;
using System.Windows.Forms;
using EsGaceEngin;

namespace EsGace.Composantes
{
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Contrôle spécial contenant des informations sur l'item.
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////

    public partial class TabPageOutils : TabPage
    {

        #region Variables =========================================================================
        /// <summary>
        /// Item Courant
        /// </summary>
        internal Item m_ItemCourant;
        #endregion
        #region Constructeurs =====================================================================
        public TabPageOutils()
        {
            InitializeComponent();
        }

        public TabPageOutils(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        } 
        #endregion
        #region Propriétés ========================================================================

        ///****************************************************************************************
        /// <summary>
        /// Item devant être affiché dans les onglets.
        /// </summary>
        ///****************************************************************************************
        public Item Item
        {
            get
            { return m_ItemCourant; }
            set
            {
                m_ItemCourant = value;
                SetItemDansTabPage();
            }
        }
        #endregion

        public virtual void SetItemDansTabPage(){}
    }
}
