using System;
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {

    }
    public void ShowSpinner(int seconds)
        Console.Write("+");

    Thread.Sleep(500);

    Console.Write("\b \b"); // Erase the + character
    Console.Write("-"); // Replace it with the - character

    {

    }
    public void ShowCountdown(int seconds)
    {

    }
}