using AppIII.Maui.Infrastructure.Model;

namespace AppIII.Maui.Infrastructure.Services;

public class UserService : IUserService
{
    public User User { get; private set; }
    
    public void SetUser(string username)
    {
        User = new User(username);
    }
}