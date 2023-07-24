using System.Windows.Input;
using AudioPlayer.WPF.Command;
using AudioPlayer.WPF.Services;
using AudioPlayer.WPF.Stores;

namespace AudioPlayer.WPF.ViewModels;
    
public class HomeViewModel : BaseViewModel
{
    public HomeViewModel(NavigationStore navigationStore)
    {
        NavigateAccountCommand = new NavigateCommand<AccountViewModel>(
            new NavigationService<AccountViewModel>(
                navigationStore,
                () => new AccountViewModel(navigationStore)));
    }
    public ICommand NavigateAccountCommand { get; }
}