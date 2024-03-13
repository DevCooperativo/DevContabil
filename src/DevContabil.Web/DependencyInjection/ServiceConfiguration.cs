using DevContabil.Services;
using DevContabil.Interfaces;

namespace DevContabil.Web.DependencyInjection;

public static class ServiceConfiguration
{
    public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient<IApiService, ApiService>();
    }
}