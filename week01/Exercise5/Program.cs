using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(squareNumber, UserName);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            string Number = Console.ReadLine();
            int userNumber = int.Parse(Number);
            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int square = userNumber * userNumber;
            return square;
        }

        static void DisplayResult(int squareNumber, string userName)
        {
            Console.WriteLine($"{userName}, the square of your number is: {squareNumber}");
            return;
        }
        
    }
}