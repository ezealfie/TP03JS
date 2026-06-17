using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03_ALFIE_FAINSCHTEIN.Models;

namespace TP03_ALFIE_FAINSCHTEIN.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        PalabrasAhorcado palabras = new PalabrasAhorcado();
        string palabra = palabras.ObtenerPalabra();
        ViewBag.palabra = palabra;
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult GuardarPalabra(string palabra)
    {
        PalabrasAhorcado palabras = new PalabrasAhorcado();
        bool estado = palabras.AgregarPalabra(palabra.ToUpper());
        ViewBag.estado = estado == true ? "Palabra Agregada" :  "Esta en la BASE";
        return View("Privacy");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
