using System;
using System.ComponentModel;

/*
Program: Scripture Memorizer
Author: Isabella Arrieta
Purpose: People often try to memorize poems or passages of scripture. One of the challenges they encounter is that they want to hide the scripture 
while they are practicing, but they may not be able to recite the whole scripture from memory just yet.
To help solve this problem so that people can better memorize a scripture, write a program that displays the full scripture and then hides 
a few words at a time until the complete scripture is hidden.
Additional Feature: Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.

**/
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> _scriptures = new List<Scripture>();
        string[] lines = System.IO.File.ReadAllLines("scriptures.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Reference reference = new Reference();

            if (parts.Length == 3)
            {
                reference.SetBook(parts[0]);
                reference.SetChapter(int.Parse(parts[1]));
                reference.SetVerse(int.Parse(parts[2]));
                _scriptures(reference,parts[3]);
            }
            else if (parts.Length == 4)
            {
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                entry._mood = parts[3];
                AddEntry(entry);
            }
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