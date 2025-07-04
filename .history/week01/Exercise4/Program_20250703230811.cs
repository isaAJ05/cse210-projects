using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int next = -1;
        List<int> numbers = new List<int>();
        while (next != 0)
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            int number = int.Parse(answer);

            if (number == 0)
            {
                next = 0;
            }
            else
            {
                numbers.Add(number);
            }
        }
        foreach (int word in words)
            {
                    Console.WriteLine(word);
            }
    }
}