using System;
using System.Collections.Generic;
using System.Text;

namespace EsGaceEngin
{
    public interface iItem
    {
        /// <summary>
        /// Détermine si l'item existe ou pas.
        /// </summary>
        bool Existe
        {
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        DateTime DateCreation
        {
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        DateTime DateDernierAcces
        {
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        DateTime DateDerniereModification
        {
            get;
        }

    }
}
