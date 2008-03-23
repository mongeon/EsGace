
using System;
using System.IO;
using System.Collections.Generic;
namespace EsGaceEngin
{
    public class Repertoire : Item, iItem
    {
        DirectoryInfo m_InfosRepertoire;
        public Repertoire()
        {

        }
        public Repertoire(string Chemin)
        {
            m_InfosRepertoire = new DirectoryInfo(Chemin);
            base.Nom = m_InfosRepertoire.Name;
        }
        /// <summary>
        /// Retourne si le répertoire existe.
        /// </summary>
        public bool Existe 
        { 
            get 
            {

                return m_InfosRepertoire.Exists;
            } 
        }
        public override string Chemin
        {
            get
            {
                return m_InfosRepertoire.Parent.FullName;
            }
            set
            {
                base.Chemin = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateCreation
        {
            get
            {
                return DateTime.Now;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateDernierAcces
        {
            get
            {
                return DateTime.Now;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateDerniereModification
        {
            get
            {
                return DateTime.Now;
            }
        }
        public override List<Item> GetEnfants
        {
            get
            {
                if (base.m_Enfants == null)
                {
                    base.m_Enfants = new System.Collections.Generic.List<Item>();
                }
                if (this.Existe == true && this.NbEnfants <= 0)
                {
                    try
                    {
                        foreach (DirectoryInfo dir in m_InfosRepertoire.GetDirectories())
                        {
                            this.m_Enfants.Add(new Repertoire(dir.FullName));
                        }
                        foreach (FileInfo file in m_InfosRepertoire.GetFiles())
                        {
                            this.m_Enfants.Add(new Fichier(file.FullName));
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                return base.GetEnfants;
            }
        }
    }
}
