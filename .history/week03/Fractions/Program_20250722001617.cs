using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction fraction_1 = new Fraction();
        Fraction fraction_2 = new Fraction(6);
        Fraction fraction_3 = new Fraction(6, 7);
        Console.WriteLine(fraction_1.GetTop());
        Console.WriteLine(fraction_1.GetBottom());
        Console.WriteLine(fraction_1.GetFractionString();
        Console.WriteLine(fraction_1.GetDecimalValue();
        fraction_1.SetTop(5);
        fraction_1.SetBottom(6);
        Console.WriteLine(fraction_1.GetFractionString();
        Console.WriteLine(fraction_1.GetDecimalValue();

        
    }
}