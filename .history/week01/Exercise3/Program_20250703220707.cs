using System;

class Program
{
    static void Main(string[] args)
    {
        int continue = 0;
        while (continue == 0)
        Console.Write("What is the magic number? ");
        string answer_magic = Console.ReadLine();
        int magic = int.Parse(answer_magic);

        Console.Write("What is your guess? ");
        string answer = Console.ReadLine();
        int guess = int.Parse(answer);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        if (magic > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magic < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}