using AppIII.Maui.Infrastructure.Model;

namespace AppIII.Maui.Infrastructure.Repository;

public interface IUserRepository
{
    public Task<List<User>?> GetAllUsersAsync();
}