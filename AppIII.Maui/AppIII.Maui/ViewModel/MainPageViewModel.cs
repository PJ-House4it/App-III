using AppIII.Maui.Infrastructure.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppIII.Maui.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty] private string? _username;

    private readonly IUserService _userService;
    
    public MainPageViewModel(IUserService userService)
    {
        _userService = userService;

        Username = _userService.User.Username;
    }
}