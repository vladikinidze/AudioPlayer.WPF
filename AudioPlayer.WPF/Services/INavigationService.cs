namespace AudioPlayer.WPF.Services;

public interface INavigationService
{
    void Navigate();
}

public interface INavigationService<TViewModel>
{
    void Navigate();
}