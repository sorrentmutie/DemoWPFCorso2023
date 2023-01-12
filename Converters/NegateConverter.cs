using System;
using System.Globalization;
using System.Windows.Data;

namespace DemoWPF.Converters
{
    public class NegateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = (bool)value;
            return !result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = (bool)value;
            return !result;
        }
    }
}
