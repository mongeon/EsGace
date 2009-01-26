using System;
using System.Reflection;
using System.Resources;

namespace EsGace.Classes
{
    class FonctionsGenerales
    {
        public static string TransformerTailleEnTexte(long taille)
        {
            Double TailleD = Convert.ToDouble(taille);
            int dec = Convert.ToInt32(EsGaceWPF.Properties.Settings.Default.Decimal);
            if (TailleD <= 1024)
            {
                return Math.Round(TailleD, dec).ToString() + " " + Traduction("Octet"); ;
            }
            else if (TailleD <= 1024 * 1024)
            {
                return Math.Round((TailleD / 1024), dec).ToString() + " " + Traduction("KiloOctet");
            }
            else if (TailleD <= 1024 * 1024 * 1024)
            {
                return Math.Round((TailleD / (1024 * 1024)), dec).ToString() + " " + Traduction("MegaOctet");
            }
            else
            {
                return Math.Round((TailleD / (1024 * 1024 * 1024)), dec).ToString() + " " + Traduction("GigaOctet");

            }
        }
        public static string Traduction(string Texte)
        {
            try
            {
                ResourceManager LocRM = new ResourceManager("EsGaceWPF.ResourcesEsGace", Assembly.GetExecutingAssembly());
                LocRM.IgnoreCase = true;
                return LocRM.GetString(Texte);
            }
            catch (Exception)
            {

                return Texte;
            }

        }
    }
}
