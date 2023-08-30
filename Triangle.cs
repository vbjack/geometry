namespace Geometry
{
    public class Triangle : IShape
    {
        private readonly double Side1;
        private readonly double Side2;
        private readonly double Side3;

        public Triangle (double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double CalculateArea()
        {
            return 0;
        }
    }
}