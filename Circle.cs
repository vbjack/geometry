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

            // Area will be more than max value
            if (Radius > 7.564545572282618E+153)
                throw new ArgumentException("Radius is too large to be represented as a double");

            double area = Math.PI * Math.Pow(Radius, 2);

            return area;
        }
    }
}
