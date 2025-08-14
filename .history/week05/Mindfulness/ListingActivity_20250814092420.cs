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
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now list as many responses as you can in the area of this prompt.");
            Console.WriteLine("You may begin in:");
            ShowCountdown(5);
            GetListFromUser();
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
        return new string[_count];
    }
}