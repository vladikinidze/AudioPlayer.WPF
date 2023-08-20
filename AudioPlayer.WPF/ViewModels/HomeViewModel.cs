using System.Windows.Input;
using AudioPlayer.WPF.Command;
using AudioPlayer.WPF.Services;

namespace AudioPlayer.WPF.ViewModels;

public class HomeViewModel : BaseViewModel
{
    public HomeViewModel(INavigationService accountNavigationService)
    {
        NavigateAccountCommand = new NavigateCommand(accountNavigationService);
    }

    public ICommand NavigateAccountCommand { get; }
    public ICommand NavigatePlaylistCommand { get; }
}