using System.Windows;
using System.Windows.Controls;

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

    private static readonly DependencyPropertyKey IsEmptyPropertyKey =
        DependencyProperty.RegisterReadOnly(nameof(IsEmpty), typeof(bool),
            typeof(PlaceholderTextBox), new PropertyMetadata(true));

    public static readonly DependencyProperty IsEmptyProperty = IsEmptyPropertyKey.DependencyProperty;

    public bool IsEmpty
    {
        get => (bool)GetValue(IsEmptyProperty);
        private set => SetValue(IsEmptyProperty, value);
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