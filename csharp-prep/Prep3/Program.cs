class Program
{
    static void Main(string[] args)
    {
        
       Random randomGenerator = new Random(); 
       int number = randomGenerator.Next (1,11); 
        int guess= 1; 

        while (number != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (number > guess)
            {
                Console.WriteLine("Higer");
            }
            else if (number < guess)
            {
                Console.WriteLine("lower");
            }
            else            
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }  
}