using lab4.Contracts;
using lab4.Factory;
using System;

namespace lab4
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            IPolygon polygon = new FigureFactory().MakeCalculate();
            char key;
            char answer;
            do
            {
                Console.WriteLine("1. Trianle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Circle");
                Console.WriteLine("4. Square");
                Console.WriteLine("5. Trapezium");
                Console.WriteLine("6. Rhomb");
                Console.WriteLine("7. Parallelogram");
                Console.WriteLine("=======================================");
                key = (char)Console.Read();
                Console.ReadLine();
                Console.WriteLine("=======================================");
                switch (key)
                {
                    case '1':
                        Console.Write("Enter a:");
                        double triangleA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter b:");
                        double triangleB = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(polygon.Triangle(triangleA,triangleB));
                        break;
                    case '2':
                        Console.Write("Enter a:");
                        double rectangleA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter b:");
                        double rectangleB = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(polygon.Rectangle(rectangleA, rectangleB));
                        break;
                    case '3':
                        Console.Write("Enter radius:");
                        double r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(polygon.Circle(r));
                        break;
                    case '4':
                        Console.Write("Enter a:");
                        double squareA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(polygon.Square(squareA));
                        break;
                    case '5':
                        Console.Write("Enter a:");
                        double trapeziumA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter b:");
                        double trapeziumB = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter h:");
                        double trapeziumh = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(polygon.Trapezium(trapeziumA, trapeziumB, trapeziumh));
                        break;
                    case '6':
                        Console.Write("Enter a:");
                        double rhombA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter h:");
                        double rhombh = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(polygon.Rhomb(rhombA, rhombh));
                        break;
                    case '7':
                        Console.Write("Enter a:");
                        double parallelogramA = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter h:");
                        double parallelogramh = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(polygon.Parallelogram(parallelogramA, parallelogramh));
                        break;
                }
                Console.WriteLine("================================");
                Console.WriteLine("Continue y/n");
                answer = (char)Console.Read();
                Console.ReadLine();
            } while (answer != 'n');
        }
    }
}
