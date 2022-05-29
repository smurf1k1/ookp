using lab2.Common.Contracts;
using lab2.Dal;
using lab2.Models;
using System.Collections.Generic;
using System.Linq;

namespace lab2.Common.Services
{
    public class ParkingService : IParkingRepository
    {
        private readonly ParkingDbContext _context;

        public ParkingService(ParkingDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Place> GetavailablePlaces()
        {
            return _context.Places.ToList();
        }

        public void MakeReservation(Order order)
        {
            var makeOrder = new Order
            {
                Id = order.Id,
                Hourse = order.Hourse,
                PlaceId = order.PlaceId
            };

            _context.Orders.Add(makeOrder);
            _context.SaveChanges();
        }
    }
}
