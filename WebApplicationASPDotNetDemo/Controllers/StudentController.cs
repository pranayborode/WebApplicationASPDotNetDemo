using Microsoft.AspNetCore.Mvc;
using WebApplicationASPDotNetDemo.Models;

namespace WebApplicationASPDotNetDemo.Controllers
{
	public class StudentController : Controller
	{
		public IActionResult AddStudent()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddStudent(Student student)
		{
			return View();
		}
	}
}
