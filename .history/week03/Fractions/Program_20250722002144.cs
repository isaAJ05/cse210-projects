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
            Console.WriteLine(fraction_1.GetFractionString());
        Console.WriteLine(fraction_1.GetDecimalValue());
        Fraction fraction_3 = new Fraction(6, 7);

        fraction_1.SetTop(5);
        fraction_1.SetBottom(6);
        Console.WriteLine(fraction_1.GetFractionString());
        Console.WriteLine(fraction_1.GetDecimalValue());

        
    }
}