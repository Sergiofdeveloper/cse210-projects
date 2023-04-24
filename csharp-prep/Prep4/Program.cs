using System;
using System.Collections.Generic; //first we add the library

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();  // we create a list
        int newNumber= 1;   // value for the variable

        while (newNumber != 0)  // start the while loop
        {
            Console.Write("Enter a number (0 to quit): ");  // create the input for the user to insert the number
            string userNumber = Console.ReadLine(); //give a variable for the input and make it readable
            newNumber = int.Parse(userNumber);  // convert into number

            if (newNumber != 0)  // if the number its different from 0
                {
                    numbers.Add(newNumber);  // keep adding numbers
                }
        }

        int sum = 0; // new variable for the sum
        foreach (int number in numbers) // iterate through the list
        {
            sum += number;  // sum all the numbers
        }
        Console.WriteLine($"The sum is: {sum}");  // print the sum

        int average = sum / numbers.Count; // new variable for average. use list.Count to know the size of the list
        Console.WriteLine($"The average is: {average}");  // print the average

        Console.WriteLine("The largest number is: " + numbers.Max());  // print the largest number

    }
}