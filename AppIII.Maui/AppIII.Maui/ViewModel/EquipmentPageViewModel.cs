using System.Collections.ObjectModel;
using AppIII.Maui.Infrastructure.Model;
using AppIII.Maui.Infrastructure.Repository;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppIII.Maui.ViewModel;

public partial class EquipmentPageViewModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<Equipment> _equipments = [];

    private readonly IEquipmentRepository _equipmentRepository;
    
    public EquipmentPageViewModel(IEquipmentRepository equipmentRepository)
    {
        _equipmentRepository = equipmentRepository;
    }

    [RelayCommand]
    private async Task OnLoaded()
    {
        List<Equipment>? equipments = await _equipmentRepository.GetAllEquipmentAsync();
        Equipments = new ObservableCollection<Equipment>(equipments ?? []);
    }
}