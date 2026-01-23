
using System;

namespace week03.Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the Fractions Project.\n");

            // Test Fraction class with several different fractions
            Fraction[] fractions = {
                new Fraction(1, 1),
                new Fraction(5, 1),
                new Fraction(3, 4),
                new Fraction(1, 3)
            };

            foreach (var frac in fractions)
            {
                Console.WriteLine(frac.GetFractionString());
                Console.WriteLine(frac.GetDecimalValue());
            }
        }
    }
}