using System;
using System.Threading; // import to use Thread in a shorter way

class MindfulnessActivity
{   
    // protected allows derived classes access to the variable
    protected int duration;

    // set a initual value for duration
    public MindfulnessActivity()
    {
        duration = 0;
    }
    // shows welcome message, stores time selected by user. Int.Parse turns it into int
    protected void WelcomeMessage(string activityName, string description)
    {
        Console.WriteLine($"You are starting the {activityName}");
        Console.WriteLine(description);
        Console.WriteLine($"How long in seconds, would you like for your session?");  
        duration = int.Parse(Console.ReadLine());    
    }

    // countdown and pause
    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.WriteLine();
        
    }
    // virtual key word allows derived classes to override this method
    public virtual void Start()
    {
        WelcomeMessage(GetType().Name, GetDescription());
        Console.WriteLine("Get ready ...");
        Pause(5);
                
    }
    // shows message at the end of the activity and counts the number of seconds
    public void Finish()
    {
        Console.Write("Activity is ending in...");
        Pause(3);
        Console.WriteLine($"Well done!");
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed another {duration} seconds of this activity.");
    }

    // displays activity description. It´s an empty string that it´s override in derived classes
    protected virtual string GetDescription()
    {
        return "";
    }
}

