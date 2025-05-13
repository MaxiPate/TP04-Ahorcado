using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Patejim_Feldman.Models;

namespace TP04_Patejim_Feldman.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Ahorcado.inicializarGrupo();
        ViewBag.palabra = Ahorcado.palabra;
        ViewBag.cantIntentos = Ahorcado.cantIntentos;
        ViewBag.letrasUsadas = Ahorcado.letrasUsadas;
        return View();
    }

    public IActionResult jugar(){
        return View("Ahorcado");
    }


}
