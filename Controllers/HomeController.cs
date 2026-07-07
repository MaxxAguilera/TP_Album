using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_Album_Aguilera_Perez_Tortosa.Models;

namespace TP_Album_Aguilera_Perez_Tortosa.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Sobre()
    {
        return View();
    }
    
    public IActionResult Album()
    {
        List<Seleccion> selecciones = BD.ObtenerSelecciones();
        List<Jugador> jugadores = BD.ObtenerJugadores();
        List<Figurita> figuritas = BD.ObtenerFiguritas();
        
        ViewBag.selecciones = selecciones;
        ViewBag.jugadores = jugadores;
        ViewBag.figuritas = figuritas;
        return View();
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
