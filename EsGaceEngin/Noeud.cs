using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace EsGaceEngin
{
    public class Noeud:Dictionary<string,Noeud>
    {
        public void Add(Item aItem)
        {
            base.Add(aItem.Chemin + aItem.Nom, aItem);
        }
        
    }
}
