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
        
    private string[] GetListFromUser()
    {
        return new string[_count];
    }
}