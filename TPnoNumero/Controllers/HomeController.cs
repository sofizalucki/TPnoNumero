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
    public IActionResult LogIn(string nombre, string answer){
        if(BD.searchIntegrante(nombre, answer) != null){
            return View("Profile");
        }
        else{
            return View("Index");
        }
        
    }
    public IActionResult aLogIn(){
           return View("LogIn");
    }
    public IActionResult aNewIntegrante(){
           return View("newIntegrante");
    }
        
    [HttpPost]
    public IActionResult createNew(string nombreUser, string password, string nombre, string surnombre, int DNI, string direccion, string barrio){
        Integrante nuevoIntegrante = new Integrante(nombreUser, password, nombre, surnombre, DNI, direccion, barrio);
        BD.addIntegrante(nuevoIntegrante);
        return View("Index");
    }
}
    