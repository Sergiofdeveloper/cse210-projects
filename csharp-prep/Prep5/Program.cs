using System;

class Program
{
    static void greeting()
        {
          Console.WriteLine("Welcome to the Program!");
        }
    static string UserName ()
       {
         Console.Write("Please enter your name: ");
         string InputName = Console.ReadLine();
         return InputName;
      }   

    static int UserNumber ()
       {
         Console.Write("Please enter your favorite number: ");
         int InputNumber = int.Parse (Console.ReadLine());
         return InputNumber;
      }

      static int SquareNumber(int InputNumber)
      {
        int Square = InputNumber * InputNumber;
        return Square;

      }
      static void TotalNumber(string InputName, int Square)
      {
        Console.WriteLine($"{InputName}, the square of your number is {Square}");
      } 


    static void Main(string[] args)
    {
          greeting();
          string Name = UserName();
          int Number = UserNumber();
          int Square = SquareNumber(Number); 
          TotalNumber(Name, Square);
        
    }
}