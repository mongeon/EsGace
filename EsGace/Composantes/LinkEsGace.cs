using System.ComponentModel;
using System.Windows.Forms;

namespace EsGace.Composantes
{
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Surcharge du LinkLabel pour permettre une cohésion entre les différents formulaires.
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////

    public partial class LinkEsGace : LinkLabel
    {
        public LinkEsGace()
        {
            InitializeComponent();
        }

        public LinkEsGace(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
