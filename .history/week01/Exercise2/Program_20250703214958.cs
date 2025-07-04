using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the your grade percentage, please: ");
        string grade = Console.ReadLine();

        float score = Convert.ToSingle(grade);

        string letter = "";
        string sign = "";

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
        else if (score < 60)
        {
            letter = "F";
        }

        if (score / 10 > 7)
        {
            sign = "+";
        }
        else if (score / 10 < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}");
        if (score >= 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else
        {
            Console.WriteLine("You did not passed the course, try it hard nex time!");
        }
    }
}