using System;
using System.Threading;
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Thread.Sleep(800);
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Thread.Sleep(1000);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("");

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine($"Well done!!");
        Thread.Sleep(800);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Thread.Sleep(1500);

    }
    public void ShowSpinner(int seconds)
        {

        char[] spinnerChars = { '|', '/', '-', '\\' };
        int counter = 0;

        for (int i = 0; i < seconds * 2; i++) 
        {
            Console.Write(spinnerChars[counter % spinnerChars.Length]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            counter++;
        }

    }
    public void ShowCountdown(int seconds)
    {

        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1500);
            Console.Write("\b \b");
        }
        
    }
}