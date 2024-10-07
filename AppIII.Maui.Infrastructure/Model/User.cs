namespace AppIII.Maui.Infrastructure.Model;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public UserPermission Permission { get; set; }
}