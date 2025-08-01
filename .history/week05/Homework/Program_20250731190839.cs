using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
    }
}