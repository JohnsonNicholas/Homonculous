using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using SB118_CrewHistoryApp;

namespace Homonculous
{
   public class DateTimeToStardateConverter : IValueConverter
    {
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //date time to stardate
            var rawVal = (DateTime)value;

            if (value is DateTime && value != null)
                return new Stardate(rawVal);
            else
                return new Stardate();
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //stardate to date time
            var rawVal = value as Stardate;
            if (rawVal != null)
            {
                return new DateTime(rawVal.baseYear, rawVal.baseMnth, rawVal.baseDay);
            }
            else
                return DateTime.Today;
        }
    }
}
