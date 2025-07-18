using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int next = -1;
        while (next != 0)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
            int number = int.Parse(answer);

            if (number == 1)
            {
                PromptGenerator prompt = new PromptGenerator();
                prompt.GetRandomPrompt();
            }
            else if (number == 2)
            {

            }
            else if (number == 3)
            {

            }
            else if (number == 4)
            {

            }
            else if (number == 5)
            {
                next = 0;
            }
            else
            {
                Console.WriteLine("(!) invalid option");
                Console.WriteLine("Please try again.");
                Console.WriteLine(" ");
            }
        }
        
    }
}