using AppIII.Maui.Infrastructure.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppIII.Maui.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty] private string? _username;

    private readonly IUserService _userService;
    
    public MainPageViewModel(IUserService userService)
    {
        _userService = userService;
    }

    [RelayCommand]
    private void OnLoaded()
    {
        Username = _userService.User.Username;
    }
}