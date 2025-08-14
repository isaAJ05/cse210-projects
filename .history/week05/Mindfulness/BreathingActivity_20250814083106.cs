using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        Console.WriteLine("Welcome to the Breathing Activity");
        Console.WriteLine("his activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("string choice = Console.ReadLine();")
    }
}