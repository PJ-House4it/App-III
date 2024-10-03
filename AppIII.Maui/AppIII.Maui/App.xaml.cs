using AppIII.Maui.ViewModel;

namespace AppIII.Maui;

public sealed partial class App : Application
{
    public App(AppShellViewModel viewModel)
    {
        InitializeComponent();
        
        MainPage = new AppShell(viewModel);
    }
}