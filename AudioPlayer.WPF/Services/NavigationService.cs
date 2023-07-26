using System;
using AudioPlayer.WPF.Stores;
using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF.Services;

public class NavigationService<TViewModel> : INavigationService<TViewModel>
    where TViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;
    private readonly Func<TViewModel> _createViewModel;

    public NavigationService(NavigationStore navigationStore, Func<TViewModel> createViewModel)
    {
        _navigationStore = navigationStore;
        _createViewModel = createViewModel;
    }

    public void Navigate()
    {
        _navigationStore.CurrentViewModel = _createViewModel();
    }
}