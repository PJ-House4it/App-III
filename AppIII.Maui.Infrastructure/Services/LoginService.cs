using System.ComponentModel;

namespace AppIII.Maui.Infrastructure.Services;

public sealed class LoginService : ILoginService
{
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

    public void Login()
    {
        IsLoggedIn = true;
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