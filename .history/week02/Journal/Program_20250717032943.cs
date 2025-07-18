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
            string option = Console.ReadLine();
            int number = int.Parse(option);
            Journal journal = new Journal();
            Entry entry = new Entry();

            if (number == 1)
            {
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();
                PromptGenerator prompt = new PromptGenerator();
                entry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
            }
            if (number == 2)
            {

                journal.DisplayAll();
                Console.WriteLine("hola");
            }
            if (number == 3)
            {
                Console.WriteLine("What is the filename? ");
                journal.LoadFromFile(Console.ReadLine());
            }
            if (number == 4)
            {
                Console.WriteLine("What is the filename? ");
                journal.SaveToFile(Console.ReadLine());
            }
            if (number == 5)
            {
                next = 0;
            }
        }
        
    }
}