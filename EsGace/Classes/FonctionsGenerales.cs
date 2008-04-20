using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsGace.Classes
{
    class FonctionsGenerales
    {
        public static string TransformerTailleEnTexte(long taille)
        {
            Double TailleD = Convert.ToDouble(taille);
            int dec = Convert.ToInt32(Properties.Settings.Default.Decimal);
            if (TailleD <= 1024)
            {
                return Math.Round(TailleD, dec).ToString() + " o";
            }
            else if (TailleD <= 1024 * 1024)
            {
                return Math.Round((TailleD / 1024), dec).ToString() + " ko";
            }
            else if (TailleD <= 1024 * 1024 * 1024)
            {
                return Math.Round((TailleD / (1024 * 1024)), dec).ToString() + " mo";
            }
            else
            {
                return Math.Round((TailleD / (1024 * 1024 * 1024)), dec).ToString() + " go";

            }
        }
    }
}
