using Geometry;
using Xunit;

namespace TestGeometry
{
    [Trait("Category", "Unit")]
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_Generic_Success()
        {
            //arrange
            double side1 = 3;
            double side2 = 2.5;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            //act
            double area = triangle.CalculateArea();

            //assert
            Assert.Equal(2.8497532787944992, area);
        }

        [Fact]
        public void CalculateArea_RightTriangle_Success()
        {
            //arrange
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0;
            Triangle triangle = new Triangle(side1, side2, side3);

            //act
            double area = triangle.CalculateArea();

            //assert
            Assert.Equal(6.0, area);
        }

        [Fact]
        public void CalculateArea_NegativeSides()
        {
            //arrange
            double side1 = 3.0;
            double side2 = -4.0;
            double side3 = 5.0;
            Triangle triangle = new Triangle(side1, side2, side3);

            //act and Assert
            Assert.Throws<ArgumentException>(() => triangle.CalculateArea());
        }

        [Fact]
        public void CalculateArea_InvalidTriangle()
        {
            //arange
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 8.0;
            Triangle triangle = new Triangle(side1, side2, side3);

            //act and assert
            Assert.Throws<ArgumentException>(() => triangle.CalculateArea());
        }
    }
}