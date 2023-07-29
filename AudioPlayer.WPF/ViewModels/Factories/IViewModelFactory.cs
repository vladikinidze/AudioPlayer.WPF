using AudioPlayer.WPF.State;

namespace AudioPlayer.WPF.ViewModels.Factories;

public interface IViewModelFactory
{
    BaseViewModel CreateViewModel(ViewType viewType);
}