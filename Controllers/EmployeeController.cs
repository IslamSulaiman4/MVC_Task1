using Microsoft.AspNetCore.Mvc;
using Task1.Data;
using Task1.Models;

namespace Task1.Controllers
{
	public class EmployeeController : Controller
	{
		ApplicationDbContext context=new ApplicationDbContext();
		public IActionResult Index()
		{
			var employee = context.Employees.ToList();
			return View("Index", employee);
		}
	}
}
