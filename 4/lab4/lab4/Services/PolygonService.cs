using lab4.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Services
{
    public class PolygonService : IPolygon
    {
        public double Circle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public double Parallelogram(double a, double h)
        {
            return a * h;
        }

        public double Rectangle(double a, double b)
        {
            return a * b;
        }

        public double Rhomb(double a, double h)
        {
            return a * h;
        }

        public double Square(double a)
        {
            return Math.Pow(a, 2);
        }

        public double Trapezium(double a, double b, double h)
        {
            return ((a + b) / 2) * h;
        }

        public double Triangle(double a, double b)
        {
            return 1 / 2 * (a * b);
        }
    }
}
