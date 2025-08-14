using System;
public class BreathingActivity : Activity
{
   
    public BreathingActivity(string name, string description, int duration, int breathCount)
        : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);
        for (int i = 0; i < _breathCount; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }
        DisplayEndingMessage();
    }
}