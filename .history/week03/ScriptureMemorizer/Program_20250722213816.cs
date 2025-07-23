using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("2 Nephi", 2, 24, 25);
        Scripture scripture = new Scripture(reference, "But behold, all things have been done in the wisdom of him who knoweth all things. Adam fell that men might be; and men are, that they might have joy.");
        Console.WriteLine(scripture.GetDisplayText());
        string aux = "";
        while (aux != "quit" && !scripture.IsCompletelyHidden())
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