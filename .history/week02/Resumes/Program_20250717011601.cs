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
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Accountant";
        job2._company = "Juliao Family";
        job2._startYear = 2015;
        job2._endYear = 2025;
        job2.DisplayJobDetails();

        Resume resume1 = new Resume()

    }
}