using System;
using System.Windows.Input;
using AudioPlayer.WPF.Command;
using AudioPlayer.WPF.Services;
using AudioPlayer.WPF.Stores;

namespace AudioPlayer.WPF.ViewModels;

public class AccountViewModel : BaseViewModel
{
    public AccountViewModel(INavigationService<HomeViewModel> homeNavigationService)
    {
        NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);
    }

    public ICommand NavigateHomeCommand { get; }
}