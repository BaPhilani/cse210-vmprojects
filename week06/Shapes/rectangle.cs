//Create a Rectangle class that inherits from the Shape class.
//Create the _width and _height attributes as private member variables
 //Make sure this class inherits from the base class 
 // //Create a constructor that accepts the color, width, and height, and then call the base constructor with the color. 
 //Override the GetArea() method from the base class and fill in the body of this function to return the area.

using System;
class Rectangle :
Shape { private double _width;
private double _height;
public Rectangle(string color, double width, double height) :
base(color) { _width = width; _height = height; }
    public override double GetArea()
    {
        return _width * _height; // Area of a rectangle is width * height
    }
}
