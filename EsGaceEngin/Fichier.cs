using System.Collections.Generic;
using System.IO;

namespace EsGaceEngin
{
    public class Fichier : Repertoire, iItem
    {
        private FileInfo m_InfosFichier;
        public Fichier(string Chemin)
        {
            m_InfosFichier = new FileInfo(Chemin);
            base.Nom = m_InfosFichier.Name;

        }
        public override List<Item> GetEnfants
        {
            get
            {
                return new List<Item>();
            }
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
                    this.Taille= 0;
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
        public override int NbEnfants
        {
            get
            {
                return 0;
            }
        }
    }
}
