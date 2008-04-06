using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace EsGaceEngin
{

    public class Engin
    {
        private BackgroundWorker m_bgwAnalyse ;
        /// <summary>
        /// Liste des lecteurs racines
        /// </summary>
        private List<Lecteur> m_DisquesRacine;

        /// <summary>
        /// Retourne la liste des lecteurs racines
        /// </summary>
        public List<Lecteur> DisqueRacines
        {
            get { return m_DisquesRacine; }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Engin()
        {
            m_bgwAnalyse = new BackgroundWorker();
            m_bgwAnalyse.WorkerReportsProgress = true;
            m_bgwAnalyse.DoWork += new DoWorkEventHandler(m_bgwAnalyse_DoWork);
            m_bgwAnalyse.ProgressChanged += new ProgressChangedEventHandler(m_bgwAnalyse_ProgressChanged);
            m_bgwAnalyse.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_bgwAnalyse_RunWorkerCompleted);

            m_DisquesRacine = new List<Lecteur>();

            foreach (string disque in Directory.GetLogicalDrives())
            {
                m_DisquesRacine.Add(new Lecteur(disque));
            }
        }

        void m_bgwAnalyse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (AnalyseCompleter != null)
            {
                AnalyseCompleter(this,new Item());
            }
        }

        void m_bgwAnalyse_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Rapporte le changement de l'analyse!
            if (AnalyseProgression != null)
            {
                if (e.UserState is Item)
                {
                    AnalyseProgression(this, ((Item)e.UserState).Chemin);
                }
               

            }
        }

        void m_bgwAnalyse_DoWork(object sender, DoWorkEventArgs e)
        {
            long Taille = 0;

            foreach (Item item in m_DisquesRacine)
            {
                if ((item is Lecteur && ((Lecteur)item).EstActif) && item.Nom != "C:\\")
                {


                    m_bgwAnalyse.ReportProgress(-1,item);

                    Taille += AnalyseRecursive(item);
                }
            }


        }
        // Declare the delegate (if using non-generic pattern).
        public delegate void EnginEventHandler(object sender, Item e);
        public delegate void EnginProgressionEventHandler(object sender, string e);

        // Declare the event.
        public event EnginEventHandler AnalyseCompleter;
        public event EnginProgressionEventHandler AnalyseProgression;

        public void AnnulerAnalyse()
        {
            //TODO: Basculer Variable d'analyse!
        }
        private Item TrouverItemNonAnalyser(Item ItemDepart)
        {
            if (ItemDepart.DejaAnalyser == true)
            {
                return null;
            }
            else
            {
                if (ItemDepart.NbEnfants <= -1)
                {
                    ItemDepart.DejaAnalyser = true;
                    return ItemDepart;
                }
                else if (ItemDepart is Fichier || ItemDepart.NbEnfants == 0)
                {
                    ItemDepart.DejaAnalyser = true;
                    return null;
                }
                else
                {
                    foreach (Item item in ItemDepart.GetEnfants)
                    {
                        Item n_item = (TrouverItemNonAnalyser(item));
                        if (n_item != null)
                        {
                            n_item.DejaAnalyser = true;
                            return n_item;
                        }
                    }

                }
            }
            return null;
        }

        public long Analyse()
        {

            m_bgwAnalyse.RunWorkerAsync();
            return 0;
        }



        private long AnalyseRecursive(Item item)
        {
            //if (bgw.CancellationPending) 
            //    return 0;

            long taille = 0;
            // Rapporte le changement
            if (AnalyseProgression != null)
            {
                m_bgwAnalyse.ReportProgress(-1, item);
                //AnalyseProgression(this, item.Chemin);
            }
            if (item is Fichier)
            {
                return item.Taille;
            }
            foreach (Item s_item in item.GetEnfants)
            {
                taille += AnalyseRecursive(s_item);
            }
            if (item is Repertoire)
            {
                item.Taille = taille;
            }
            return taille;
        }
    }
}
