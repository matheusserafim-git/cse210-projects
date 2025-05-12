using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int userInput = 0;

        while (userInput != number)
        {
            Console.WriteLine("what is your guess?");
            string user = Console.ReadLine();
            userInput = int.Parse(user);        
        
        
            if (userInput > number)
            {
                Console.WriteLine("Lower");
            }

            else if (userInput == number)
            {
                Console.WriteLine("You guessed it");
            }

            else
            {
                Console.WriteLine("Highter");
            }
        }    
    }
}