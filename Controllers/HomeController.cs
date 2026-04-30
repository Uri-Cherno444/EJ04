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

    [HttpPost]
    public ActionResult Datos(int edad, string trabajo, int ingreso, int monto, string deudas, bool terminos)
    {
        int montoPermitido = ingreso * 5;
        if(edad >= 18 && trabajo != "No" && ingreso >= 250000 && monto <= montoPermitido && deudas == "No" && terminos == true)
        {   
            return View("Permitido");
        }
        else
        {
            return View("NoPermitido");            
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
