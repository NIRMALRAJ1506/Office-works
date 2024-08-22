using EFCRUDDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCRUDDemo.Controllers
{
    public class DepartmentController : Controller
    { 

        private CompanyContext companyContext;
        
        public DepartmentController(CompanyContext cc)
        {
            companyContext = cc;
        }
        public  IActionResult Create()
        {
            //var dept1 = new Department()
            //{
            //    Name = "MECH"
            //};
            //var dept2 = new Department()
            //{
            //    Name = "ECE"
            //};
            //var dept3 = new Department()
            //{
            //    Name = "CSE"
            //};
            //var dept4 = new Department()
            //{
            //    Name = "EEE"
            //};

            //companyContext.Department.AddRange(dept1, dept2, dept3, dept4);
            //var dept = new Department()
            //{
            //    Name = "Designing"
            //};
            //companyContext.Add(dept);
            //companyContext.SaveChanges();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Department dept)
        {
            companyContext.Add(dept);
            await companyContext.SaveChangesAsync();
            return View();
        }
        public IActionResult Index()
        {
            return View(companyContext.Department.AsNoTracking());
        }

        public async Task<IActionResult> Edit(int id)
        {
            Department dept = await companyContext.Department.Where(e => e.Id == id).FirstOrDefaultAsync();
            return View(dept);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Department dept)
        {
            companyContext.Update(dept);
            await companyContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var dept = new Department() { Id = id };
            companyContext.Remove(dept);
            await companyContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
