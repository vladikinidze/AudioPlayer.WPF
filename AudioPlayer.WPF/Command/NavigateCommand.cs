using System;
using AudioPlayer.WPF.Services;
using AudioPlayer.WPF.Stores;
using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF.Command;

public class NavigateCommand<TViewModel> : BaseCommand  
    where TViewModel : BaseViewModel 
{
    private readonly NavigationService<TViewModel> _navigationService;

    public NavigateCommand(NavigationService<TViewModel> navigationService)
    {
        _navigationService = navigationService;
    }
    
    public override void Execute(object? parameter)
    {
       _navigationService.Navigate();
    }
}