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
            return await _apiService.GetAsync<List<Equipment>>("equipment");
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task<Equipment?> GetEquipmentByIdAsync(int id)
    {
        try
        {
            return await _apiService.GetAsync<Equipment>($"equipment/{id}");
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task<bool> AddEquipmentAsync(Equipment equipment)
    {
        return await _apiService.PostAsync("equipment", equipment);
    }

    public async Task<bool> UpdateEquipmentAsync(int id, Equipment equipment)
    {
        return await _apiService.PutAsync($"equipment/{id}", equipment);
    }

    public async Task<bool> DeleteEquipmentAsync(int id)
    {
        return await _apiService.DeleteAsync($"equipment/{id}");
    }
}