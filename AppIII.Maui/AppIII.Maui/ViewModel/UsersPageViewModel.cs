using System.Collections.ObjectModel;
using AppIII.Maui.Infrastructure.Model;
using AppIII.Maui.Infrastructure.Repository;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class UsersPageViewModel : ObservableObject
{
    [ObservableProperty] private IEnumerable<UserPermission> _userPermissions = Enum.GetValues<UserPermission>();

    [ObservableProperty] private ObservableCollection<User> _users;

    private readonly IUserRepository _userRepository;
    
    public UsersPageViewModel(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [RelayCommand]
    private void OnPermissionIndexChanged(User user)
    {
        // TODO: Update User Permission via IUserRepository
    }

    [RelayCommand]
    private async Task OnLoaded()
    {
        Users = new ObservableCollection<User>(await _userRepository.GetAllUsersAsync() ?? []);
    }
}