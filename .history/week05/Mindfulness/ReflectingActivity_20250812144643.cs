using System;
public class ReflectingActivity : Activity
{
    private string[] _prompts;
    private string[] _questions;

    public ReflectingActivity(string name, string description, int duration, string[] prompts, string[] questions)
        : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void DisplayPrompts()
    {
        Console.WriteLine("Reflect on the following prompts:");
        foreach (string prompt in _prompts)
        {
            Console.WriteLine($"- {prompt}");
        }
    }

    public void AskQuestions()
    {
        Console.WriteLine("Consider the following questions:");
        foreach (string question in _questions)
        {
            Console.WriteLine($"- {question}");
        }
    }
}