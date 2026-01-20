//Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
using System;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        do
        {
            Console.Write("Enter a number (0 to stop): ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        Console.WriteLine("You entered the following numbers:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        //Compute the sum, or total, of the numbers in the list
        //Compute the average of the numbers in the list
        //Find the maximum number in the list
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Maximum: {max}");
    }
}
