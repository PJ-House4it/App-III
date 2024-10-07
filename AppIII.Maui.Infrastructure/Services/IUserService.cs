using AppIII.Maui.Infrastructure.Model;

namespace AppIII.Maui.Infrastructure.Services;

public interface IUserService
{
    public User User { get; }
    public void SetUser(string username);
}