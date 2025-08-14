using System;
public class ListingActivity : Activity
{
    private int _count;
    private string[] _prompts;

    public ListingActivity(string name, string description, string[] prompts)
        : base(name, description, 0)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        string[] responses = GetListFromUser();
        _count = responses.Length;
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
        ShowSpinner(3);

    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_count);
        Console.WriteLine($"--- {_prompts[index]} ---");
    }
        
    private string[] GetListFromUser()
    {
        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
        string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        return responses.ToArray();
    }
}