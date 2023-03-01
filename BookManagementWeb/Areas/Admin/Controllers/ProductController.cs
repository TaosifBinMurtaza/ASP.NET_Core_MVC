using BookManagement.DataAccess.Repository.IRepository;
using BookManagement.Model;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementWeb.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork unit;
        public ProductController(IUnitOfWork _unit)
        {
            unit = _unit;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> list = unit.ProductRepo.GetAll();
            return View(list);
           
        }
    }
}
