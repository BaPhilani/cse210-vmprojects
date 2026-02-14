//Gaming through levels, The program includes a simple level systembased on user's total score.
//bonus celebration message displayed when a checklistGoal is completed, adding an element of fun and motivation for the user.
//the program to have menu options to createnew goal, list golas, record event, save goals, load goals and exit the program.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        Console.WriteLine("Welcome to the Eternal Quest!");
        Console.WriteLine("Embark on a journey of self-improvement and goal achievement.");
        Console.WriteLine("Choose your path wisely and conquer your goals!");

        while (true)
        {
            Console.WriteLine($"\nTotal Points: {manager.GetTotalPoints()}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice.Trim())
            {
                case "1":
                    CreateNewGoal(manager);
                    break;
                case "2":
                    ListGoals(manager);
                    break;
                case "3":
                    RecordEvent(manager);
                    break;
                case "4":
                    SaveGoals(manager);
                    break;
                case "5":
                    LoadGoals(manager);
                    break;
                case "6":
                    Console.WriteLine("Thank you for playing! Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalManager manager)
    {
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int goalType = ReadInt("Which type of goal would you like to create? ", 1, 3);

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine() ?? string.Empty;

        int points = ReadInt("What is the amount of points associated with this goal? ", 1, int.MaxValue);

        if (goalType == 1)
        {
            manager.AddGoal(new SimpleGoal(name, description, points));
        }
        else if (goalType == 2)
        {
            manager.AddGoal(new EternalGoal(name, description, points));
        }
        else
        {
            int targetCount = ReadInt("How many times does this goal need to be accomplished for a bonus? ", 1, int.MaxValue);
            manager.AddGoal(new ChecklistGoal(name, description, points, targetCount));
        }

        Console.WriteLine("Goal created.");
    }

    static void ListGoals(GoalManager manager)
    {
        Console.WriteLine("\nYour goals are:");
        var goals = manager.GetGoals();
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            string status = goal.IsCompleted() ? "X" : " ";
            string line = $"{i + 1}. [{status}] {goal.GetName()} ({goal.GetDescription()})";

            if (goal is ChecklistGoal checklist)
            {
                line += $" -- Currently completed: {checklist.GetCurrentCount()}/{checklist.GetTargetCount()}";
            }

            Console.WriteLine(line);
        }
    }

    static void RecordEvent(GoalManager manager)
    {
        var goals = manager.GetGoals();
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }

        Console.WriteLine("\nSelect a goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetName()}");
        }

        int goalIndex = ReadInt("Which goal did you accomplish? ", 1, goals.Count) - 1;
        manager.RecordEvent(goalIndex);
    }

    static void SaveGoals(GoalManager manager)
    {
        Console.Write("Enter the file name to save goals: ");
        string fileName = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Invalid file name.");
            return;
        }

        manager.SaveGoals(fileName);
        Console.WriteLine("Goals saved.");
    }

    static void LoadGoals(GoalManager manager)
    {
        Console.Write("Enter the file name to load goals: ");
        string fileName = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Invalid file name.");
            return;
        }

        if (manager.LoadGoals(fileName))
        {
            Console.WriteLine("Goals loaded.");
        }
    }

    static int ReadInt(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(input, out int value) && value >= min && value <= max)
            {
                return value;
            }

            Console.WriteLine("Please enter a valid number.");
        }
    }
}