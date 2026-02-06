//Controls the flow of the reflecting activity, which is a mindfulness activity that prompts the user to reflect on a past experience.
//Selects random prompts and questions to guide the user's reflection, and manages the timing of the activity.
//Exceeds requirements by allowing the user to choose the duration of the activity and providing a variety of prompts and questions to keep the experience engaging.
//Shows a spinner and countdown to help the user stay focused and engaged throughout the activity.
//Shows reflection prompt
using System;
using System.Collections.Generic;

namespace Homework
{
    public class ReflectingActivity : MindfulnessActivity
    {
        //Attributes
        private List<string> _prompts;
        private List<string> _questions;

        //Constructor to initialize the activity with specific name, description, and duration, as well as the prompts and questions
        public ReflectingActivity()
            : base("Reflecting",
            "This activity will help you reflect on times in your life when you have shown strength.")
        {
            _prompts = new List<string>()
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            _questions = new List<string>()
            {
                "Why was this experience meaningful to you?",
                "How did you feel when it was complete?",
                "What did you learn about yourself?",
                "How can you keep this experience in mind?"
            };
        }

        public override void Run()
        {
            DisplayStartingMessage();
            
            Console.WriteLine("\nConsider the following prompt:");
            DisplayPrompt();
            Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
            Console.ReadLine();
            
            Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
            ShowSpinner(5);
            
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            
            while (DateTime.Now < endTime)
            {
                DisplayQuestions();
                ShowSpinner(8);
            }
            
            DisplayEndingMessage();
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }

        public string GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(_questions.Count);
            return _questions[index];
        }

        public void DisplayPrompt()
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine(prompt);
        }

        public void DisplayQuestions()
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
        }
    }
} 