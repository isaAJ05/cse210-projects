using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Stark Industries";
        job1._startYear = 2020;
        job1._endYear = 2025;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Stark Industries";
        job2._startYear = 2020;
        job2._endYear = 2025;
        job2.Display();

    }
}