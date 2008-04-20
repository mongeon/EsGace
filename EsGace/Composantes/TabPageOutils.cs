using System.ComponentModel;
using System.Windows.Forms;

namespace EsGace.Composantes
{
    public partial class TabPageOutils : TabPage
    {
        public TabPageOutils()
        {
            InitializeComponent();
        }

        public TabPageOutils(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
