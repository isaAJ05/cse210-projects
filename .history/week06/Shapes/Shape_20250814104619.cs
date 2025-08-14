using System;
public class Shape
{
    public string Name { get; set; }
    public double Area { get; set; }

    public Shape(string name, double area)
    {
        Name = name;
        Area = area;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Shape: {Name}, Area: {Area}");
    }
}