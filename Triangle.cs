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
            if (Side1 < 0 || Side2 < 0 || Side3 < 0)
                throw new ArgumentException("Sides cannot be negative");

            if (IsRightTriangle())
            {
                return CalculateAreaRightTriangle();
            }
            else
            {
                return CalculateAreaGeneric();
            }
        }

        private bool IsRightTriangle()
        {
            double[] Sides = { Side1, Side2, Side3 };
            Array.Sort(Sides);
            return Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) == Math.Pow(Sides[2], 2);
        }

        private double CalculateAreaRightTriangle()
        {
            double[] Sides = { Side1, Side2, Side3 };
            Array.Sort(Sides);
            double area = 0.5 * Sides[0] * Sides[1];
            if (double.IsInfinity(area))
                throw new ArgumentException("Area is too large to be represented as a double");

            return area;
        }

        private double CalculateAreaGeneric()
        {
            if (Side1 + Side2 <= Side3 || Side1 + Side3 <= Side2 || Side2 + Side3 <= Side1)
                throw new ArgumentException("Invalid triangle Sides");

            double p = (Side1 + Side2 + Side3) / 2;
            double area = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));

            if (double.IsInfinity(area))
                throw new ArgumentException("Area is too large to be represented as a double");

            return area;
        }
    }
}