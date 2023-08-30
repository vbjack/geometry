namespace Geometry
{
    public class Circle : IShape
    {
        private readonly double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return 0;
        }
    }
}
