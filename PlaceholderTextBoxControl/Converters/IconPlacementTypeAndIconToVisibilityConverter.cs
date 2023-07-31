using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace PlaceholderTextBox.Converters;

public class IconPlacementTypeAndIconToVisibilityConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values[0] is not IconPlacementType iconType) 
            return Visibility.Collapsed;
        if ((Geometry)values[1] == Geometry.Empty) 
            return Visibility.Collapsed;

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

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}