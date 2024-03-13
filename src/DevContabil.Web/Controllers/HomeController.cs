using Microsoft.AspNetCore.Mvc;
using DevContabil.Interfaces;

namespace DevContabil.Web.Controllers;
public class HomeController : Controller
{
    IApiService _apiService;

    public HomeController(IApiService apiService)
    {
        _apiService = apiService;
    }


    public async Task<string> Index()
    {
        return await _apiService.GetAsync();
    }
}