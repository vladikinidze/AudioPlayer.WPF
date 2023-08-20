using System;
using System.Windows;
using AudioPlayer.Infrastructure;
using AudioPlayer.WPF.Services;
using AudioPlayer.WPF.Stores;
using AudioPlayer.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AudioPlayer.WPF;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private readonly IServiceProvider _serviceProvider;

    private readonly IHost _host;

    public App()
    {
        _host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbConnection(context.Configuration);
                services.AddSingleton<NavigationStore>();
                services.AddSingleton<ModalNavigationStore>();
                services.AddSingleton<NavigationStore>();

                services.AddTransient<SidebarViewModel>();
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
                
            })
            .Build();
        _serviceProvider = _host.Services;
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
        _host.Start();
        var initialNavigationService = _serviceProvider.GetRequiredService<INavigationService>();
        initialNavigationService.Navigate();
        
        MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
        MainWindow.Show();
        
        base.OnStartup(e);
    }

    protected override void OnExit(ExitEventArgs e)
    {
        _host.StopAsync();
        _host.Dispose();
        base.OnExit(e);
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

    private INavigationService CreatePlaylistNavigationService(IServiceProvider serviceProvider)
    {
        return new LayoutNavigationService<PlaylistViewModel>(
            serviceProvider.GetRequiredService<NavigationStore>(),
            serviceProvider.GetRequiredService<SidebarViewModel>,
            serviceProvider.GetRequiredService<PlaylistViewModel>);
    }
}