using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplicationEFDemo.Models;

namespace WebApplicationEFDemo.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext companyContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,CompanyContext cc)
        {
            _logger = logger;
            companyContext = cc;
         

        }

        public IActionResult Index()
        {
            var dept = new Department()
            {
                Name = "Information Technology"
            };
            companyContext.Entry(dept).State = EntityState.Added;
            companyContext.SaveChanges();
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