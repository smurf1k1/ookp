namespace lab4.Contracts
{
    public interface IPolygon
    {
        double Triangle(double a, double b);
        double Rectangle(double a, double b);
        double Circle(double r);
        double Square(double a);
        double Trapezium(double a, double b, double h);
        double Rhomb(double a, double h);
        double Parallelogram(double a, double h);
    }
}
