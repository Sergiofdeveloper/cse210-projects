using System;

class Program
{
    static void Main()
    {
        Fraction fraction1 = new Fraction();            
        Fraction fraction2 = new Fraction(2);           
        Fraction fraction3 = new Fraction(3, 4);        

        Console.WriteLine($"{fraction1.GetFraction()}, {fraction1.DecimalValue()}");
        Console.WriteLine($"{fraction2.GetFraction()},  {fraction2.DecimalValue()}");
        Console.WriteLine($" {fraction3.GetFraction()},  {fraction3.DecimalValue()}");
        // Change the values using setters
        fraction1.SetNumerador(2);
        fraction1.SetDenominador(3);

        Console.WriteLine($"{fraction1.GetFraction()},  {fraction1.DecimalValue()}");

        Console.ReadLine();
    }
}