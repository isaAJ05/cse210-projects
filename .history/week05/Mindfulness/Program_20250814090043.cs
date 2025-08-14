using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflection Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Run();
                break;
            case "2":
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "Reflect on your day", 5);
                reflectionActivity.Run();
                break;
            case "3":
                // ListingActivity listingActivity = new ListingActivity("Listing Activity", "List your thoughts", 5);
                // listingActivity.Run();
                Console.WriteLine("Listing Activity is not implemented yet.");
                break;
            case "4":
                Console.WriteLine("Quitting the program.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}