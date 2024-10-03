using System.ComponentModel;
using AppIII.Maui.Infrastructure.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppIII.Maui.ViewModel;

public partial class AppShellViewModel : ObservableObject
{
    private readonly ILoginService _loginService;
    
    public AppShellViewModel(ILoginService loginService)
    {
        _loginService = loginService;
        _loginService.PropertyChanged += LoginService_PropertyChanged;
    }
    
    [RelayCommand]
    private async Task Logout()
    {
        _loginService.Logout();
        await Shell.Current.GoToAsync("//LoginPage");

    }
        
    private void LoginService_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(ILoginService.IsLoggedIn))
        {
            OnPropertyChanged(nameof(IsLoggedIn));
        }
    }

    public bool IsLoggedIn => _loginService.IsLoggedIn;
}