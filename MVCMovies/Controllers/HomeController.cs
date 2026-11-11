using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCMovies.Models;
using System.Text.Encodings.Web;

namespace MVCMovies.Controllers;

public class HomeController : Controller
{
       public string Index() {
        return "This is my default action...";
    }
    public string Welcome(string name,int numTimes=1){
        return HtmlEncoder.Default.Encode(
        $"Hello {name},NumTimes is:{numTimes}");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
public IActionResult Error()
{
return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}

}
