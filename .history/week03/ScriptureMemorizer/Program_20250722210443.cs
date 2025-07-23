using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("Alma", 37, 37);
        Scripture scripture = new Scripture(reference, "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());
        string aux = "";
        while (aux != "quit" && scripture.IsCompletelyHidden()== true)
        {
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            aux = Console.ReadLine();
            Console.Clear();
            Random random = new Random();
            scripture.HideRandomWords(random.Next(1,10 ));
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}