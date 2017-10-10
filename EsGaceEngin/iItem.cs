using System;

namespace EsGaceEngin
{
    public interface iItem
    {
        /// <summary>
        /// </summary>
        DateTime DateCreation
        {
            get;
        }

        /// <summary>
        /// </summary>
        DateTime DateDernierAcces
        {
            get;
        }

        /// <summary>
        /// </summary>
        DateTime DateDerniereModification
        {
            get;
        }

        /// <summary>
        /// Détermine si l'item existe ou pas.
        /// </summary>
        bool Existe
        {
            get;
        }
    }
}