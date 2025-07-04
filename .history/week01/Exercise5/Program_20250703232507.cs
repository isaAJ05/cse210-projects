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
        static int SquareNumber(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
    }
}