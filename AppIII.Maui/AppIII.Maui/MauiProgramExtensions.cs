using AppIII.Maui.Infrastructure;
using AppIII.Maui.View;
using AppIII.Maui.ViewModel;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ZXing.Net.Maui.Controls;

namespace AppIII.Maui;

public static class MauiProgramExtensions
{
    public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
    {
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseBarcodeReader()
            .AddInfrastructure()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        
        // Pages & ViewModel \\
        builder.Services.AddSingleton<AppShellViewModel>();
        builder.Services.AddSingleton<AppShell>();   
        
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<LoginPage>();
        
        builder.Services.AddSingleton<EquipmentPageViewModel>();
        builder.Services.AddSingleton<EquipmentPage>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder;
    }
}