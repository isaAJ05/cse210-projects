using System;
using System.Diagnostics.Tracing;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts = ["How did I see the hand of the Lord in my life today?", "What was the best part of my day?", "What was the strongest emotion I felt today?", "Did I think celestial?", "Do I have to repent about something?", "What can I do different tomorrow?"];
    
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 6);
        return _prompts[number];
    }
}
