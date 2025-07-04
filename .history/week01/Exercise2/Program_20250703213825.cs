using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the grade score: ");
        string grade = Console.ReadLine();

        float score = Convert.ToSingle(grade);

        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }
    }
}