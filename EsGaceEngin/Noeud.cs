using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace EsGaceEngin
{
    public class Noeud:Dictionary<string,Noeud>
    {
        Noeud m_Parent;
        public void Add(Item aItem)
        {
            base.Add(aItem.Chemin + aItem.Nom, aItem);

            aItem.Parent = this;
        }
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
        
    }
}
