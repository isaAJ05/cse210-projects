using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine()
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
        Double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");
    }
    }
}