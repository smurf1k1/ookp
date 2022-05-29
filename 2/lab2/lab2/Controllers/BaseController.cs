using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
