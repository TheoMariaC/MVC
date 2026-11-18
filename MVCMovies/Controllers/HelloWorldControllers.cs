using Microsoft.AspNetCore.Mvc;
namespace MVCMovies.Controllers;
public class HelloWorldController:Controller
{
    public IActionResult Index(){
        return View();
    }

    public IActionResult Welcome(){
        return View();
    }
    
}