using lab2.Models;
using System.Collections.Generic;

namespace lab2.Common.Contracts
{
    public interface IParkingRepository
    {
        IEnumerable<Place> GetavailablePlaces();
        void MakeReservation(Order order);
    }
}
