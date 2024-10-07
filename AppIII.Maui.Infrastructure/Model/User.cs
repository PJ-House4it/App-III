namespace AppIII.Maui.Infrastructure.Model;

public class User(string username)
{
    public string Username { get; private set; } = username;
    public UserPermission Permission { get; private set; } = UserPermission.Admin;
}