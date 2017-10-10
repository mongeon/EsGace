using EsGaceEngin;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace EsGaceWPF
{
    #region HeaderToImageConverter

    [ValueConversion(typeof(Item), typeof(bool))]
    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BitmapImage source = null;
            Uri uri;
            switch ((value as Item).TypeItem)
            {
                case Item.eTypeItem.Indefini:
                    break;

                case Item.eTypeItem.Lecteur:
                    uri = new Uri("pack://application:,,,/Images/drive.png");
                    source = new BitmapImage(uri);

                    break;

                case Item.eTypeItem.Repertoire:
                    uri = new Uri("pack://application:,,,/Images/folder.png");
                    source = new BitmapImage(uri);

                    break;

                case Item.eTypeItem.Fichier:
                    uri = new Uri("pack://application:,,,/Images/page.png");
                    source = new BitmapImage(uri);

                    break;
            }
            return source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Cannot convert back");
        }
    }

    #endregion HeaderToImageConverter
}