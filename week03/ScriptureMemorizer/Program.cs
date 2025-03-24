// Author Brother Jonathan
// For creativity, I added a "ScriptureLibrary" class which helps my program run with a library of scriptures 
// that are fetched randomly rather than a single one.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nThank you, Bye!.");
    }
}