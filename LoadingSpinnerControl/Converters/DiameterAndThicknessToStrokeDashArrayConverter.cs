﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace LoadingSpinnerControl.Converters;

public class DiameterAndThicknessToStrokeDashArrayConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values.Length < 2
            || !double.TryParse(values[0].ToString(), out var diameter)
            || !double.TryParse(values[1].ToString(), out var thickness))
        {
            return 0;
        }
        var circumference = Math.PI * (diameter - thickness);
        var lineLength = circumference * 0.75;
        var gapLength = circumference - lineLength;
        return new DoubleCollection(new[] { lineLength / thickness, gapLength / thickness });
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}