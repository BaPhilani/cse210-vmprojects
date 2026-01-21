// added creativity
// how much mmoney have you spent today?
//Supplies random prompts whenever needed.
//do you have outstanding tasks for the day?
using System;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);

        Entry entry = new Entry();
        entry._prompt = prompt;
        journal.AddEntry(entry);
        journal.DisplayAllEntries();
    }
}

class Program : NewBaseType
{
}