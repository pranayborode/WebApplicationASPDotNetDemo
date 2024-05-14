using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationASPDotNetDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeForm()
        {
            List<string> city = new List<string>()
            {
                "Pune","Mumbai","Amravati","Nagpur"
            };

            ViewData["city"] = new SelectList(city);

            List<string> department = new List<string>()
            {
                "Developer","QA","HR","Sales", "Finance", "Management"
            };
            ViewData["department"] = new SelectList(department);

            List<string> qualification = new List<string>()
            {
                "BE","ME","B.Sc","M.Sc","MBA"
            };
            ViewData["qualification"] =new MultiSelectList(qualification);

            return View();
        }
        [HttpPost]
        public IActionResult EmployeeForm(IFormCollection form)
        {
            ViewBag.Name = form["empname"];
            ViewBag.Email = form["email"];
            ViewBag.Gender = form["gender"];
            ViewBag.City = form["city"];
            ViewBag.Department = form["department"];
			ViewBag.Qualification = form["qualification"];

			return View("EmployeeDetails");
        }
    }
}
