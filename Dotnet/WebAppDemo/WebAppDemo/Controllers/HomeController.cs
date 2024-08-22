using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebAppDemo.Models;

namespace WebAppDemo.Controllers
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
            return View();
        }
        public string CreateInformation()
        {
            var info = new Information()
            {
                Name = "Nirmal Raj",
                Licence="XXYYZZ",
                Revenew=10000,
                Established=Convert.ToDateTime("2024/08/01")
            };
            companyContext.Entry(info).State = EntityState.Added;
            companyContext.SaveChanges();

            return "Added Successfully";
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
