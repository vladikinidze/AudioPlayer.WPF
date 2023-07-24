using AudioPlayer.WPF.Stores;
using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF.Command;

public class NavigateHomeCommand : BaseCommand
{
    private readonly NavigationStore _navigationStore;

    public NavigateHomeCommand(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }

    public override void Execute(object? parameter)
    {
        _navigationStore.CurrentViewModel = new HomeViewModel();
    }
}