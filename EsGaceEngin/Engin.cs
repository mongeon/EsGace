using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace EsGaceEngin
{
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Engin d'analyse des fichiers sur le disque dur.
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    public class Engin
    {
        #region Enumérations =======================================================================

        /// <summary>
        /// Dicte l'état de l'engin
        /// </summary>
        [Flags]
        public enum Etat
        {
            EnCours = 0x01,
            Annuler = 0x02,
            AnnulationEnAttente = 0x04,
            Erreur = 0x08,
            EnAttente = 0x16,
        }

        #endregion Enumérations =======================================================================

        #region Delegates =========================================================================

        public delegate void EnginEtatModifierEventHandler(object sender, Etat etat);

        // Declare the delegate (if using non-generic pattern).
        public delegate void EnginEventHandler(object sender, Item e);

        public delegate void EnginProgressionEventHandler(object sender, string e);

        #endregion Delegates =========================================================================

        #region Évènements ========================================================================

        // Declare the event.
        public event EnginEventHandler AnalyseCompleter;

        public event EnginProgressionEventHandler AnalyseProgression;

        public event EnginEtatModifierEventHandler EtatModifier;

        #endregion Évènements ========================================================================

        #region Variables =========================================================================

        /// <summary>
        /// Analyseur en arrière plan
        /// </summary>
        private BackgroundWorker m_bgwAnalyse;

        /// <summary>
        /// Liste des lecteurs racines
        /// </summary>
        private List<Lecteur> m_DisquesRacine;

        /// <summary>
        /// Etat actuel de l'engin
        /// </summary>
        private Etat m_Etat = Etat.EnAttente;

        #endregion Variables =========================================================================

        ///****************************************************************************************
        /// <summary>
        /// Constructeur
        /// </summary>
        ///****************************************************************************************
        public Engin()
        {
            m_bgwAnalyse = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            m_bgwAnalyse.DoWork += new DoWorkEventHandler(BgwAnalyse_DoWork);
            m_bgwAnalyse.ProgressChanged += new ProgressChangedEventHandler(BgwAnalyse_ProgressChanged);
            m_bgwAnalyse.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BgwAnalyse_RunWorkerCompleted);

            m_DisquesRacine = new List<Lecteur>();

            // Parcours tous les disques disponibles
            foreach (string disque in Directory.GetLogicalDrives())
            {
                // Il les ajoutes.
                m_DisquesRacine.Add(new Lecteur(disque));
            }

            Statistiques stats = new Statistiques(@"F:\Mes Documents\Visual Studio 2008\Projects\EsGace\Stats.xml");
        }

        /// <summary>
        /// Retourne la liste des lecteurs racines
        /// </summary>
        public List<Lecteur> DisqueRacines
        {
            get { return m_DisquesRacine; }
        }

        /// <summary>
        /// Etat actuel de l'engin EnCours = 0x01, Annuler = 0x02, AnnulationEnAttente = 0x04, Erreur
        /// = 0x08, EnAttente = 0x16,
        /// </summary>
        public Etat EtatEngin
        {
            get
            {
                return m_Etat;
            }
        }

        public long Analyse()
        {
            m_Etat = Etat.EnCours;
            EtatModifier?.Invoke(this, EtatEngin);
            m_bgwAnalyse.RunWorkerAsync();
            return 0;
        }

        ///****************************************************************************************
        /// <summary>
        /// Annule l'analyse en cours.
        /// </summary>
        ///****************************************************************************************
        public void AnnulerAnalyse()
        {
            if (m_bgwAnalyse != null)
            {
                m_Etat = Etat.AnnulationEnAttente;
                EtatModifier?.Invoke(this, EtatEngin);
                m_bgwAnalyse.CancelAsync();
            }
        }

        private long AnalyseRecursive(Item item)
        {
            if (m_bgwAnalyse.CancellationPending)
                return 0;

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

        ///****************************************************************************************
        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///****************************************************************************************
        private void BgwAnalyse_DoWork(object sender, DoWorkEventArgs e)
        {
            long Taille = 0;

            foreach (Item item in m_DisquesRacine)
            {
                if (m_bgwAnalyse.CancellationPending)
                    break;
                if ((item is Lecteur && ((Lecteur)item).EstActif))// && item.Nom != "C:\\")
                {
                    m_bgwAnalyse.ReportProgress(-1, item);
                    Taille += AnalyseRecursive(item);
                }
            }
        }

        private void BgwAnalyse_ProgressChanged(object sender, ProgressChangedEventArgs e)
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

        private void BgwAnalyse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                m_Etat = Etat.Annuler;
            }
            else
            {
                m_Etat = Etat.EnAttente;
            }

            EtatModifier?.Invoke(this, EtatEngin);
            AnalyseCompleter?.Invoke(this, new Item());
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
    }
}