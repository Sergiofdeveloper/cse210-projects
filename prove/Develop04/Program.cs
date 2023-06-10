using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("Please select a choice from the menu");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        
        //shows the user´s choice
        int choice = int.Parse(Console.ReadLine()); 
        // stores the selected activity
        MindfulnessActivity activity = null;  

        // depending on the choice creates a new instance
        if (choice == 1)
        {
            activity = new BreathingActivity();
        }
        else if (choice == 2)
        {
            activity = new ReflectionActivity();
        }
        else if (choice == 3)
        {
            activity = new ListingActivity();
        }
        else if (choice == 4)
        {
            return;
        }
        else
        {
            Console.WriteLine("Wrong choice. Try again");
            return;
        }

        Console.WriteLine("Welcome to this Mindfulnes program");
        Console.WriteLine();

        //begins the selected activity
        activity.Start();
        
    }
}
