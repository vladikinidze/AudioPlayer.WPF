using AudioPlayer.WPF.Stores;

namespace AudioPlayer.WPF.Services;

public class CloseModalNavigationService : INavigationService
{
    private readonly ModalNavigationStore _modalNavigationStore;

    public CloseModalNavigationService(ModalNavigationStore modalNavigationStore)
    {
        _modalNavigationStore = modalNavigationStore;
    }

    public void Navigate()
    {
        _modalNavigationStore.Close();
    }
}