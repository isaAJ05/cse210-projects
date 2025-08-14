using System;
public class ListingActivity : Activity
{
    private int _count;
    private string[] _prompts;

    public ListingActivity(string name, string description, int count, string[] prompts)
        : base(name, description, 0)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {

    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_count);
        Console.WriteLine($"--- {_prompts[index]} ---");
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);
        Console.WriteLine("Now list as many responses as you can.");
        string[] responses = GetListFromUser();
        Console.WriteLine($"You listed {responses.Length} items.");
    }
    private string[] GetListFromUser()
    {
        return new string[_count];
    }
}