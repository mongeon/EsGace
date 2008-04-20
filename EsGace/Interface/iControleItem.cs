using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EsGaceEngin;

namespace EsGace.Interface
{
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Interface pour les contrôles interagissant avec les item.
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////

    public interface iControleItem
    {
        Item ItemCourant { get; set; }
    }
}
