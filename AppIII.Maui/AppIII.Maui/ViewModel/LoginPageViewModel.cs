using AppIII.Maui.Infrastructure.Services;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Font = Microsoft.Maui.Font;

namespace AppIII.Maui.ViewModel;

public partial class LoginPageViewModel : ObservableObject
{
    [ObservableProperty] private string _username;
    [ObservableProperty] private string _password;

    private readonly ILoginService _loginService;

    public LoginPageViewModel(ILoginService loginService)
    {
        _loginService = loginService;
    }

    [RelayCommand]
    private async Task Login()
    {
        bool loggedIn = _loginService.Login(Username, Password);
        if (!loggedIn)
        {
            CancellationTokenSource cancellationTokenSource = new();

            SnackbarOptions snackbarOptions = new()
            {
                BackgroundColor = Color.FromArgb("#2196F3"),
                TextColor = Color.FromArgb("#212121"),
                ActionButtonTextColor = Color.FromArgb("#212121"),
                CornerRadius = new CornerRadius(10),
                Font = Font.SystemFontOfSize(14),
                ActionButtonFont = Font.SystemFontOfSize(14)
            };

            ISnackbar snackbar = Snackbar.Make("Du skal indtaste både et brugernavn og password",
                visualOptions: snackbarOptions);
            await snackbar.Show(cancellationTokenSource.Token);
            return;
        }

        Username = string.Empty;
        Password = string.Empty;

        await Shell.Current.GoToAsync("//MainPage");
    }
}