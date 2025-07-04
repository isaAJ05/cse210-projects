using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string answer = Console.ReadLine();
        Console.Write("What is the magic number? ");
        string answer = Console.ReadLine();
        int guess = int.Parse(answer);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
    }
}