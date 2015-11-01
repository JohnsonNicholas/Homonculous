using System;
using SB118_CrewHistoryApp;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows;

namespace Homonculous
{
    public class YearToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Stardate input = value as Stardate;

            if (input > DateTime.Today)
                return Brushes.Red;

            if (input.baseYear > 2017 ) //if, you know, you're still using this program in 2017..
                return Brushes.MediumPurple;

            if (input.baseYear > 2011)
                    return Brushes.LightBlue;

            if (input.baseYear > 2005)
                    return Brushes.LightGreen;

            if (input.baseYear > 1999)
                    return Brushes.Yellow;

            if (input.baseYear > 1994)
                    return Brushes.Orange;
            
            return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
