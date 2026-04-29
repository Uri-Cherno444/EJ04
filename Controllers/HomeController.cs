using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EJ04.Models;

namespace EJ04.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public ActionResult Datos(string nombre, int edad, int dni)
    {
        ViewBag.nombre = nombre;
        ViewBag.edad = edad;
        ViewBag.dni = dni;
    }

    public ActionResult Trabajo(int trabajo, int tipoTrabajo)
    {
        ViewBag.trabajo = trabajo;
        ViewBag.tipoTrabajo = tipoTrabajo;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
