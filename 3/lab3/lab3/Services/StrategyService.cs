using lab3.Contracts;
using lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Services
{
    public class StrategyService : IStrategy
    {
        public decimal Perimetr(Polygon polygon)
        {
            decimal result = polygon.NumberOfSide * polygon.Lenght;
            return result;
        }
    }
}
