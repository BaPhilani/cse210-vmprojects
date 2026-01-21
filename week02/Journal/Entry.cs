//to track of the date, prompt text, entry text and have a method to display the entry
using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _entryText;

    public Entry(string date, string prompt, string entryText)
    {
        _date = date;
        _prompt = prompt;
        _entryText = entryText;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nEntry: {_entryText}\n");
    }
}
