//to track of the date, prompt text, entry text and have a method to display the entry
using System;
using System.Collections.Generic;

public class Entry
{
    public string _date { get; set; }
    public string _prompt { get; set; }
    public string _entryText { get; set; }
    public string _mood { get; set; }  // Exceeding requirement: mood tracking

    public Entry()
    {
        // Parameterless constructor for JSON deserialization
    }

    public Entry(string date, string prompt, string entryText, string mood = "")
    {
        _date = date;
        _prompt = prompt;
        _entryText = entryText;
        _mood = mood;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        if (!string.IsNullOrEmpty(_mood))
        {
            Console.WriteLine($"Mood: {_mood}");
        }
        Console.WriteLine($"Entry: {_entryText}\n");
    }
}
