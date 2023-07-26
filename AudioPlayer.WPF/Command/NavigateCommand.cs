using AudioPlayer.WPF.Services;
using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF.Command;

public class NavigateCommand<TViewModel> : BaseCommand
    where TViewModel : BaseViewModel
{
    private readonly INavigationService<TViewModel> _navigationService;

    public NavigateCommand(INavigationService<TViewModel> navigationService)
    {
        _navigationService = navigationService;
    }

    public override void Execute(object? parameter)
    {
        _navigationService.Navigate();
    }
}