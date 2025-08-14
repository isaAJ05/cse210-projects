using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running r1 = new Running(new DateTime(2025, , 1), 30, 5.0);
        activities.Add(r1);

        Cycling c1 = new Cycling(new DateTime(2025, 10, 2), 45, 20.0);
        activities.Add(c1);

        Swimming s1 = new Swimming(new DateTime(2025, 10, 3), 60, 40.0);
        activities.Add(s1);
    }
}