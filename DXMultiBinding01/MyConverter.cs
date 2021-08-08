using System;
using System.Globalization;
using System.Windows.Data;

namespace DXMultiBinding01
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class MyConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)values[0] == true && (bool)values[1] == true)
                return true;
            else
                return false;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
