using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("Alma", 2, 2, 2);
        
        while (Console.ReadLine().ToLower() != "quit")
        {
            Console.Write(" holaa");
            // This will clear the console
            Console.ReadLine();
            Console.Clear();
            Console.Write(" holaa como");
        }
    }
}