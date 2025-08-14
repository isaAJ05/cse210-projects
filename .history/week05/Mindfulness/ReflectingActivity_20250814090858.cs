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

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("Consider the following prompt:");
            Thread.Sleep(1000);
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
            ShowCountdown(6);
        }

        DisplayEndingMessage();
        ShowSpinner(3);
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        Console.WriteLine($"Prompt: {_prompts[index]}");
        Console.WriteLine("Take a moment to reflect on this prompt.");
        ShowSpinner(5);
        DisplayQuestions();
    }
    public void GetRandomQuestion()
    {

    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {

    }
}