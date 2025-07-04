using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
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
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        float average = sum / numbers.Count;
        int max = numbers.Max();
        
        Console.WriteLine($"The sum is {sum}")
    }
}