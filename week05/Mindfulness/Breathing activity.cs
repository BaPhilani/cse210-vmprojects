//alternates between inhale and exhale
using System;

namespace Homework
{
    public class BreathingActivity : MindfulnessActivity
    {
        //constructors to initialize the activity with specific name, description, and duration
        public BreathingActivity()
            : base("Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly.")
        {
        }

        public override void Run()
        {
            DisplayStartingMessage();
            
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("\nBreathe in...");
                ShowCountDown(4);
                Console.WriteLine("Breathe out...");
                ShowCountDown(4);
            }
            
            DisplayEndingMessage();
        }
    }
}