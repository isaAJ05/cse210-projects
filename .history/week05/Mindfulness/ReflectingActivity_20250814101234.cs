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

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt(GetRandomPrompt());
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.clez

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions(GetRandomQuestion());
            ShowSpinner(3);
            Console.WriteLine("");
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
        Console.Write($"{_questions[index]} ");
    }
}