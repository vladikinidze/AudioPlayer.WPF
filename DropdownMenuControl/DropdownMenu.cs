﻿using System.Windows;
using System.Windows.Controls;

namespace DropdownMenuControl;

public class DropdownMenu : ContentControl
{
    public static readonly DependencyProperty IsOpenProperty = 
        DependencyProperty.Register(nameof(IsOpen), typeof(bool), 
            typeof(DropdownMenu), new PropertyMetadata(false));
    
    public bool IsOpen
    {
        get => (bool)GetValue(IsOpenProperty);
        set => SetValue(IsOpenProperty, value);
    }
    
    static DropdownMenu()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(DropdownMenu),
            new FrameworkPropertyMetadata(typeof(DropdownMenu)));
    }
}