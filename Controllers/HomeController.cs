using csharp_blog_frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace csharp_blog_frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            ViewData["id"] = id;

            return View();
        }

        

        [HttpGet]
        public IActionResult DetailBlob(int id)
        {
            ViewData["id"] = id;

            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateFile()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View();
        }

        public IActionResult Privacy()
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