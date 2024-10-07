using System.ComponentModel;

namespace AppIII.Maui.Infrastructure.Services;

public interface ILoginService : INotifyPropertyChanged {
    public bool IsLoggedIn { get; }
    public bool Login(string username, string password);
    public void Logout();
}