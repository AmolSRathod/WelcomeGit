using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WelcomeGit.Models;

namespace WelcomeGit.Controllers
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

        public IActionResult Amol()
        {
            return View();
        }

        public IActionResult Pushkar()
        {
            return View();
        }

        public IActionResult Rathod()
        {
            return View();
        }

        public IActionResult Sanjay()
        {
            return View();
        }

        public IActionResult Sachin()
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
