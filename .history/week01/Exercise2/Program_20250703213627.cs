using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the grade score: ");
        string grade = Console.ReadLine();

        float grade_converted = grade.ParseFloat();
    }
}