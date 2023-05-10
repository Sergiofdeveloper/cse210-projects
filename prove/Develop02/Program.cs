using System;
using System.IO;  // need these to read and write files in c#
class Program
{
    static void Main(string[] args)
    {
        UserEntry userEntry = new UserEntry(); // we create an instance for UserEntry
      
        while (true) // start the loop until we quit
        {
            Console.WriteLine ("Welcome to the Journal Program");
            Console.WriteLine ("Please select one of the following choices: ");
            Console.WriteLine("1- Add Entry");
            Console.WriteLine("2- Display");
            Console.WriteLine("3- Load");
            Console.WriteLine("4- Save");
            Console.WriteLine("5- Quit");
            Console.Write("What would you like to do? ");
            
            string selection = Console.ReadLine();

            if (selection == "1")
                {
                    userEntry.AddEntry();
                }   
            else if (selection == "2")
                {
                    userEntry.Display();
                }
            else if (selection == "3")
                {
                userEntry.Load();
                }
            else if (selection == "4")
                {
                userEntry.Save();
                }
            else
                {
                break;
            }


       }
   
    }
}


// https://www.techiedelight.com/es/access-random-item-in-list-in-csharp/
//https://es.stackoverflow.com
//https://www.discoduroderoer.es/generar-numeros-aleatorios-con-c-sharp/