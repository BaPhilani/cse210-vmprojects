// This is the main program for the Mindfulness project. It will serve as the entry point for the application and will contain the main logic for running the mindfulness exercises.
// The program will allow the user to choose from a variety of mindfulness activities, such as breathing exercises, reflecting on past experiences, and listing things they are grateful for.
// The program will also include a base class for mindfulness activities, which will handle common functionality such
// as displaying messages, showing a spinner, and counting down time for the activities. Each specific activity will inherit from this base class and implement its own unique behavior.
using System;
using Homework;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();

            MindfulnessActivity activity = null;

            if (choice == "1") activity = new BreathingActivity();
            else if (choice == "2") activity = new ReflectingActivity();
            else if (choice == "3") activity = new ListingActivity();
            else if (choice == "4") break;

            if (activity != null)
            {
                activity.Run();
            }
        }
    }
} 