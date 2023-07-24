using System.Windows.Input;
using AudioPlayer.WPF.Command;
using AudioPlayer.WPF.Stores;

namespace AudioPlayer.WPF.ViewModels;

public class AccountViewModel : BaseViewModel
{
    public AccountViewModel(NavigationStore navigationStore)
    {
        NavigateHomeCommand = new NavigateHomeCommand(navigationStore);
    }
    
    public ICommand NavigateHomeCommand { get; }
}