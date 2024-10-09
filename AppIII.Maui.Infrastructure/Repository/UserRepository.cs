using AppIII.Maui.Infrastructure.Model;
using AppIII.Maui.Infrastructure.Services;

namespace AppIII.Maui.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly IApiService _apiService;
    
    public UserRepository(IApiService apiService)
    {
        _apiService = apiService;
    }
    
    public async Task<List<User>?> GetAllUsersAsync()
    {
        try
        {
            return await _apiService.GetAsync<List<User>>("User/GetAll");
        }
        catch (Exception)
        {
            return null;
        }
    }
}