using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 5);
        if (number == 1)
        {
            return "";
        }else if (number == 2)

    }
}