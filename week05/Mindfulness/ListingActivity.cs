//Manages listing sessions for the Mindfulness program
//Gets random prompts and questions to guide the user through the activity
//Reads user input to determine the duration of the activity and to keep track of how many items the user has listed
using System;
using System.Collections.Generic;

namespace Homework
{
    public class ListingActivity : MindfulnessActivity
    {
        //Attributes
        private int _itemCount;
        private List<string> _prompts;
        private List<string> _questions;

        //Constructor to initialize the activity with specific name, description, and duration, as well as the prompts and questions.
        public ListingActivity()
            : base("Listing",
            "This activity will help you reflect on the good things in your life.")
        {
            _prompts = new List<string>()
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who have you helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
            _questions = new List<string>()
            {
                "Why did you choose this item?",
                "What does this item mean to you?",
                "How can you keep this item in mind?",
                "What can you do to remember this item?"
            };
            _itemCount = 0;
        }

        public override void Run()
        {
            DisplayStartingMessage();
            
            Console.WriteLine("\nList as many responses as you can to the following prompt:");
            Console.WriteLine($" --- {GetRandomPrompt()} ---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();
            
            List<string> items = GetListFromUser();
            _itemCount = items.Count;
            Console.WriteLine($"\nYou listed {_itemCount} items!");
            
            DisplayEndingMessage();
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }

        public List<string> GetListFromUser()
        {
            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    items.Add(input);
                }
            }
            
            return items;
        }
    }
} 