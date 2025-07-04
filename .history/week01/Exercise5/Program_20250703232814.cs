using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Hello world!");
        }
        static void PromptUserName()
        {
            Console.Write("Please enter your name: ")
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResult(string userName, )
        {
            Console.WriteLine($"Hello {userName}");
        }

    }
}