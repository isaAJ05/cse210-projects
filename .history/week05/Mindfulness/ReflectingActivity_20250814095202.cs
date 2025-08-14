using System;
public class ReflectingActivity : Activity
{
    private string[] _prompts;
    private string[] _questions;

    public ReflectingActivity(string name, string description, string[] prompts, string[] questions)
        : base(name, description, 0)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
DisplayStartingMessage();
        ShowSpinner(3);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        Console.WriteLine($"You listed {responses.Count} items!");

        DisplayEndingMessage();
        ShowSpinner(3);
    }
    public int GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return index;
        
    }
    public int GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Length);
        return index;

    }
    public void DisplayPrompt(int index)
    {
        
        Console.WriteLine($"--- {_prompts[index]} ---");
    }
    public void DisplayQuestions(int index)
    {
        Console.WriteLine($"{_questions[index]}");
    }
}