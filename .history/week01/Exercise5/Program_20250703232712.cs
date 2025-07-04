using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Hello world!");
        }
        static void PromptUserName(string userName)
        {
            Console.WriteLine($"Hello {userName}");
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplauResult(string userName)
        {
            Console.WriteLine($"Hello {userName}");
        }

    }
}