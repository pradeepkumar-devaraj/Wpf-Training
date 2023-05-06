using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfTreeViewDataBinding
{
    class TypeToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Parent)
            {
                return "./Images/folder.jpg";
            }
            else
            {
                return "./Images/file.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
