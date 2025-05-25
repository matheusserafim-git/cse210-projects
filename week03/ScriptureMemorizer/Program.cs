using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {   
        // the library to save differents scriptures and can be use randonly
        List<Scripture> library = new List<Scripture>();
        library.Add(new Scripture(new Reference("Psalm", 23, 1),
        "The Lord is my shepherd; I shall not want."));
        

        library.Add(new Scripture(new Reference("1 Nephi", 3, 7),
        "7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
        ));

        library.Add(new Scripture(new Reference("john", 3, 16), 
            "For God so loved the world that he gave his only begotten Son, that whoever believes in him should not perish but have everlasting life."
        ));

        Random rand = new Random();
        Scripture scripture = library[rand.Next(library.Count)];


        //Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            //to clear the console
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press 'enter' to continue or type 'quit' to finish");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
                break;

            //ocult three random words
            scripture.HideRandomWords(3);



            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\n All words are hidden!");
                break;
            }

        }
       

    }

}