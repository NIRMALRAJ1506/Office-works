using Firstapplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace Firstapplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product pro=new Product();
            pro.Product_Id = 1;
            pro.Product_Name = "Laptop";
            pro.Product_Price = 52000;
            pro.Product_Description = "Dell Inspiron 3501";
            return View(pro);
        }
    }
}
