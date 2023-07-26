using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModalControl;

public class Modal : ContentControl
{
    static Modal()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Modal),
            new FrameworkPropertyMetadata(typeof(Modal)));
        BackgroundProperty.OverrideMetadata(typeof(Modal), new FrameworkPropertyMetadata(CreateDefaultBackground()));
    }

    private static object CreateDefaultBackground()
    {
        return new SolidColorBrush(Colors.Black)
        {
            Opacity = 0.4,
        };
    }

    public static readonly DependencyProperty IsOpenProperty =
        DependencyProperty.Register(nameof(IsOpen), typeof(bool),
            typeof(Modal), new PropertyMetadata(false));

    public bool IsOpen
    {
        get => (bool)GetValue(IsOpenProperty);
        set => SetValue(IsOpenProperty, value);
    }
}