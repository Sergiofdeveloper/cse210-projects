using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //instance for Scripture passing as arguments the Reference and the text
        Scripture scripture = new Scripture("Matthew 7:7-8", "\n7- Ask, and it shall be given you; seek, and ye shall find; knock, and it shall be opened unto you. \n8- For every one that asketh receiveth; and he that seeketh findeth; and to him that knocketh it shall be opened.");
        Console.WriteLine("Press enter to hide a word or type 'quit' to finish.");
        
        //Keeps hidding words until user quits or everthinghidden function breaks the loop
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "quit")
                break;

            Console.Clear();
            // instance of Scripture to call the function that hides a random word
            scripture.HideWord();
            //instance of Scripture to call the function GetScripture that prints the actual scripture
            Console.WriteLine(scripture.GetScripture());

            if (scripture.everythingHidden())
                break;
        }
    }
}