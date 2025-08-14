using System;
public class ListingActivity : Activity
{
    private int _count;
    private string[] _prompts;

    public ListingActivity(string name, string description, int duration, int count, string[] prompts)
        : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        
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