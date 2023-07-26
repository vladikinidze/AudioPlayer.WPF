using System.Windows;
using AudioPlayer.WPF.Services;
using AudioPlayer.WPF.Stores;
using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private readonly NavigationStore _navigationStore;

    public App()
    {
        _navigationStore = new NavigationStore();
        CreateSidebarViewModel();
    }

    private SidebarViewModel CreateSidebarViewModel()
    {
        return new SidebarViewModel(
            CreateHomeNavigationService(),
            CreateSearchNavigationService(),
            CreateLibraryNavigationService());
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        var homeNavigationService = CreateHomeNavigationService();
        homeNavigationService.Navigate();
        MainWindow = new MainWindow
        {
            DataContext = new MainViewModel(_navigationStore),
        };
        MainWindow.Show();
        base.OnStartup(e);
    }

    private INavigationService<LibraryViewModel> CreateLibraryNavigationService()
    {
        return new LayoutNavigationService<LibraryViewModel>(
            _navigationStore,
            CreateSidebarViewModel,
            () => new LibraryViewModel());
    }

    private INavigationService<AccountViewModel> CreateAccountNavigationService()
    {
        return new LayoutNavigationService<AccountViewModel>(
            _navigationStore,
            CreateSidebarViewModel,
            () => new AccountViewModel(CreateHomeNavigationService()));
    }

    private INavigationService<SearchViewModel> CreateSearchNavigationService()
    {
        return new LayoutNavigationService<SearchViewModel>(
            _navigationStore,
            CreateSidebarViewModel,
            () => new SearchViewModel());
    }

    private INavigationService<HomeViewModel> CreateHomeNavigationService()
    {
        return new LayoutNavigationService<HomeViewModel>(
            _navigationStore,
            CreateSidebarViewModel,
            () => new HomeViewModel(CreateAccountNavigationService()));
    }
}