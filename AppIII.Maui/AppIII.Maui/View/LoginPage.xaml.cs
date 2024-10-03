using AppIII.Maui.ViewModel;

namespace AppIII.Maui.View;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}