using System.Windows.Input;
using AudioPlayer.WPF.Command;
using AudioPlayer.WPF.Services;

namespace AudioPlayer.WPF.ViewModels;

public class SidebarViewModel : BaseViewModel
{
    public SidebarViewModel(INavigationService<HomeViewModel> homeNavigationService,
        INavigationService<SearchViewModel> searchNavigationService,
        INavigationService<LibraryViewModel> libraryNavigationService)
    {
        NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);
        NavigateSearchCommand = new NavigateCommand<SearchViewModel>(searchNavigationService);
        NavigateLibraryCommand = new NavigateCommand<LibraryViewModel>(libraryNavigationService);
    }

    public ICommand NavigateHomeCommand { get; }
    public ICommand NavigateSearchCommand { get; }
    public ICommand NavigateLibraryCommand { get; }
    public ICommand CreatePlaylistCommand { get; }
}