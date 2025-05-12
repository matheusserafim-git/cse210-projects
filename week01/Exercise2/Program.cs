using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter with your Score: ");
        string userImput = Console.ReadLine();
        float number = float.Parse(userImput);

        if (number >= 90)
        {
            Console.WriteLine("A");
        }

        else if (number >= 80)
        {
            Console.WriteLine("B");
        }

        else if (number >= 70)
        {
            Console.WriteLine("C");
        }

        else if (number >= 60)
        {
            Console.WriteLine("D");
        }
        
        else 
        {
            Console.WriteLine("F");
        }

        if (number >= 70)
        {
            Console.WriteLine("Congrats, you are approved");
        }

        else
        {
            Console.WriteLine("sorry, you failed, keep trying hard");
        }
    }
}