using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the your grade percentage, please: ");
        string grade = Console.ReadLine();

        float score = Convert.ToSingle(grade);

        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");
        if (score >= 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else
        {
            
        }
    }
}