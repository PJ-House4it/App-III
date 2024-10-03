using AppIII.Maui.Infrastructure.Repository;
using AppIII.Maui.Infrastructure.Services;
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
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // IServices \\
        builder.Services.AddSingleton<ILoginService, LoginService>();
        builder.Services.AddSingleton<IApiService, ApiService>();
        
        // Http Client \\
        builder.Services.AddSingleton(new HttpClient
        {
            BaseAddress = new Uri("https://10.130.56.41:5432/")
        });

        // Repositories \\
        builder.Services.AddSingleton<IEquipmentRepository, EquipmentRepository>();
        
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