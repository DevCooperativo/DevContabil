using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using DevContabil.Services;

namespace DevContabil.Web.Controllers;
public class HomeController : Controller
{


    public async Task<string> Index()
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        var serviceProvider = serviceCollection.BuildServiceProvider();
        Console.WriteLine("Running");
        var ApiService = serviceProvider.GetService<ApiService>();

        
        return await ApiService.GetAsync();
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<ApiService>();
    }

}