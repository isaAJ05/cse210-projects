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
        List<Scripture> _scriptures = new List<Scripture>();//List of scriptures
        string[] lines = System.IO.File.ReadAllLines("scriptures.txt"); //read the file
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");// each value is separated by "|"
            Reference reference = new Reference();
            if (parts.Length == 4) // without endverse
            {
                reference.SetBook(parts[0]);
                reference.SetChapter(int.Parse(parts[1]));
                reference.SetVerse(int.Parse(parts[2]));
                Scripture s = new Scripture(reference, parts[3]);
                _scriptures.Add(s); // add to our list
            }
            else if (parts.Length == 5) // // with endverse
            {
                reference.SetBook(parts[0]);
                reference.SetChapter(int.Parse(parts[1]));
                reference.SetVerse(int.Parse(parts[2]));
                reference.SetEndVerse(int.Parse(parts[3]));
                Scripture s = new Scripture(reference, parts[4]);
                _scriptures.Add(s); // add to our list
            }
        }
        int count = 0;
        foreach (Scripture s in _scriptures)
        {
            count += 1;// count the length of 
        }
        Random random1 = new Random();
        Scripture scripture = new Scripture();
        scripture = _scriptures[random1.Next(0,count)];

        Console.WriteLine(scripture.GetDisplayText());
        string aux = "";
        while (aux != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            aux = Console.ReadLine();
            Console.Clear();
            Random random2 = new Random();
            scripture.HideRandomWords(random2.Next(1,10 ));
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}