using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("Alma", 2, 2, 2);
        Scripture scripture = new Scripture(reference, "here is a lot of text");
        Console.WriteLine("AAA");
        string aux = "";
        while (aux != "quit")
        {
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            aux = Console.ReadLine();
            Console.Clear();
            Random random = new Random();
            scripture.HideRandomWords(random)
            Console.WriteLine("BBB");
        }
    }
}