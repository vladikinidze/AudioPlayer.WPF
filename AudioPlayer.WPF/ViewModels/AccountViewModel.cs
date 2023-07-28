using System.Windows.Input;
using AudioPlayer.WPF.Command;
using AudioPlayer.WPF.Services;

namespace AudioPlayer.WPF.ViewModels;

public class AccountViewModel : BaseViewModel
{
    public AccountViewModel(INavigationService homeNavigationService)
    {
        NavigateHomeCommand = new NavigateCommand(homeNavigationService);
    }

    public ICommand NavigateHomeCommand { get; }
}