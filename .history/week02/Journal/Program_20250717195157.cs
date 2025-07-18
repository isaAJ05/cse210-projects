using System;

/*
Program: Journal Program 
Author: Isabella Arrieta
Purpose: write a program to help people record the events of their day by supplying prompts 
and then saving their responses along with the question and the date to a file.
Addition: 

**/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int next = -1;
        Journal journal = new Journal();
        while (next != 0)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();
            int number = int.Parse(option);

            if (number == 1)
            {
                Entry entry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();
                PromptGenerator prompt = new PromptGenerator();
                entry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                Console.WriteLine("Do you want to Track your Mood Right Now? Y/N");
                String ans = Console.ReadLine();
                while (ans != "Y" || ans != "N")
                {
                    Console.WriteLine("(!)Invalid option please try again");
                    Console.WriteLine("Do you want to Track your Mood Right Now? Y/N");
                    ans = Console.ReadLine();
                }
                    Console.Write("From 1 to 5 how do you feel?: ");
                    entry._mood = "Scale: " + Console.ReadLine() + "Time: " + theCurrentTime.ToString("HH:mm:ss");
                }if (ans = "Y" 
                else if (ans == "N")
                {
                    journal.AddEntry(entry);
                }
                
            }
            else if (number == 2)
            {

                journal.DisplayAll();
            }
            else if (number == 3)
            {
                Console.WriteLine("What is the filename? ");
                journal.LoadFromFile(Console.ReadLine());
            }
            else if (number == 4)
            {
                Console.WriteLine("What is the filename? ");
                journal.SaveToFile(Console.ReadLine());
            }
            else if (number == 5)
            {
                
                next = 0;
            }
            else
            {
                Console.WriteLine("(!) invalid option");
                Console.WriteLine("Please try again.");
            }
        }

    }
}