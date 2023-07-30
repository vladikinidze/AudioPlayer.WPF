using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RadioButtonWithIconControl
{
    public class RadioButtonWithIcon : RadioButton
    {
        public static readonly DependencyProperty IconPathDataProperty =
            DependencyProperty.Register(nameof(IconPathData), typeof(Geometry),
                typeof(RadioButtonWithIcon), new PropertyMetadata(Geometry.Empty));

        public Geometry IconPathData
        {
            get => (Geometry)GetValue(IconPathDataProperty);
            set => SetValue(IconPathDataProperty, value);
        }

        public static readonly DependencyProperty IconPlacementTypeProperty =
            DependencyProperty.Register(nameof(IconPlacementType), typeof(IconPlacementType),
                typeof(RadioButtonWithIcon), new PropertyMetadata(IconPlacementType.None));

        public IconPlacementType IconPlacementType
        {
            get => (IconPlacementType)GetValue(IconPlacementTypeProperty);
            set => SetValue(IconPlacementTypeProperty, value);
        }

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.Register(nameof(CheckedBackground), typeof(Brush),
                typeof(RadioButtonWithIcon), new PropertyMetadata(Brushes.CornflowerBlue));

        public Brush CheckedBackground
        {
            get => (Brush)GetValue(CheckedBackgroundProperty);
            set => SetValue(CheckedBackgroundProperty, value);
        }

        public static readonly DependencyProperty IconMarginProperty =
            DependencyProperty.Register(nameof(IconMargin), typeof(Thickness),
                typeof(RadioButtonWithIcon), new PropertyMetadata(new Thickness(0)));

        public Thickness IconMargin
        {
            get => (Thickness)GetValue(IconMarginProperty);
            set => SetValue(IconMarginProperty, value);
        }

        public static readonly DependencyProperty CheckedIconPathDataProperty =
            DependencyProperty.Register(nameof(CheckedIconPathData), typeof(Geometry),
                typeof(RadioButtonWithIcon), new PropertyMetadata(Geometry.Empty));

        public Geometry CheckedIconPathData
        {
            get => (Geometry)GetValue(CheckedIconPathDataProperty);
            set => SetValue(CheckedIconPathDataProperty, value);
        }


        static RadioButtonWithIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadioButtonWithIcon), 
                new FrameworkPropertyMetadata(typeof(RadioButtonWithIcon)));
        }
    }
}
