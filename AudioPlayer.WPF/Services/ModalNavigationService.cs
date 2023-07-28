using System;
using AudioPlayer.WPF.Stores;
using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF.Services;

public class ModalNavigationService<TViewModel> : INavigationService
    where TViewModel : BaseViewModel
{
    private readonly ModalNavigationStore _modalNavigationStore;
    private readonly Func<TViewModel> _createViewModel;

    public ModalNavigationService(ModalNavigationStore modalNavigationStore, Func<TViewModel> createViewModel)
    {
        _modalNavigationStore = modalNavigationStore;
        _createViewModel = createViewModel;
    }

    public void Navigate()
    {
        _modalNavigationStore.CurrentViewModel = _createViewModel();
    }
}