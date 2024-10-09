using AppIII.Maui.Infrastructure.Model;

namespace AppIII.Maui.Infrastructure.Repository;

public interface IEquipmentRepository
{
    public Task<List<Equipment>?> GetAllEquipmentAsync();
}