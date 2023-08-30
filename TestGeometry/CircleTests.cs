using Geometry;

namespace TestGeometry
{
    [Trait("Category", "Unit")]
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_Success()
        {
            //arrange
            double radius = 15.0;
            Circle circle = new Circle(radius);

            //act 
            double area = circle.CalculateArea();

            //asserts
            Assert.Equal(Math.PI * Math.Pow(radius, 2), area);
        }

        [Fact]
        public void CalculateArea_NegativeRadius()
        {
            //arrange
            double radius = -5.3;
            Circle circle = new Circle(radius);

            //act and Assert
            Assert.Throws<ArgumentException>(() => circle.CalculateArea());
        }

        [Fact]
        public void CalculateArea_LargeRadius()
        {
            //arrange
            double radius = 1E+154;
            Circle circle = new Circle(radius);

            //act and Assert
            Assert.Throws<ArgumentException>(() => circle.CalculateArea());
        }
    }
}
