using System;
using System.Windows.Input;
using AudioPlayer.WPF.Command;
using AudioPlayer.WPF.Services;
using AudioPlayer.WPF.Stores;

namespace AudioPlayer.WPF.ViewModels;

public class AccountViewModel : BaseViewModel
{
    public AccountViewModel(NavigationStore navigationStore)
    {
        NavigateHomeCommand = new NavigateCommand<HomeViewModel>(
            new NavigationService<HomeViewModel>(
                navigationStore, 
                () => new HomeViewModel(navigationStore)));
    }
    
    public ICommand NavigateHomeCommand { get; }
}