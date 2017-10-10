using System;
using System.Collections.Generic;
using System.IO;

namespace EsGaceEngin
{
    public class Repertoire : Item, iItem
    {
        private DirectoryInfo m_InfosRepertoire;

        //}
        public Repertoire(string Chemin, Item aParent)
        {
            m_InfosRepertoire = new DirectoryInfo(Chemin);
            base.Nom = m_InfosRepertoire.Name;
            base.m_tItem = eTypeItem.Repertoire;
            this.Parent = aParent;
        }

        internal Repertoire()
        {
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

        public override string CheminComplet
        {
            get
            {
                return m_InfosRepertoire.FullName;
            }
            set
            {
                base.Chemin = value;
            }
        }

        /// <summary>
        /// </summary>
        public DateTime DateCreation
        {
            get
            {
                return DateTime.Now;
            }
        }

        /// <summary>
        /// </summary>
        public DateTime DateDernierAcces
        {
            get
            {
                return DateTime.Now;
            }
        }

        /// <summary>
        /// </summary>
        public DateTime DateDerniereModification
        {
            get
            {
                return DateTime.Now;
            }
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
                            this.m_Enfants.Add(new Repertoire(dir.FullName, this));
                        }
                        foreach (FileInfo file in m_InfosRepertoire.GetFiles())
                        {
                            this.m_Enfants.Add(new Fichier(file.FullName, this));
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