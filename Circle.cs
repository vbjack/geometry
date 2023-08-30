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
            if (Radius < 0)
                throw new ArgumentException("Radius cannot be negative");

            if (Radius >= double.MaxValue)
                throw new ArgumentException("Radius is too large to be represented as a double");

            double area = Math.PI * Math.Pow(Radius, 2);

            if (double.IsInfinity(area))
                throw new ArgumentException("Area is too large to be represented as a double");

            return area;
        }
    }
}
