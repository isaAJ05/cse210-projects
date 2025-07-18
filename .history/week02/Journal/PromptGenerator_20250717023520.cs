using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("Did I think celestial?");
        _prompts.Add("Do I have to repent about something?");
        _prompts.Add("What can I do different tomorrow?");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 6);
        if (number == 1)
        {
            return "How did I see the hand of the Lord in my life today?";
        }
        else if (number == 2)
        {
            return "What was the best part of my day?";
        }
        else if (number == 3)
        {
            return ;
        }
        else if (number == 4)
        {
            return ;
        }
        else if (number == 5)
        {
            return ;
        }
        else
        {
            return ;
        }

    }
}