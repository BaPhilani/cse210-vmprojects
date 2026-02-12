//Create a Square instance, call the GetColor() and GetArea() methods and make sure they return the values you expect.
//create a list to hold shapes 
//add a circle, rectangle, and square to the list 
//loop through the list and print out the color and area of each shape.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square mySquare = new Square("Red", 5.0);
Console.WriteLine($"Color: {mySquare.GetColor()}");
Console.WriteLine($"Area: {mySquare.GetArea()}");

// Create a list to hold shapes
List<Shape> shapes = new List<Shape>();

// Add a circle, rectangle, and square to the list
shapes.Add(new Circle("Blue", 3.0));
shapes.Add(new Rectangle("Green", 4.0, 6.0));
shapes.Add(new Square("Yellow", 2.0));

// Loop through the list and print out the color and area of each shape
foreach (Shape shape in shapes)
{
    Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
}
    }
}