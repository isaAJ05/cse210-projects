using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment matty = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(matty.GetSummary());
        Console.WriteLine(matty.GetHomeworkList());
        Console.WriteLine("");
        WritingAssignment readito = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(readito.GetSummary());
        Console.WriteLine(readito.GetWritingInformation());
    }
}