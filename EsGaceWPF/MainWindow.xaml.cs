using System.Windows;
using System;
using EsGaceEngin;
using System.Windows.Controls;
using EsGace.Classes;
using System.Collections.Generic;

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
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            analyseResults.AddHandler(TreeViewItem.ExpandedEvent, new RoutedEventHandler(analyseResults_ItemExpanded));

            // Ajout de l'onglet détails dans la liste
            //tcOutilsAdditionnels.Controls.Add(new TabPageDetails());

            //analyseResults.Items.SortDescriptions TreeViewNodeSorter = new NodeSorter();
            //ChargementImage();
            m_moteur = new Engin();
            //m_moteur.AnalyseCompleter += new Engin.EnginEventHandler(m_moteur_AnalyseCompleter);
            //m_moteur.AnalyseProgression += new Engin.EnginProgressionEventHandler(m_moteur_AnalyseProgression);
            //m_moteur.EtatModifier += new Engin.EnginEtatModifierEventHandler(m_moteur_EtatModifier);
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
    }
}
