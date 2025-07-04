using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Hello world!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
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