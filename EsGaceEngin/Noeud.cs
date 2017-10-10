using System.Collections.Generic;

namespace EsGaceEngin
{
    public class Noeud : Dictionary<string, Noeud>
    {
        private Noeud m_Parent;

        ///****************************************************************************************
        /// <summary>
        ///
        /// </summary>
        ///****************************************************************************************
        public Noeud Parent
        {
            get
            {
                return m_Parent;
            }
            set
            {
                m_Parent = value;
            }
        }

        public void Add(Item aItem)
        {
            base.Add(aItem.Chemin + aItem.Nom, aItem);

            aItem.Parent = this;
        }
    }
}