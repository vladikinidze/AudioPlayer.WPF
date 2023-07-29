using System;
using System.Windows;
using AudioPlayer.WPF.Services;
using AudioPlayer.WPF.Stores;
using AudioPlayer.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AudioPlayer.WPF;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private readonly IServiceProvider _serviceProvider;

    public App()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddSingleton<NavigationStore>();
        services.AddSingleton<ModalNavigationStore>();

        services.AddSingleton(CreateHomeNavigationService);

        services.AddTransient<HomeViewModel>(serviceProvider =>
            new HomeViewModel(CreateAccountNavigationService(serviceProvider)));
        services.AddTransient<AccountViewModel>(serviceProvider =>
            new AccountViewModel(CreateHomeNavigationService(serviceProvider)));
        services.AddTransient<LibraryViewModel>(serviceProvider =>
            new LibraryViewModel());
        services.AddTransient<SearchViewModel>(serviceProvider =>
            new SearchViewModel());
        services.AddSingleton(CreateSidebarViewModel);
        
        services.AddSingleton<MainViewModel>();
        services.AddSingleton<MainWindow>(serviceProvider => new MainWindow
        {
            DataContext = serviceProvider.GetRequiredService<MainViewModel>(),
        });
        _serviceProvider = services.BuildServiceProvider();
    }

    private SidebarViewModel CreateSidebarViewModel(IServiceProvider serviceProvider)
    {
        return new SidebarViewModel(
            CreateHomeNavigationService(serviceProvider),
            CreateSearchNavigationService(serviceProvider),
            CreateLibraryNavigationService(serviceProvider));
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        var initialNavigationService = _serviceProvider.GetRequiredService<INavigationService>();
        initialNavigationService.Navigate();
        
        MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
        MainWindow.Show();
        
        base.OnStartup(e);
    }

    private INavigationService CreateLibraryNavigationService(IServiceProvider serviceProvider)
    {
        return new LayoutNavigationService<LibraryViewModel>(
            serviceProvider.GetRequiredService<NavigationStore>(),
            serviceProvider.GetRequiredService<SidebarViewModel>,
            serviceProvider.GetRequiredService<LibraryViewModel>);
    }

    private INavigationService CreateAccountNavigationService(IServiceProvider serviceProvider)
    {
        return new LayoutNavigationService<AccountViewModel>(
            serviceProvider.GetRequiredService<NavigationStore>(),
            serviceProvider.GetRequiredService<SidebarViewModel>,
            serviceProvider.GetRequiredService<AccountViewModel>);
    }

    private INavigationService CreateSearchNavigationService(IServiceProvider serviceProvider)
    {
        return new LayoutNavigationService<SearchViewModel>(
            serviceProvider.GetRequiredService<NavigationStore>(),
            serviceProvider.GetRequiredService<SidebarViewModel>,
            serviceProvider.GetRequiredService<SearchViewModel>);
    }

    private INavigationService CreateHomeNavigationService(IServiceProvider serviceProvider)
    {
        return new LayoutNavigationService<HomeViewModel>(
            serviceProvider.GetRequiredService<NavigationStore>(),
            serviceProvider.GetRequiredService<SidebarViewModel>,
            serviceProvider.GetRequiredService<HomeViewModel>);
    }
}