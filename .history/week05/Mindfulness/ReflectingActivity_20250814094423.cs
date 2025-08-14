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

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("Consider the following prompt:");
            DisplayPrompt(GetRandomPrompt());
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.WriteLine("You may begin in:");
            ShowCountdown(5);
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < futureTime)
            {
                Console.WriteLine(GetRandomQuestion());
                ShowSpinner(3);
            }

            DisplayEndingMessage();
            ShowSpinner(3);
        }

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