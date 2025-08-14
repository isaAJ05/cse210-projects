using System;
public class ListingActivity : Activity
{
    private int

    public ListingActivity(string name, string description, int duration, string[] items)
        : base(name, description, duration)
    {
        _items = items;
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);
        DisplayItems();
        ShowCountdown(5);
        DisplayEndingMessage();
    }

    private void DisplayItems()
    {
        Console.WriteLine("Here are the items to list:");
        foreach (var item in _items)
        {
            Console.WriteLine($"- {item}");
        }
    }
}