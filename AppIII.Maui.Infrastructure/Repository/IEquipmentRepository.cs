using AppIII.Maui.Infrastructure.Model;

namespace AppIII.Maui.Infrastructure.Repository;

public interface IEquipmentRepository
{
    public Task<List<Equipment>?> GetAllEquipmentAsync();
    public Task<Equipment?> GetEquipmentByIdAsync(int id);
    public Task<bool> AddEquipmentAsync(Equipment equipment);
    public Task<bool> UpdateEquipmentAsync(int id, Equipment equipment);
    public Task<bool> DeleteEquipmentAsync(int id);
}