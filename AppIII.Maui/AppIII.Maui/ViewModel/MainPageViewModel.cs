using CommunityToolkit.Mvvm.ComponentModel;

namespace AppIII.Maui.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty] private string? _test;
}