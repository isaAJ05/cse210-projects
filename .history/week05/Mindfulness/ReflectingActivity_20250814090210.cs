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

    }
    public void GetRandomPrompt()
    {

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