using lab5.Facade;
using lab5.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab5.Controllers
{
    public class SkladController : Controller
    {
        private readonly FacadePattern _facade;

        public SkladController(FacadePattern facade)
        {
            _facade = facade;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var result = _facade.GetAllProducts();
            return View(result);
        }

        [HttpGet]
        public IActionResult AddProduct(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }

        [HttpPost]
        public string AddProduct(Product product)
        {
            _facade.AddProduct(product);
            return "Product," + product.Name + ",Added";
        }

        [HttpGet]
        public IActionResult GetByPrice(decimal price)
        {
            var result = _facade.GetByPrice(price);
            return View(result);
        }
    }
}

