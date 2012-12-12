using System;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Linq;

namespace MarkupSyntax
{
    public class RtlTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var str = value as string;
            if (str == null)
                return null;

            return new string(str.Reverse().ToArray());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var str = value as string;
            if (str == null)
                return null;

            return new string(str.Reverse().ToArray());
        }
    }
}