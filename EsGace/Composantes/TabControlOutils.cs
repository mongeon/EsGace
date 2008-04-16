using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EsGace.Composantes
{
    public partial class TabControlOutils : TabControl
    {
        public TabControlOutils()
        {
            InitializeComponent();
        }

        public TabControlOutils(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
