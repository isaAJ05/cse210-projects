using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int next = -1;
        while (next != 0)
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            int number = int.Parse(answer);
            
            if (number == 0)
            {
                next = 0;
            }
        }
    }
}