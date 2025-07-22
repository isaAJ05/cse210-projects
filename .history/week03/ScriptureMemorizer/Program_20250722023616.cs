using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference();
        reference.SetBook("");
        reference.SetChapter(2);
        reference.SetVerse(2);
        reference.SetEndVerse(2);
    }
}