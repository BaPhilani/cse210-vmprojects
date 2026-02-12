//Create circle class that inherits from the Shape class.
//Create the _width and _height attributes as private member variables
 //Make sure this class inherits from the base class 
 // //Create a constructor that accepts the color, width, and height, and then call the base constructor with the color. 
 //Override the GetArea() method from the base class and fill in the body of this function to return the area.
using System;
class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius; // Area of a circle is πr^2
    }
}
