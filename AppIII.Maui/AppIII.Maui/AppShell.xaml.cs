using AppIII.Maui.View;
using AppIII.Maui.ViewModel;

namespace AppIII.Maui;

public partial class AppShell : Shell
{
    public AppShell(AppShellViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        
        Routing.RegisterRoute("MainPage", typeof(MainPage));
        Routing.RegisterRoute("LoginPage", typeof(LoginPage));
    }
}