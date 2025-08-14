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
            GetRandomPrompt();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            
        }

        DisplayEndingMessage();
        ShowSpinner(3);
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        Console.WriteLine($"--- {_prompts[index]} ---");
        
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