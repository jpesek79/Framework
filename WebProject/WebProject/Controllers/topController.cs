
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class topController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Greeting(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();

        }
    }
}
