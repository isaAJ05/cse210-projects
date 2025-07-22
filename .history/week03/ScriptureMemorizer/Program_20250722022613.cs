using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        Console.WriteLine("Please Enter the book: ");
        reference.SetBook(Console.ReadLine());
        Console.WriteLine("Please Enter the chapter: ");
        int chapter = Console.ReadLine();
        Console.WriteLine("Please Enter the verse/s: ");
        string book = Console.ReadLine();
    }
}