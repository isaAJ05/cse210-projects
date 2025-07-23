using System;
using System.ComponentModel;

/*
Program: Journal Program 
Author: Isabella Arrieta
Purpose: write a program to help people record the events of their day by supplying prompts 
and then saving their responses along with the question and the date to a file.
Additional Feature: A new field called "mood" was added. The user can enter their mood 
by selecting a number from 1 to 5. The mood is tracked along with the time.
All classes were modified to include the _mood attribute.

**/
class Program
{
    static void Main(string[] args)
    {
        List
        Reference reference = new Reference("2 Nephi", 2, 24, 25);
        Scripture scripture = new Scripture(reference, "But behold, all things have been done in the wisdom of him who knoweth all things. Adam fell that men might be; and men are, that they might have joy.");
        Console.WriteLine(scripture.GetDisplayText());
        string aux = "";
        while (aux != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            aux = Console.ReadLine();
            Console.Clear();
            Random random = new Random();
            scripture.HideRandomWords(random.Next(1,10 ));
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}