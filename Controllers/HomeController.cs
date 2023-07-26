//First controller will go here
using VertoTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace VertoTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cms()
        {
            return View();
        }

    }
}
