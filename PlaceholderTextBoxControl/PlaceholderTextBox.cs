using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PlaceholderTextBox;

public class PlaceholderTextBox : TextBox
{
    public static readonly DependencyProperty PlaceholderProperty =
        DependencyProperty.Register(nameof(Placeholder), typeof(string),
            typeof(PlaceholderTextBox), new PropertyMetadata(string.Empty));

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    //private static readonly DependencyPropertyKey IsEmptyPropertyKey =
    //    DependencyProperty.RegisterReadOnly(nameof(IsEmpty), typeof(bool),
    //        typeof(PlaceholderTextBox), new PropertyMetadata(true));

    //public static readonly DependencyProperty IsEmptyProperty = IsEmptyPropertyKey.DependencyProperty;

    public static readonly DependencyProperty IsEmptyProperty =
        DependencyProperty.Register(nameof(IsEmpty), typeof(bool),
            typeof(PlaceholderTextBox), new PropertyMetadata(true));

    public bool IsEmpty
    {
        get => (bool)GetValue(IsEmptyProperty);
        private set => SetValue(IsEmptyProperty, value);
    }

    public IconPlacementType IconPlacementType
    {
        get => (IconPlacementType)GetValue(IconPlacementTypeProperty);
        set => SetValue(IconPlacementTypeProperty, value);
    }

    public static readonly DependencyProperty IconPlacementTypeProperty =
        DependencyProperty.Register(nameof(IconPlacementType), typeof(IconPlacementType),
            typeof(PlaceholderTextBox), new PropertyMetadata(IconPlacementType.None));

    

    public static readonly DependencyProperty IconPathDataProperty =
        DependencyProperty.Register(nameof(IconPathData), typeof(Geometry),
            typeof(PlaceholderTextBox), new PropertyMetadata(Geometry.Empty));

    public Geometry IconPathData
    {
        get => (Geometry)GetValue(IconPathDataProperty);
        set => SetValue(IconPathDataProperty, value);
    }

    public static readonly DependencyProperty FocusedIconPathDataProperty =
        DependencyProperty.Register(nameof(FocusedIconPathData), typeof(Geometry),
            typeof(PlaceholderTextBox), new PropertyMetadata(Geometry.Empty));

    public Geometry FocusedIconPathData
        {
        get => (Geometry)GetValue(FocusedIconPathDataProperty);
        set => SetValue(FocusedIconPathDataProperty, value);
        }


    static PlaceholderTextBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(PlaceholderTextBox),
            new FrameworkPropertyMetadata(typeof(PlaceholderTextBox)));
    }

    protected override void OnTextChanged(TextChangedEventArgs e)
    {
        IsEmpty = string.IsNullOrEmpty(Text);
        base.OnTextChanged(e);
    }
}