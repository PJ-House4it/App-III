using AppIII.Maui.Infrastructure.Model;
using AppIII.Maui.Infrastructure.Services;

namespace AppIII.Maui.Infrastructure.Repository;

public class EquipmentRepository : IEquipmentRepository
{
    private readonly IApiService _apiService;

    public EquipmentRepository(IApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task<List<Equipment>?> GetAllEquipmentAsync()
    {
        try
        {
            return await _apiService.GetAsync<List<Equipment>>("Equipment/GetAll");
        }
        catch (Exception)
        {
            return null;
        }
    }
}