using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioPlayer.Domain.Models;

namespace AudioPlayer.WPF.ViewModels;

public class PlaylistViewModel : BaseViewModel
{
    private readonly Playlist _current;

    public PlaylistViewModel(Playlist current)
    {
        _current = current;
    }

    

}