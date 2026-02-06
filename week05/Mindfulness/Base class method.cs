//The base class handle everything to all activities.
using System;
using System.Collections.Generic;

namespace Homework
{
	public abstract class MindfulnessActivity
	{
		//attribute to make sure only one activity can be run at a time
		protected string _name;
		protected string _description;
		protected int _duration;

		//constructor to initialize the common attributes
		public MindfulnessActivity(string name, string description)
		{
			_name = name;
			_description = description;
		}

		public void DisplayStartingMessage()
		{
			Console.WriteLine($"\nWelcome to the {_name} Activity!");
			Console.WriteLine($"\n{_description}");
			Console.Write("\nHow long, in seconds, would you like for your session? ");
			_duration = int.Parse(Console.ReadLine());
			Console.WriteLine("\nGet ready...");
			ShowSpinner(3);
		}

		public void DisplayEndingMessage()
		{
			Console.WriteLine($"\nWell done!");
			ShowSpinner(3);
			Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity.");
			ShowSpinner(3);
		}

		public void ShowSpinner(int seconds)
		{
			List<string> spinnerChars = new List<string> { "|", "/", "-", "\\" };
			DateTime endTime = DateTime.Now.AddSeconds(seconds);
			int i = 0;
			
			while (DateTime.Now < endTime)
			{
				Console.Write(spinnerChars[i]);
				System.Threading.Thread.Sleep(250);
				Console.Write("\b \b");
				i = (i + 1) % spinnerChars.Count;
			}
		}

		public void ShowCountDown(int seconds)
		{
			for (int i = seconds; i > 0; i--)
			{
				Console.Write(i);
				System.Threading.Thread.Sleep(1000);
				Console.Write("\b \b");
			}
		}

		public abstract void Run();
	}
}