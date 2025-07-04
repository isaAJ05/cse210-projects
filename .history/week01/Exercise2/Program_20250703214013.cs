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
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 80)
        {
            letter = "B";

        }
    }
}