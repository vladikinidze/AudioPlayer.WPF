using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF.Services;

public interface INavigationService<TViewModel>
    where TViewModel : BaseViewModel
{
    void Navigate();
}