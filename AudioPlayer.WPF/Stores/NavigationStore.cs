using System;
using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF.Stores;

public class NavigationStore
{
    public event Action CurrentViewModelChanged = null!;

    private BaseViewModel _currentViewModel = null!;

    public BaseViewModel CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            _currentViewModel?.Dispose();
            _currentViewModel = value;
            OnCurrentViewModelChanged();
        }
    }

    protected virtual void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }
}