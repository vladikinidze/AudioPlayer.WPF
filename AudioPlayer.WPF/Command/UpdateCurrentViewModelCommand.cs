using AudioPlayer.WPF.State;
using AudioPlayer.WPF.ViewModels.Factories;

namespace AudioPlayer.WPF.Command;

public class UpdateCurrentViewModelCommand : BaseCommand
{
    private readonly INavigator _navigator;
    private readonly IViewModelFactory _viewModelFactory;

    public UpdateCurrentViewModelCommand(INavigator navigator, IViewModelFactory viewModelFactory)
    {
        _navigator = navigator;
        _viewModelFactory = viewModelFactory;
    }
    
    public override void Execute(object? parameter)
    {
        if(parameter is ViewType viewType)
        {
            _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);
        }
    }
}