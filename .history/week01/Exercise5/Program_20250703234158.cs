using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        Console.Write("Please enter your favorite number: ");
        String answer = Console.ReadLine();
        int number = int.Parse(answer);
        DisplayResult(name, SquareNumber(number));
        
    }
}