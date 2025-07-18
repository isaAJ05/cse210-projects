using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 6);
        if (number == 1)
        {
            return "";
        }
        else if (number == 2)
        {
            return "";
        }
        else if (number == 3)
        {
            return "";
        }
        else if (number == 4)
        {

        }
        else if (number == 5)
        {

        }
        else 
        {
            
        }

    }
}