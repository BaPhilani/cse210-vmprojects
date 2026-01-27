//Supplies random prompts whenever needed.
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the best part of your day?",
            "What are you grateful for today?",
            "Write about a challenge you overcame recently.",
            "How did I see the hand of the Lord in my life today?",
            "Who was the most interesting person I interacted with today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did I learn today that surprised me?",
            "What act of kindness did I witness or perform today?",
            "What made me smile or laugh today?",
            "What goal did I make progress on today?",
            "What scripture or quote inspired me today?",
            "How did I grow spiritually today?",
            "What are three things I accomplished today?",
            "What conversation had the biggest impact on me today?"
        };
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
