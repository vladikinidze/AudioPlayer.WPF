using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace PlaceholderTextBox.Converters;

public class IconTypeToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not IconPlacementType iconType) return Visibility.Collapsed; ;
        switch (iconType)
        {
            case IconPlacementType.None:
                return Visibility.Collapsed;
            case IconPlacementType.Before when (string)parameter == "Before":
            case IconPlacementType.After when (string)parameter == "After":
                return Visibility.Visible;
            default:
                return Visibility.Collapsed;
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}