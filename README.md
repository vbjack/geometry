# Geometry
Geometric calculations

You need to create an object of the shape whose area you want to calculate with the required number of parameters.
Then call the CalculateArea method with this object.

**Supported Shapes**
The library currently supports the following shapes:
- Circle
- Triangle

**Usage**
Here is an example of how to use the library to calculate the area of a circle:
```cshart
using Geometry;

var circle = new Circle(10);
double area = circle.CalculateArea();
```

**Tests**
The project uses xunit testing 
