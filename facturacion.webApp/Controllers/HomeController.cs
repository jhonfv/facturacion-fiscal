using facturacion.application.Interfaces;
using facturacion.webApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace facturacion.webApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClienteService _clienteService;
        public HomeController(ILogger<HomeController> logger, IClienteService clienteService)
        {
            _logger = logger;
            _clienteService = clienteService;
        }

        public async Task<IActionResult> Index()
        {
            var clientes = await _clienteService.getAllAsync();
            return View(clientes);
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
}