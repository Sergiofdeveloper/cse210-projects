using System;
using System.Collections.Generic; // importa los nombre de las listas
using System.IO;

class UserEntry   // in this class we set the actions of the menu 
{  
    public PromptGenerator promptGenerator = new PromptGenerator(); // new instance from class PromtGenerator
    public List<string> entries = new List<string>();
    public void AddEntry()
    {
        
        DateTime theCurrentTime = DateTime.Now;  //stores day and time. Copy and paste from the excercise
        string dateText = theCurrentTime.ToShortDateString(); // saves the date in the variable dateText in a short format

        Random random = new Random();  // instance for Random
        int index = random.Next(promptGenerator.promptIdeas.Count);  //random.Next gets random number within the list. Count converts the list into a serie of numbers
        string randomPrompt = promptGenerator.promptIdeas[index]; // get a random sentence from the list and store it in the variable randomPrompt
        Console.WriteLine(randomPrompt);
        
        Console.Write("Enter your text: ");  
        string entry = Console.ReadLine();  
        string entryDate = $" Date: {dateText}: - Prompt: {entry}"; // shows date + user entry
        entries.Add(entryDate);
        Console.WriteLine("Your entry has been saved")
       ;
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
        Console.WriteLine("Enter the name of your file: ");
        string fileName = Console.ReadLine(); 
        LoadJournal(fileName);
    }

    public void Save()
    {
        Console.WriteLine("Enter the name of your file: ");
        string fileName = Console.ReadLine();
        SaveJournal(fileName);
    }
    
    public void SaveJournal(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName)) // nueva instancia de StreamWriter
        {
            foreach (string entry in entries)
            {
                writer.WriteLine(entry);
            }
        }

        Console.WriteLine($"Entry saved in file: {fileName}");
    }
    
    public void LoadJournal(string fileName)
    {
        if (File.Exists(fileName))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;  // new variable to store each line
                while ((line = reader.ReadLine()) !=null)  // loop to read every line in reader. exits loop if null
                {
                    entries.Add(line); //every entry get added to the list
                }   

        }

        Console.WriteLine($"Journal loaded from file: {fileName}");
    }
    else
    {
        Console.WriteLine("File not found");
    }
   }
}

