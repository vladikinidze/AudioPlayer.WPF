using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AudioPlayer.WPF.Stores;
using AudioPlayer.WPF.ViewModels;
using AudioPlayer.WPF.Views;

namespace AudioPlayer.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var navigationStore = new NavigationStore();
            navigationStore.CurrentViewModel = new AccountViewModel(navigationStore);
            MainWindow = new MainWindow
            {
                DataContext = new MainViewModel(navigationStore),
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}