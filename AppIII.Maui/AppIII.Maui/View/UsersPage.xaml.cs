namespace AppIII.Maui.View;

public partial class UsersPage : ContentPage
{
    public UsersPage(UsersPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}