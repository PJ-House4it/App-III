using AppIII.Maui.ViewModel;

namespace AppIII.Maui.View;

public partial class EquipmentPage : ContentPage
{
    public EquipmentPage(EquipmentPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}