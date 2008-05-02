using System.ComponentModel;
using System.Windows.Forms;
using EsGaceEngin;

namespace EsGace.Composantes
{
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Controle contenant des onglets. Permet une gestion des informations passée dans les onglets
    /// de façon plus dynamique.
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    public partial class TabControlOutils : TabControl
    {
        #region Variables =========================================================================
        /// <summary>
        /// Item Courant
        /// </summary>
        private Item m_ItemCourant;
        #endregion



        public TabControlOutils()
        {
            InitializeComponent();
        }

        public TabControlOutils(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
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
                SetItemOngletActif();
            }
        }
        #endregion

        ///****************************************************************************************
        /// <summary>
        /// Ajuste l'item dans l'onglet actif
        /// </summary>
        ///****************************************************************************************
        private void SetItemOngletActif()
        {
            if (this.SelectedTab is TabPageOutils)
            {
                // On passe l'item à cette page.
                ((TabPageOutils)this.SelectedTab).Item = m_ItemCourant;
            }
            else
            {
                // On ne fait rien, car il n'y a pas de méthode qui permette de géré l'item.
            }
        }

        private void TabControlOutils_Selected(object sender, TabControlEventArgs e)
        {
            SetItemOngletActif();
        }



    }
}
