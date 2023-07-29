using System;
using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF.State;

public interface INavigator
{
    BaseViewModel CurrentViewModel { get; set; }
    event Action StateChanged;
}