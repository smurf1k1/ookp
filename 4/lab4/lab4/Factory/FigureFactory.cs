using lab4.Contracts;
using lab4.Services;

namespace lab4.Factory
{
    public class FigureFactory : PolygonFactory
    {
        protected override IPolygon CalculatePolygon()
        {
            IPolygon polygon = new PolygonService();
            return polygon;
        }
    }
}
