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
        private List<Lecteur> m_DisquesRacine;
        private List<BackgroundWorker> m_listeBGW = new List<BackgroundWorker>();

        public  List<Lecteur> DisqueRacines
        {
            get { return m_DisquesRacine; } 
        }
        public Engin()
        {
            m_DisquesRacine = new List<Lecteur>();

            foreach( string disque in Directory.GetLogicalDrives())
            {
                m_DisquesRacine.Add( new Lecteur(disque));
            }
        }
        // Declare the delegate (if using non-generic pattern).
       public delegate void EnginEventHandler(object sender, Item e);

        // Declare the event.
        public event EnginEventHandler AnalysePartielCompleter;
        // Declare the event.
        public event EnginEventHandler AnalyseCompleter;
        public void Analyse(int NbAnalyseurs)
        {
            m_listeBGW.Clear();

            for (int i = 0; i < NbAnalyseurs; i++)
            {
                BackgroundWorker bgw = new BackgroundWorker();
                bgw.WorkerSupportsCancellation = true;
                bgw.WorkerReportsProgress = true;
                bgw.DoWork += new DoWorkEventHandler(bgwAnalyse_DoWork);
                bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwAnalyse_RunWorkerCompleted);
                bgw.ProgressChanged += new ProgressChangedEventHandler(bgwAnalyse_ProgressChanged);
                m_listeBGW.Add(bgw);
            }
            foreach (BackgroundWorker bgw in m_listeBGW)
            {
                bgw.RunWorkerAsync();
            }

        }
        public void AnnulerAnalyse()
        {
            foreach (BackgroundWorker bgw in m_listeBGW)
            {
                if (bgw.CancellationPending == false)
                    bgw.CancelAsync();
            }
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
        public long Analyse(Item item, int NbAnalyseurs)
        {
            m_listeBGW.Clear();

            for (int i = 0; i < NbAnalyseurs; i++)
            {
                BackgroundWorker bgw =new BackgroundWorker();

                bgw.WorkerSupportsCancellation = true;
                bgw.WorkerReportsProgress = true;
                bgw.DoWork += new DoWorkEventHandler(bgwAnalyse_DoWork);
                bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwAnalyse_RunWorkerCompleted);
                bgw.ProgressChanged += new ProgressChangedEventHandler(bgwAnalyse_ProgressChanged);
                m_listeBGW.Add(bgw);
                bgw.RunWorkerAsync(item);
                
                
            }
            return 0;
        }

        void bgwAnalyse_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is Item)
            {
                if (AnalysePartielCompleter != null)
                    {
                        AnalysePartielCompleter(this, (Item)e.UserState);
                    }
            }
        }
        
        void bgwAnalyse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == false)
            {
                if (e.Result is Item)
                {
                    if (AnalysePartielCompleter != null)
                    {
                        AnalysePartielCompleter(this, (Item)e.Result);
                    }
                }
                if (AnalyseCompleter != null && e.Result is Item)
                {
                    AnalyseCompleter(this, (Item)e.Result);
                }
            }
            //foreach (BackgroundWorker bgw in m_listeBGW)
            //{
               
            //    if (bgw.IsBusy == false)
            //    {
            //        foreach (Item item in m_DisquesRacine)
            //        {
            //            Item n_item = TrouverItemNonAnalyser(item);
            //            if (n_item != null || n_item.DejaAnalyser == false)
            //            {
            //                bgw.RunWorkerAsync(n_item);
            //            }
            //        }

            //    }
            //}
        }

        void bgwAnalyse_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = (BackgroundWorker)sender;

            if (bgw.CancellationPending == false)
            {

                //if (e.Argument is Item)
                //{
                //    long TEST = AnalyseRecursive((Item)e.Argument);
                //    e.Result = (Item)e.Argument;
                //}
                foreach (Item item in m_DisquesRacine)
                {
                    if (item.Nom != "C:\\")
                    {


                        if (bgw.CancellationPending == false)
                        {
                            long TEST = AnalyseRecursive(item,bgw);
                            e.Result = item;
                        }
                        else
                        {
                            e.Cancel = true;
                            bgw.CancelAsync();
                        }
                        if (bgw.WorkerReportsProgress)
                        {
                            bgw.ReportProgress(0, item);
                        }
                    }
                }

            }
        }
        private long AnalyseRecursive(Item item,BackgroundWorker bgw)
        {
            if (bgw.CancellationPending) 
                return 0;
  
            long taille = 0;
            if (item is Fichier)
            {
                return item.Taille;
            }
            foreach (Item s_item in item.GetEnfants)
            {
                taille += AnalyseRecursive(s_item,bgw);
            }
            if (item is Repertoire)
            {
                item.Taille =taille;
            }
            return taille;
        }
    }
}
