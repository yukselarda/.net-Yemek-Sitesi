using _4513_ArdaYuksel_Proje.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _4513_ArdaYuksel_Proje.Controllers
{
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Kullanim()
        {
            return View();
        }
        public IActionResult giris()
        {
            return View();
        }
        public IActionResult kaydol()
        {
            return View();
        }

        public IActionResult ham1()
        {
            return View();
        }

        public IActionResult ham2()
        {
            return View();
        }

        public IActionResult ham3()
        {
            return View();
        }

        public IActionResult ham4()
        {
            return View();
        }

        public IActionResult ham5()
        {
            return View();
        }

        public IActionResult ham6()
        {
            return View();
        }

        public IActionResult ham7()
        {
            return View();
        }

        public IActionResult ham8()
        {
            return View();
        }

        public IActionResult ham9()
        {
            return View();
        }

        public IActionResult ham10()
        {
            return View();
        }

        public IActionResult ham11()
        {
            return View();
        }

        public IActionResult ham12()
        {
            return View();
        }
        public IActionResult sepet()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}