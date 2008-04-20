using System.Collections.Generic;
using System.IO;
namespace EsGaceEngin
{
    public class Lecteur : Item
    {

        DriveInfo m_InfosDisque ;
        public Lecteur(string LettreDisque)
        {
            m_InfosDisque = new DriveInfo(LettreDisque);
            base.Nom = m_InfosDisque.Name;
            base.m_tItem= eTypeItem.Lecteur;

        }
        public Lecteur(DriveInfo InfosDisque)
        {
            m_InfosDisque = InfosDisque;
            base.Nom = m_InfosDisque.Name;
            base.m_tItem = eTypeItem.Lecteur;
        }
        public override long Taille
        {
            get
            {
                if (this.EstActif == true)
                {
                    this.Taille = m_InfosDisque.TotalSize - m_InfosDisque.TotalFreeSpace;
                }
                return base.Taille;
            }
            set
            {
                base.Taille = value;
            }
        }
        public long EspaceLibreDisponible { get; private set; }
        public long Format { get; private set; }
        public long Type { get; private set; }
        public bool EstActif 
        {
            get
            {
                return m_InfosDisque.IsReady;
            }
        }
        public long EspaceLibreTotal { get; private set; }

        public override string Racine
        {
            get
            {
                return m_InfosDisque.RootDirectory.Name;
                
            }

        }
        public override string Chemin
        {
            get
            {
                return m_InfosDisque.RootDirectory.FullName;
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
                return m_InfosDisque.RootDirectory.FullName;
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
                if (base.m_Enfants == null)
                {
                    base.m_Enfants = new System.Collections.Generic.List<Item>();
                }

                if (this.EstActif == true && this.NbEnfants <=0)
                {

                    foreach (DirectoryInfo dir in new DirectoryInfo(this.Nom).GetDirectories())
                    {
                        this.m_Enfants.Add(new Repertoire(dir.FullName,this));
                    }
                    foreach (FileInfo file in new DirectoryInfo(this.Nom).GetFiles())
                    {
                        this.m_Enfants.Add(new Fichier(file.FullName,this));
                    }
                }
                return base.GetEnfants;
            }
        }
}
}
