using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using AudioPlayer.WPF.Models;

namespace AudioPlayer.WPF.Components;

public partial class PlaylistList : UserControl
{
    public PlaylistList()
    {
        InitializeComponent();
        ListView.ItemsSource = new List<Playlist>
        {
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new() { Author = "жак руссо", Id = 1, Title = "Утопия" },
        };
    }
}