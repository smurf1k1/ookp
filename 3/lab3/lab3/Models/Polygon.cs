using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class Polygon
    {
        public decimal NumberOfSide { get; set; }
        public decimal Lenght { get; set; }

        public Polygon(decimal numberOfSide, decimal lenght)
        {
            NumberOfSide = numberOfSide;
            Lenght = lenght;
        }
    }
}
