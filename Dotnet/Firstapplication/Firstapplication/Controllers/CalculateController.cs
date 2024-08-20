using Firstapplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace Firstapplication.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Info()
        {
            Person person=new Person();
            person.Name = "Nirmal Raj";
            person.Basic_Salary = 20000;
            person.Age = 24;
            return View(person);
        }
        public IActionResult Index()
        {
            ViewBag.Heading = "Calculator Application";//add dynamic data to the view
            return View();
        }

        public IActionResult Greetings()
        {
            return View();
        }
    }
}
