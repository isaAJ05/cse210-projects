using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
    }
}