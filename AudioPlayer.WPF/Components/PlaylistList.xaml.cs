using System.Collections.Generic;
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
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
            new Playlist { Author = "жак руссо", Id = 1, Title = "Утопия" },
        };
    }
}