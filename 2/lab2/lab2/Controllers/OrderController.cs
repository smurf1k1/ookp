using lab2.Common.Contracts;
using lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class OrderController : Controller
    {
        private readonly IParkingRepository _repository;

        public OrderController(IParkingRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllPlacesSlots()
        {
            var result = _repository.GetavailablePlaces();
            return View(result);
        }

        [HttpGet]
        public IActionResult MadeReservation(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public string MadeReservation(Order order)
        {
            _repository.MakeReservation(order);
            return "Reservasition is done";
        }
    }
}
