using System.Windows.Input;
using AudioPlayer.WPF.Command;
using AudioPlayer.WPF.Services;

namespace AudioPlayer.WPF.ViewModels;

public class HomeViewModel : BaseViewModel
{
    public HomeViewModel(INavigationService<AccountViewModel> accountNavigationService)
    {
        NavigateAccountCommand = new NavigateCommand<AccountViewModel>(accountNavigationService);
    }

    public ICommand NavigateAccountCommand { get; }
}