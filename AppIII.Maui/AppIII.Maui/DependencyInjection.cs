using AppIII.Maui.View;
using AppIII.Maui.ViewModel;

namespace AppIII.Maui;

public static class DependencyInjection
{
    public static MauiAppBuilder AddViewModelsAndPages(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<AppShellViewModel>();
        builder.Services.AddSingleton<AppShell>();   
        
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<LoginPage>();
        
        builder.Services.AddSingleton<EquipmentPageViewModel>();
        builder.Services.AddSingleton<EquipmentPage>();
        return builder;
    }
}