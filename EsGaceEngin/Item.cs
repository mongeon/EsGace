using System;
using System.Collections.Generic;
using System.Text;

namespace EsGaceEngin
{
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Item
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    public class Item : Noeud
    {
        ///****************************************************************************************
        /// <summary>
        /// Type d'item possible
        /// </summary>
        ///****************************************************************************************
        public enum eTypeItem
        {
            Indefini =-1,
            Lecteur,
            Repertoire,
            Fichier
        }
        #region Variables =========================================================================

        private string m_Nom = "";
        internal List<Item> m_Enfants;
        internal long m_Taille = -1;
        private bool m_DejaAnalyser = false;

        internal eTypeItem m_tItem = eTypeItem.Indefini;
        #endregion

        #region Propriétés ========================================================================
        ///****************************************************************************************
        /// <summary>
        /// Nom de l'item
        /// </summary>
        ///****************************************************************************************
        public virtual string Nom
        {
            get { return m_Nom; }
            set { m_Nom = value; }
        }
        ///****************************************************************************************
        /// <summary>
        /// Chemin ou se trouve cet item (Le chemin parent)
        /// </summary>
        ///****************************************************************************************
        public virtual string Chemin { get; set; }
        ///****************************************************************************************
        /// <summary>
        /// Chemin complet ou se trouve cet item, incluant le nom de celui-ci
        /// </summary>
        ///****************************************************************************************
        public virtual string CheminComplet { get; set; }
        ///****************************************************************************************
        /// <summary>
        /// Taille de l'item
        /// </summary>
        ///****************************************************************************************
        public virtual long Taille
        {
            get
            {
                
                return m_Taille;
            }
            set
            {
                m_Taille = value;
            }
        }
        ///****************************************************************************************
        /// <summary>
        /// Disque racine de l'item
        /// </summary>
        ///****************************************************************************************
        public virtual string Racine { get; set; }

        ///****************************************************************************************
        /// <summary>
        /// Retourne la liste des enfants
        /// </summary>
        ///****************************************************************************************
        public virtual List<Item> GetEnfants
        { 
            get
            {
                return m_Enfants;
            } 
        }
        ///****************************************************************************************
        /// <summary>
        /// Retourne la liste des enfants
        /// </summary>
        ///****************************************************************************************
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

        ///****************************************************************************************
        /// <summary>
        /// Retourne la liste des enfants
        /// </summary>
        ///****************************************************************************************
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

        ///****************************************************************************************
        /// <summary>
        /// Type de l'item
        /// </summary>
        ///****************************************************************************************
        public eTypeItem TypeItem
        {
            get
            {
                return m_tItem;
            }

            private set { m_tItem = value; }
        }
        #endregion
   
    
    }
}
