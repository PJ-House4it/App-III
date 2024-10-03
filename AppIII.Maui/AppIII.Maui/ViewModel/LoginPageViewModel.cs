using AppIII.Maui.Infrastructure.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppIII.Maui.ViewModel;

public partial class LoginPageViewModel : ObservableObject
{
    private ILoginService _loginService;
    
    public LoginPageViewModel(ILoginService loginService)
    {
        _loginService = loginService;
    }

    [RelayCommand]
    private async Task Login()
    {
        _loginService.Login();
        await Shell.Current.GoToAsync("//MainPage");
    }
}