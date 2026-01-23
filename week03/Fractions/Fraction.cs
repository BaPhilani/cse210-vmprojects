// the principle of encapsulation by creating classes to hold a fraction, 
//Attributes for the top and bottom numbers
//Constructors
//Getters and setters for the top and bottom numbers
//Methods to return representations of both the fractional and decimal views.
using System.Formats.Asn1;

namespace week03.Fractions
{
    public class Fraction
    {
        // Attributes
        private int numerator;
        private int denominator;

        // create Constructor
        public Fraction(int top, int bottom)
        {
            numerator = top;
            denominator = bottom;
        }

        // create Getters and Setters
        public int GetNumerator()
        {
            return numerator;
        }

        public void SetNumerator(int top)
        {
            numerator = top;
        }

        public int GetDenominator()
        {
            return denominator;
        }

        public void SetDenominator(int bottom)
        {
            denominator = bottom;
        }

        // Method to return fractional representation as string
        public string GetFractionString()
        {
            return $"{numerator}/{denominator}";
        }

        // Method to return decimal value
        public double GetDecimalValue()
        {
            return (double)numerator / denominator;
        }

        // Override ToString for better display
        public override string ToString()
        {
            return GetFractionString();
        }
        //call each constructor and that you can retrieve and display the different representations for a few different fractions. 
        
    }
}
