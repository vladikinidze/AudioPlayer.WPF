using System;
using AudioPlayer.WPF.Stores;
using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF.Services;

public class LayoutNavigationService<TViewModel> : INavigationService<TViewModel>
    where TViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;
    private readonly Func<TViewModel> _createViewModel;
    private readonly Func<SidebarViewModel> _createSidebarViewModel;

    public LayoutNavigationService(NavigationStore navigationStore,
        Func<SidebarViewModel> createSidebarViewModel,
        Func<TViewModel> createViewModel)
    {
        _navigationStore = navigationStore;
        _createSidebarViewModel = createSidebarViewModel;
        _createViewModel = createViewModel;
    }

    public void Navigate()
    {
        _navigationStore.CurrentViewModel = new LayoutViewModel(_createSidebarViewModel(), _createViewModel());
    }
}