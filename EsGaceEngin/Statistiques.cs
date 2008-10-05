
using System.Xml;
using System.IO;
using System;
namespace EsGaceEngin
{
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Classe permettant de créer et de récupérer les statistiques.
    /// Exemples:
    /// - Plus gros fichiers
    /// - Plus gros répertoire
    /// - Temps total d'analyse
    /// - Espaces sur les disques logiques
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    class Statistiques
    {
        private XmlDocument m_XMLDoc;
        ///****************************************************************************************
        /// <summary>
        /// Création de la classe de statistiques
        /// </summary>
        ///****************************************************************************************
        public Statistiques(string CheminFichierXML)
        {
            // Si le fichier existe
            if (File.Exists(CheminFichierXML))
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ConformanceLevel = ConformanceLevel.Fragment;
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;
                XmlTextReader reader = new XmlTextReader(CheminFichierXML);
                m_XMLDoc = new XmlDocument();
                m_XMLDoc.Load(reader);
                foreach (XmlNode Analyse in m_XMLDoc.ChildNodes)
                {
                    switch (Analyse.NodeType)
                    {
                        case XmlNodeType.Element:
                            break;
                    }
                    //Analyse.FirstChild
                }

               
                

            }
            else
            {

            }
        }
    }
}
