using System.Windows.Input;
using AudioPlayer.WPF.Command;
using AudioPlayer.WPF.Services;

namespace AudioPlayer.WPF.ViewModels;

public class SidebarViewModel : BaseViewModel
{
    public SidebarViewModel(INavigationService homeNavigationService,
        INavigationService searchNavigationService,
        INavigationService libraryNavigationService)
    {
        NavigateHomeCommand = new NavigateCommand(homeNavigationService);
        NavigateSearchCommand = new NavigateCommand(searchNavigationService);
        NavigateLibraryCommand = new NavigateCommand(libraryNavigationService);
    }

    public ICommand NavigateHomeCommand { get; }
    public ICommand NavigateSearchCommand { get; }
    public ICommand NavigateLibraryCommand { get; }
    public ICommand CreatePlaylistCommand { get; }
}