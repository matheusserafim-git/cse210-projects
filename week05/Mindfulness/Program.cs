using System;
using System.Collections.Generic;

namespace Mindfulness
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");

            // Ask user for duration
            Console.Write("How many seconds do you want for your activity? ");
            int duration;
            while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
            {
                Console.Write("Please enter a valid positive number: ");
            }

            // Prepare activities
            List<Activity> activities = new List<Activity>();

            // ListingActivity
            List<string> listingPrompts = new List<string>
            {
                "Name things you are grateful for.",
                "List people who inspire you.",
                "What are your favorite hobbies?",
                "What makes you smile?"
            };
            activities.Add(new ListingActivity(
                "Listing Activity",
                "This activity helps you reflect on positive things.",
                duration,
                listingPrompts
            ));

            // ReflectionActivity (example prompts and questions)
            List<string> reflectionPrompts = new List<string>
            {
                "Think of a time you overcame a challenge.",
                "Recall a moment you felt truly happy."
            };
            List<string> reflectionQuestions = new List<string>
            {
                "Why was this moment meaningful to you?",
                "What did you learn from this experience?"
            };
            activities.Add(new ReflectionActivity(
                "Reflection Activity",
                "This activity helps you reflect on meaningful moments.",
                duration,
                reflectionPrompts,
                reflectionQuestions
            ));

            // BreathingActivity
            activities.Add(new BreathingActivity(
                "Breathing Activity",
                "This activity will help you relax by guiding you through slow breathing.",
                duration
            ));

            // Show menu
            Console.WriteLine("\nChoose an activity:");
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {activities[i]._name}");
            }
            Console.Write("Enter the number of your choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > activities.Count)
            {
                Console.Write("Please enter a valid option: ");
            }

            // Run chosen activity
            Console.WriteLine($"\nStarting: {activities[choice - 1]._name}\n");
            activities[choice - 1].Run();
        }
    }
}