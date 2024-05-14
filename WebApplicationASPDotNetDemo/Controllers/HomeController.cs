using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationASPDotNetDemo.Models;

namespace WebApplicationASPDotNetDemo.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewData["message"] = "Welcome to Adp.Net core using mvc";

            List<string> cities = new List<string>()
            {
                "Pune", "Mumbai", "Amravati", "Nagpur", "Delhi"
            };

            ViewData["cities"] = cities;

            List<string> product = new List<string>()
            {
              "Laptop","TV", "Mobile", "Car"
            };

            ViewData["product"]= product;

            ViewBag.Message = "This is an Example of ViewBag";
            ViewBag.Cities = cities;

            TempData["company"] = "ThinkQuotient";
            TempData.Keep("company"); //allow to hold data with multiple request

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            string name = TempData["company"].ToString();
            return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
