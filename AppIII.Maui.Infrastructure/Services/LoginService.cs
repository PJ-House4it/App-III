using System.ComponentModel;
using AppIII.Maui.Infrastructure.Model;

namespace AppIII.Maui.Infrastructure.Services;

public sealed class LoginService : ILoginService
{
    private readonly IUserService _userService;
    
    private bool _isLoggedIn;
    public bool IsLoggedIn
    {
        get => _isLoggedIn;
        private set
        {
            if (_isLoggedIn == value) return;
            _isLoggedIn = value;
            OnPropertyChanged(nameof(IsLoggedIn));
        }
    }

    public LoginService(IUserService userService)
    {
        _userService = userService;
    }

    public bool Login(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            return false;
        
        IsLoggedIn = true;
        _userService.User = new User
        {
            Id = 0,
            Username = username,
            Permission = UserPermission.Admin
        };

        return true;
    }
    
    public void Logout()
    {
        IsLoggedIn = false;
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}