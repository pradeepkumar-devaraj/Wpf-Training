using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfDataBinding
{
    class StringIntegerToColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is string && ((string)values[0]) == "Emp 1" && values[1] is int && ((int)values[1]) < 20)
            {
                return Brushes.Green;
            }

            return Brushes.Red;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
