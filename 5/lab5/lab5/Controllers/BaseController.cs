using Microsoft.AspNetCore.Mvc;

namespace lab5.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
