using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("Alma", 2, 2, 2);
        Console.WriteLine("AAA");
        string aux = "";
        while (aux != "quit")
        {
            //Scripture scripture = new Scripture(reference, "here the text");
            // This will start by displaying "AAA" and waiting for the user to press the enter key
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            aux = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("BBB");
        }
    }
}