using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApiService<Employee> _apiService;
        private readonly ApiService<Departament> _apiServiceDepartament;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;

        // Инициализируем сервис API (замени URL на свой API)
        _apiService = new ApiService<Employee>("http://localhost:5000/api/Employee");
        _apiServiceDepartament = new ApiService<Departament>("http://localhost:5000/api/Departament");
    }

    public async Task<IActionResult> Index()
    {
        // Получаем данные через API
        var products = await _apiService.GetAsync();

        // Передаём данные в представление
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
