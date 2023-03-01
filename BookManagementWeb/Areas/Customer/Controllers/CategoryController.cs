using BookManagement.DataAccess;
using BookManagement.DataAccess.Repository;
using BookManagement.DataAccess.Repository.IRepository;
using BookManagement.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookManagementWeb.Areas.Customer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork unit;
        public ProductController(IUnitOfWork _unit)
        {
            unit = _unit;
        }
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Category> list = unit.CategoryRepo.GetAll();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                unit.CategoryRepo.Add(obj);
                unit.Save();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var result = unit.CategoryRepo.FindData(Id);

            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                unit.CategoryRepo.Update(obj);
                unit.Save();
                return RedirectToAction("Edit");
            }
            return View(obj);
        }

        public IActionResult Delete(int Id)
        {

            var obj = unit.CategoryRepo.FindData(Id);
            unit.CategoryRepo.Delete(obj);
            unit.Save();
            return RedirectToAction("Index");


        }
    }
}
