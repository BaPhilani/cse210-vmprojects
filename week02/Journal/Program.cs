using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    PromptGenerator promptGen = new PromptGenerator();
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\n{prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAllEntries();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}