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
        DisplayStartingMessage();
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("List as many responses you can to the following prompt:");
            GetRandomPrompt();
            Console.WriteLine("You may begin in:");
            ShowCountdown(5);
            GetListFromUser();
            Console.WriteLine($"You listed {GetListFromUser().Count} items!");
            ShowSpinner(3);
        }

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
        string[] userResponses = new string[_count];
        for (int i = 0; i < _count; i++)
        {
            userResponses[i] = Console.ReadLine();
        }

        
        return userResponses;
    }
}