using Microsoft.AspNetCore.Mvc;
namespace MVCMovies.Controllers;
public class HelloWorldController:Controller
{
    public string Index() {
        return "This is my default action...";
    }
    public string Welcome(){
        return "This is the Welcome action method...";
    }
}