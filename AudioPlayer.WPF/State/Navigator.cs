using System;
using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF.State;

public class Navigator : INavigator
{
    private BaseViewModel _currentViewModel;
    public BaseViewModel CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            _currentViewModel?.Dispose();
            _currentViewModel = value;
            StateChanged?.Invoke();
        }
    }

    public event Action StateChanged;

}