using System;
using System.Threading;

public class Activity
{
    public string _name { get; set; }
    protected string _description { get; set; }
    protected int _duration { get; set; } // Duration in minutes


    public Activity(string name, string description, int duration)
    {

        _name = name;
        _description = description;
        _duration = duration;


    }


    public virtual void Run()
    {

    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
        Console.WriteLine($"This activity will last for {_duration} seconds.");
        Console.WriteLine("Get ready to begin!");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Thank you for participating in the {_name} activity!");
        Console.WriteLine("We hope you enjoyed it, and see you again soon.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

        Console.Write("-");

        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the - character
        //ShowSpinner(3);
        //Console.Write("\b \b"); // Erase the + character
        //Console.Write("-");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"\r{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the previous time
        }
        //Console.Write("\b\b");
        //Console.WriteLine("\rTime's up! ");
        //Console.Write("+");

        //ShowCountDown(5);
    }
}