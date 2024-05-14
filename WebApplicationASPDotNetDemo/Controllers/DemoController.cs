using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationASPDotNetDemo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Page1()
        {

            List<string> cities = new List<string>()
            {
                "Pune", "Mumbai", "Amravati", "Nagpur", "Delhi"
            };

            ViewData["cities"] = new SelectList(cities);


            ViewData["city"] = new MultiSelectList(cities);
            return View();
        }
    }
}
