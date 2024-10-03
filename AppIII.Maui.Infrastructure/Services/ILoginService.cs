using System.ComponentModel;

namespace AppIII.Maui.Infrastructure.Services;

public interface ILoginService : INotifyPropertyChanged {
    public bool IsLoggedIn { get; }
    public void Login();
    public void Logout();
}