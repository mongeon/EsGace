using System;
using System.Collections.Generic;
using System.Text;

namespace EsGaceEngin
{
    public class Item : Noeud
    {
        #region Variables =========================================================================

        private string m_Nom = "";
        internal List<Item> m_Enfants;
        internal long m_Taille = -1;
        private bool m_DejaAnalyser = false;
        #endregion

        #region Propriétés
        /// <summary>
        /// Nom de l'item
        /// </summary>
        public virtual string Nom
        {
            get { return m_Nom; }
            set { m_Nom = value; }
        }
        /// <summary>
        /// Chemin ou se trouve cet item
        /// </summary>
        public virtual string Chemin { get; set; }
        /// <summary>
        /// Taille de l'item
        /// </summary>
        public virtual long Taille {
            get
            {
                
                return m_Taille;
            }
            set
            {
                m_Taille = value;
            }
        }
        /// <summary>
        /// Disque racine de l'item
        /// </summary>
        public virtual string Racine { get; set; }

        /// <summary>
        /// Retourne la liste des enfants
        /// </summary>
        public virtual List<Item> GetEnfants { 
            get
            {
                return m_Enfants;
            } }
        /// <summary>
        /// Retourne la liste des enfants
        /// </summary>
        public virtual int NbEnfants
        {
            get
            {
                if (m_Enfants == null)
                {
                    return -1;
                }
                else
                {
                    return m_Enfants.Count;
                }
            }
        }
        /// <summary>
        /// Retourne la liste des enfants
        /// </summary>
        public virtual bool DejaAnalyser
        {
            get
            {
                return m_DejaAnalyser;
            }
            set
            {
                m_DejaAnalyser = value;
            }
        }
        #endregion
    }
}
