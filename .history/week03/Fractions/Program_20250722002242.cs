using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction fraction_1 = new Fraction();
        Console.WriteLine(fraction_1.GetFractionString());
        Console.WriteLine(fraction_1.GetDecimalValue());
        Fraction fraction_2 = new Fraction(6);
        Console.WriteLine(fraction_2.GetFractionString());
        Console.WriteLine(fraction_2.GetDecimalValue());
        Fraction fraction_3 = new Fraction(6, 7);
        Console.WriteLine(fraction_3.GetFractionString());
        Console.WriteLine(fraction_3.GetDecimalValue());

        
    }
}