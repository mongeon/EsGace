using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using EsGace.Classes;
using EsGaceEngin;

namespace EsGaceWPF
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables =========================================================================

        /// <summary>
        /// Engin d'analyse des répertoires.
        /// </summary>
        private Engin m_moteur;

        /// <summary>
        /// Temps de départ pour l'analyse, nécessaire lorsque l'analyse roule et on désire en 
        /// connaitre le temps écoulé.
        /// </summary>
        private DateTime m_HeureDepartAnalyse;

        private DispatcherTimer m_timerElapsed;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            analyseResults.AddHandler(TreeViewItem.ExpandedEvent, new RoutedEventHandler(analyseResults_ItemExpanded));

            m_timerElapsed = new DispatcherTimer();
            m_timerElapsed.Interval = new TimeSpan(0,0,0,1);
           
            m_timerElapsed.Stop();
            m_timerElapsed.Tick += new EventHandler(m_timerElapsed_Tick);
            // Ajout de l'onglet détails dans la liste
            //tcOutilsAdditionnels.Controls.Add(new TabPageDetails());

            //analyseResults.Items.SortDescriptions TreeViewNodeSorter = new NodeSorter();
            //ChargementImage();
            m_moteur = new Engin();
            m_moteur.AnalyseCompleter += new Engin.EnginEventHandler(m_moteur_AnalyseCompleter);
            m_moteur.AnalyseProgression += new Engin.EnginProgressionEventHandler(m_moteur_AnalyseProgression);
            m_moteur.EtatModifier += new Engin.EnginEtatModifierEventHandler(m_moteur_EtatModifier);
            try
            {
                foreach (EsGaceEngin.Item disque in m_moteur.DisqueRacines)
                {

                    AjouterItemArbre(null, disque);

                }
            }
            catch (Exception)
            {

                throw;
            }

            // Affiche les bons contrôles disponibles
            //AjusterFenetreSelonEtat();
        }

        void m_timerElapsed_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - m_HeureDepartAnalyse;
            elapsedTime.Content = ts.ToString().Substring(0, 8);//ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString();

        }

       
        ///****************************************************************************************
        /// <summary>
        /// Ajoute un item dans l'arbre
        /// </summary>
        /// <param name="NoeudParent">Le noeud parent sous lequel on ajoute un noeud</param>
        /// <param name="item">Un item à ajouter</param>
        /// <returns>Vrai si l'ajout à été réussi.</returns>
        ///****************************************************************************************
        private bool AjouterItemArbre(TreeViewItem NoeudParent, EsGaceEngin.Item item)
        {

            TreeViewItem tn = new TreeViewItem();
            tn.Header = item.Nom;

            tn.Tag = item;
            if (item.Taille >= 0)
            {
                tn.Header = item.Nom + "  ["
                + FonctionsGenerales.TransformerTailleEnTexte(item.Taille)
                + "]";
            }
            if (item is Fichier == false) { tn.Items.Add("Dummy"); }

            //AjouterImageNoeudArbre(tn);
            //AjusterCouleurNoeudArbre(tn);

            if (NoeudParent == null)
            {

                analyseResults.Items.Add(tn);
            }
            else
            {
                NoeudParent.Items.Add(tn);
            }

            return true;

        }
        //}
        //private void tvEsGace_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    if (e.Node != null)
        //    {
        //        if (e.Node.Tag is Item)
        //        {
        //            Item item = (Item)e.Node.Tag;
        //            tcOutilsAdditionnels.Item = item;
        //            //diPrincipale.ItemCourant = item;
        //            tmiPrincipale.ItemCourant = item;

        //        }
        //        else
        //        {
        //            txtDetails.Text = "";
        //        }
        //    }

        //}

        ///****************************************************************************************
        /// <summary>
        /// Lance l'analyse complète
        /// </summary>
        ///****************************************************************************************
        private void LancerAnalyseComplete()
        {
            m_HeureDepartAnalyse = new DateTime();
            m_HeureDepartAnalyse = DateTime.Now;
            footer.Visibility = System.Windows.Visibility.Visible;
            m_timerElapsed.Start();
            m_moteur.Analyse();
        }
        private void analyseResults_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue is TreeViewItem)
            {
                Item item = (Item)((TreeViewItem)e.NewValue ).Tag;
                itemName.Text = item.Nom;
                itemFolder.Text = item.Chemin;
                itemSize.Text = FonctionsGenerales.TransformerTailleEnTexte(item.Taille);
            }
            else
            {
                itemName.Text = "";
                itemFolder.Text = "";
                itemSize.Text = "";
            }


        }
        
        private void analyseResults_ItemExpanded(object sender, RoutedEventArgs e)
        {
            if (e.Source is TreeViewItem)
            {
                TreeViewItem tn = (TreeViewItem)e.Source;
                if (tn.Items != null)
                {
                    tn.Items.Clear();

                    //foreach (TreeNode tn in e.Node.Nodes)
                    //{
                    //    foreach (Item item in ((Item)tn.Tag).GetEnfants)
                    //    {
                    //        AjouterItemArbre(tn, item);
                    //    }
                    //}
                    if (tn.Tag != null && tn.Tag is EsGaceEngin.Item)
                    {

                        List<Item> itemsEnfants = ((EsGaceEngin.Item)tn.Tag).GetEnfants;

                        foreach (Item item in itemsEnfants)
                        {
                            AjouterItemArbre(tn, item);
                        }
                    }
                }
            }

        }
        #region Moteur / Engin ====================================================================

        ///****************************************************************************************
        /// <summary>
        /// Lorsque le moteur change d'état, on modifie l'interface pour l'interaction avec 
        /// l'usager.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="etat"></param>
        ///****************************************************************************************
        void m_moteur_EtatModifier(object sender, Engin.Etat etat)
        {
            //AjusterFenetreSelonEtat();
        }

        ///****************************************************************************************
        /// <summary>
        /// Met à jour le statut de l'analyse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///****************************************************************************************
        void m_moteur_AnalyseProgression(object sender, string e)
        {
            if (Properties.Settings.Default.AfficherFichierAnalyse)
            {
                progressionText.Text = e;
                
            }
            else
            {
                progressionText.Text = "";
                
            }

            progression.IsIndeterminate = true;

        }

        ///****************************************************************************************
        /// <summary>
        /// Lorsque l'analyse se termine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">L'item qui a été analyser</param>
        ///****************************************************************************************
        void m_moteur_AnalyseCompleter(object sender, Item e)
        {
            foreach (TreeViewItem tn in analyseResults.Items)
            {
                foreach (Item item in ((Item)tn.Tag).GetEnfants)
                {
                    AjouterItemArbre(tn, item);
                }

            }

            //analyseResults.Sort();
           // analyseResults.Enabled = true;

            progressionText.Text = "";
            progression.IsIndeterminate = false;
            m_timerElapsed.Stop();
            footer.Visibility = System.Windows.Visibility.Collapsed;

        }
        #endregion

        private void complete_Click(object sender, RoutedEventArgs e)
        {
            LancerAnalyseComplete();
        }

        private void analyzeCancel_Click(object sender, RoutedEventArgs e)
        {
            m_moteur.AnnulerAnalyse();
        }
    }
}
