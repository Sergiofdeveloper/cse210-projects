using System;
using System.IO; // need these to read and write files in c#

class UserEntry {   // in this class we set the configuration of the different methods. 

    public PromptGenerator promptGenerator = new PromptGenerator(); // new instance from class PromtGenerator, variable promptGenerator

    public void AddEntry()
    {
        
        DateTime theCurrentTime = DateTime.Now;  //stores day and time
        string dateText = theCurrentTime.ToShortDateString(); // saves the date in the variable dateText in a short format

        Random r = new Random();  // instance for Random
        int index = r.Next(promptGenerator.promptIdeas.Count);  // we use r.Next to get random number within the list
        string randomPrompt = promptGenerator.promptIdeas[index]; // get a randow sentence from the list and store it in the variable randomPrompt
        Console.WriteLine(randomPrompt);
        

       Console.Write("Enter your text: ");  
       string entry = Console.ReadLine();  
       string entryDate = $" Date: {dateText}: - Prompt: {entry}"; // shows date + user entry
       promptGenerator.entries.Add(entryDate);// adds this user journal entry to the list entries found in PromptGenerator
    
        }

    public void Display()
    {
        foreach (string entry in promptGenerator.entries)  // iterate through the list of entries and displays them
        {
            Console.WriteLine(entry);
        }
    }

    public void Load()
    {

    }

    public void Save()
    {

    }
}

