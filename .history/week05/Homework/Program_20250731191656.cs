using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment matty = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(matty.GetSummary());
        Console.WriteLine(matty.GetHomeworkList());

        MathAssignment matty = new WritingAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(matty.GetSummary());
        Console.WriteLine(matty.GetHomeworkList());
    }
}