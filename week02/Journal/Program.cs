using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        //add prompts for promptgenerator
        promptGenerator._prompts.Add("How am i fell today?");
        promptGenerator._prompts.Add("what was the best par in my day?");
        promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today?");
        promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be?");
        promptGenerator._prompts.Add("Who was the most interesting person I interacted with today?");


        bool running = true;


        while (running)
        {
            Console.WriteLine("1. New entry");
            Console.WriteLine("2. Show all");
            Console.WriteLine("3. save file");
            Console.WriteLine("4. load file");
            Console.WriteLine("5. Exit");
            Console.Write("chose a option:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int numero))
            {
                switch (numero)
                {
                    case 1:
                        Entry entry = new Entry();
                        entry._date = DateTime.Now.ToShortDateString();
                        //get randon prompt
                        entry._promptText = promptGenerator.GetRandomPrompt();
                        Console.Write($"Prompt:{entry._promptText}");
                        Console.WriteLine("Your Entry:");
                        entry._entryText = Console.ReadLine();
                        journal.AddEntry(entry);
                        break;
                    case 2:
                        journal.DisplayAll();
                        break;
                    case 3:
                        journal.saveToFile("Journal.txt");
                        Console.WriteLine("saved successfully!");
                        break;
                    case 4:
                        journal.loadFromFile("Journal.txt");
                        Console.WriteLine("Louded successfully");
                        break;
                    case 5:
                        running = false;
                        break;

                }
            }
            else
            {
                Console.WriteLine("Valor inválido, por favor digite um número inteiro.");
            }
            
            Console.WriteLine();
        }
    }
}