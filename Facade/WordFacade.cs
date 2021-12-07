using System;
using System.Collections.Generic;

namespace Assignment2.Facade
{
    public class WordFacade
    {
        public List<string> Chars { get; set; }

        public WordFacade()
        {
            Chars = new();
        }

        public void SaveWord()
        {
            Console.WriteLine("Enter 5 letters... no more, no less!");
            string input = Console.ReadLine();
            if (input.Length != 5)
            {
                Console.WriteLine("Exiting program - Error - The string needs to be EXACTLY 5 characters long");
                Console.ReadKey(true);
            }
            else
            {
                Chars.Add(input);
            }
        }

        public void LoadWord()
        {
            if (Chars.Count > 0)
            {
                foreach (var savedChars in Chars)
                    Console.WriteLine(savedChars);
            }

            Console.WriteLine("The process is completed.");
        }
    }
}