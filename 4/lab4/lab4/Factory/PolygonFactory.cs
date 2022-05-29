using lab4.Contracts;

namespace lab4.Factory
{
    public abstract class PolygonFactory
    {
        protected abstract IPolygon CalculatePolygon();

        public IPolygon MakeCalculate()
        {
            return this.CalculatePolygon();
        }
    }
}
