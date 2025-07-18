using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int next = -1;
        while (next != 0)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Write");
            Console.WriteLine("5. Write");
            Console.Write("Please select one of the following choices: ");
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