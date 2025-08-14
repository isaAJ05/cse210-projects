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
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet...")
}
        Console.WriteLine("Breathe in...");
        ShowCountdown(4);
        Console.WriteLine("Breathe out...");
        ShowCountdown(6);
        DisplayEndingMessage();
        ShowSpinner(3);
    }
}