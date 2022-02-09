using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ImageResizeWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tech()
        {
            return View();
        }

        public IActionResult Books()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
