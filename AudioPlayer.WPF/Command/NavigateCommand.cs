using AudioPlayer.WPF.Services;
using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF.Command;

public class NavigateCommand : BaseCommand
{
    private readonly INavigationService _navigationService;

    public NavigateCommand(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    public override void Execute(object? parameter)
    {
        _navigationService.Navigate();
    }
}