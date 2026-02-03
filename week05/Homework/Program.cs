using System;
using Homework;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Victor Mtisi", "inheritance in programming", 10);
        Console.WriteLine(assignment.GetSummary());
    }
}