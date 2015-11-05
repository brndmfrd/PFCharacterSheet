using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace NavigationBarModule.Resources
{
    public class NavigationConverters : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {            
            if (value is bool)
            {
                if ((bool)value)
                {
                    return System.Windows.Media.Brushes.Blue;
                }
                else
                {
                    return System.Windows.Media.Brushes.Black;
                }

            }
            return System.Windows.Media.Brushes.Red;
        }

        // ConvertBack is not implemented for a OneWay binding.
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return false;
        }
    }
}
