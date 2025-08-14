using System;
public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description)
        : base(name, description, 0) 
    {
        
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Now hold...");

            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
        }
        DisplayEndingMessage();
        ShowSpinner(3);
            }
}