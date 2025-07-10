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
    [httpPost]
    public IActionResult LogIn(string name, string answer){
        if(BD.LogInModel(name, answer)){
            return View("Profile");
        }
        else{
            return View("Index");
        }
        
    }
    [httpPost]
    public IActionResult createNew(string nombreUser, string password, string name, string surname, int DNI, string direccion, string barrio){
        Integrante nuevoIntegrante = Integrante.newIntegrante(nombreUser, password, name, surname, DNI, direccion, barrio);
        BD.addIntegrante(nuevoIntegrante);
        return View("Index");
    }
    
}