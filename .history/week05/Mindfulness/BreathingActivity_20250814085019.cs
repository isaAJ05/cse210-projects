using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);
        Console.WriteLine("Breathe in...");
        ShowCountdown(4);
        Console.WriteLine("Breathe out...");
        ShowCountdown(6);
        DisplayEndingMessage();
        ShowSpinner(3);
    }
}