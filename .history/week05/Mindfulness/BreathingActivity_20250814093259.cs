using System;
public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description)
        : base(name, description, 0) 
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
            for (int i = 0; i < _duration / 10; i++)
            {
                Console.WriteLine("Breathe in...");
                Thread.Sleep(1000);
                ShowCountdown(4);
                Console.WriteLine("Breathe out...");
                ShowCountdown(6);
            }
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
            ShowCountdown(6);
        }

        DisplayEndingMessage();
        ShowSpinner(3);
    }
}