//Create the _side attribute as a private member variable
//Make sure this class inherits from the base class
//Create a constructor that accepts the color and the side, and then call the base constructor with the color.
//Override the GetArea() method from the base class and fill in the body of this function to return the area.
using System;
class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side; // Area of a square is side^2
    }
}
