using Microsoft.AspNetCore.Mvc;
using DevContabil.Interfaces;

namespace DevContabil.Web.Controllers;
public class HomeController(ISicoobApiService sicoobApiService, INFApiService nfApiService) : Controller
{
    ISicoobApiService _sicoobApiService = sicoobApiService;
    INFApiService _nfApiService = nfApiService;

    public async Task<string> Index()
    {
        return await _nfApiService.GetAllEmpresaAsync();
    }


}