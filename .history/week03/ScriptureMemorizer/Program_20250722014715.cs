using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Scripture scripture = new Scripture();

        Console.WriteLine("Please Enter the book: ");
        scripture._reference._book = Console.ReadLine();
        Console.WriteLine("Please Enter the chapter: ");
        int chapter = Console.ReadLine();
        Console.WriteLine("Please Enter the verse/s: ");
        string book = Console.ReadLine();
    }
}