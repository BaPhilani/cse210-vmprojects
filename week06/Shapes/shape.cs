//polymorhism: many forms 
//Add the color member variable and a getter and setter for shape class. 
//Create a constructor that accepts the color and sets it. 
//Create a virtual method for GetArea(). 
using System;
class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0; // Base shape has no area
    }
}