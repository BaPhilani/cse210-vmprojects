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
            "What was the best part of my day?",
            "What are you grateful for today?",
            "Write about a challenge you overcame recently.",
            "How did I see the hand of the Lord in my life today?"
        };
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
