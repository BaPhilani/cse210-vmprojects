
//Guess My Number game the computer picks a magic number, and then the user tries to guess it.
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }

            if (magicNumber > guess)
            {
                Console.WriteLine("Too low — guess higher.");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Too high — guess lower.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}