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

        GetRandomPrompt();
        ShowSpinner(5);

        Console.WriteLine("Take a moment to reflect on the prompt.");
        ShowSpinner(5);

        DisplayQuestions();
        ShowSpinner(5);

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