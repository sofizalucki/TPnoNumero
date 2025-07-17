using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TPnoNumero.Models;

namespace TPnoNumero.Controllers;

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
    public IActionResult LogIn(string nombreUser, string password)
    {
        _logger.LogInformation($"Intento de login: {nombreUser} - {password}");
        Integrante inte = BD.searchIntegrante(nombreUser, password);
        if (inte != null)
        {
            @ViewBag.DNI = inte.DNI;
            @ViewBag.direction = inte.direccion;
            @ViewBag.Neighborhood = inte.barrio;
            @ViewBag.nombreCompleto = inte.nombre + inte.apellido;
            @ViewBag.password = inte.password;
            @ViewBag.nombreUser = inte.nombreUser;
            @ViewBag.nombre = inte.nombre;
            return View("Profile");
        }
        else
        {
            @ViewBag.message = "El usuario o la contraseña son incorrectos";
            return View("Index");
        }
    }
    public IActionResult aLogIn(){
           return View("LogIn");
    }
    public IActionResult aNewIntegrante(){
           return View("newIntegrante");
    }
    public IActionResult aHome(){
        return View ("Index");
    }
}
    