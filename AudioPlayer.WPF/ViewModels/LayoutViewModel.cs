namespace AudioPlayer.WPF.ViewModels;

public class LayoutViewModel : BaseViewModel
{
    public LayoutViewModel(SidebarViewModel sidebarViewModel, BaseViewModel contentViewModel)
    {
        SidebarViewModel = sidebarViewModel;
        ContentViewModel = contentViewModel;
    }

    public SidebarViewModel SidebarViewModel { get; }
    public BaseViewModel ContentViewModel { get; }

    public override void Dispose()
    {
        SidebarViewModel?.Dispose();
        ContentViewModel?.Dispose();
        base.Dispose();
    }
}