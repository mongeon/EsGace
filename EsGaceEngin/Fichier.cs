using System.Collections.Generic;
using System.IO;

namespace EsGaceEngin
{
    public class Fichier : Repertoire, iItem
    {
        private FileInfo m_InfosFichier;
        //public Fichier(string Chemin)
        //{
        //    m_InfosFichier = new FileInfo(Chemin);
        //    base.Nom = m_InfosFichier.Name;
        //    base.m_tItem = eTypeItem.Fichier;

        //}
        public Fichier(string Chemin, Item aParent)
        {
            m_InfosFichier = new FileInfo(Chemin);
            base.Nom = m_InfosFichier.Name;
            base.m_tItem = eTypeItem.Fichier;
            this.Parent = aParent;
        }

        public override string Chemin
        {
            get
            {
                return m_InfosFichier.DirectoryName;
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
                return m_InfosFichier.FullName;
            }
            set
            {
                base.CheminComplet = value;
            }
        }

        public override List<Item> GetEnfants
        {
            get
            {
                return new List<Item>();
            }
        }

        public override int NbEnfants
        {
            get
            {
                return 0;
            }
        }

        public override long Taille
        {
            get
            {
                try
                {
                    this.Taille = m_InfosFichier.Length;
                }
                catch (System.Exception)
                {
                    this.Taille = 0;
                }
                finally
                {
                    DejaAnalyser = true;
                }
                return base.Taille;
            }
            set
            {
                DejaAnalyser = true;
                base.Taille = value;
            }
        }
    }
}