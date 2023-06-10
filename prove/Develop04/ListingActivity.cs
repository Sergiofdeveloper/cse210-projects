using System;

class ListingActivity : MindfulnessActivity  
{
    // override allows to change the inherited behavior
    protected override string GetDescription()  
    {
        return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    // prompts store arrays of questions for the user
    private string[] prompts =  
    {
        "--- Who are the people that you appreciate? ---",
        "--- What are your personal strengths? ---",
        "--- Who are the people that you have helped this week? ---",
        "--- When have you felt the Holy Ghost this month? ---",
        "--- Who are some of your personal heroes? ---"
    };

    // overrides start 
    public override void Start()  
    {
        
        // calls method Start from base 
        base.Start();  

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("Type done when you are finish");
        string prompt = prompts[new Random().Next(prompts.Length)]; // use random to select a new prompt each time
        Console.WriteLine(prompt); // the random prompt its displayed
        Console.WriteLine("You may begin in:");
        Pause(5);

        string item; //stores user answers
        int itemCount = 0;  //start on 0 to count the number of answers

        for (; itemCount < duration; itemCount++)
        {
            item = Console.ReadLine();
            if (item.ToLower() == "done") // ToLower to returns lowercase
            {
            break; // when done its typed loop ends
            }
            
        }
        //displays number of items entered by user
        Console.WriteLine($"You have listed {itemCount} items."); 
        Finish();
    }
}