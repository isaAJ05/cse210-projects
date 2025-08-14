using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running r1 = new Running("Running", new DateTime(2025, 5, 24), 30, 5);
        activities.Add(r1);

        Cycling c1 = new Cycling(new DateTime(2025, 11, 18), 45, 20);
        activities.Add(c1);

        Swimming s1 = new Swimming(new DateTime(2025, 6, 18), 60, 40);
        activities.Add(s1);

        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }
    }
}