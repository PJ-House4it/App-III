using AppIII.Maui.Infrastructure.Repository;
using AppIII.Maui.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;

namespace AppIII.Maui.Infrastructure;

public static class DependencyInjection
{
    public static MauiAppBuilder AddInfrastructure(this MauiAppBuilder builder)
    {
        // IServices \\
        builder.Services.AddSingleton<IUserService, UserService>();
        builder.Services.AddSingleton<ILoginService, LoginService>();
        builder.Services.AddSingleton<IApiService, ApiService>();
        
        // Http Client \\
        builder.Services.AddSingleton(new HttpClient
        {
            BaseAddress = new Uri("http://10.130.56.41/AppIII.API/API/"),
            Timeout = TimeSpan.FromSeconds(15)
        });

        // Repositories \\
        builder.Services.AddSingleton<IEquipmentRepository, EquipmentRepository>();
        builder.Services.AddSingleton<IUserRepository, UserRepository>();
        return builder;
    }
}