//Displays the message, "Welcome to the Program!
//Asks for and returns the user's name (as a string)
//Accepts an integer as a parameter and returns that number squared (as an integer)
//Accepts two integers as parameters and returns their sum (as an integer)
//Accepts the user's name and the squared number and displays them
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");

        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Write("Enter an integer to be squared: ");
        int number = int.Parse(Console.ReadLine());
        int squaredNumber = Square(number);

        Console.Write("Enter the first integer to sum: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer to sum: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int sum = Sum(firstNumber, secondNumber);

        Console.WriteLine($"{name}, the square of {number} is {squaredNumber}.");
        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {sum}.");
    }

    static int Square(int num)
    {
        return num * num;
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }
}