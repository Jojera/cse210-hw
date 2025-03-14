// Author, Brother Jonathan.
// For creativity, I added a "DeleteEntry" method to drop unwanted entries in case the user wants to 
// get rid of them.


using System;


class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;
        Console.WriteLine("Welcome to the Journal Program!");

        while (running)
        {
            Console.WriteLine("Please select one of the following options.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Delete Entry");
            Console.WriteLine("6. Quit");

            Console.Write("Choose what you want to do: ");
            string choice = Console.ReadLine();
    

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("dd/MM/yyyy");

                    Entry newEntry = new Entry(date, prompt, response);
                    myJournal.AddEntry(newEntry);
                    Console.WriteLine();
                    break;
                
                case "2":
                    myJournal.DisplayAll();
                    Console.WriteLine();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string saved = Console.ReadLine();
                    myJournal.SaveToFile(saved);
                    Console.WriteLine();
                    break;

                case "4":
                    Console.Write("What file is to be loaded? ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    Console.WriteLine();
                    break;

                // Case 5 is creativity
                case "5":
                    Console.WriteLine("Select an entry to delete:");
                    myJournal.DisplayAll();
                    Console.Write("Enter the entry number to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        myJournal.DeleteEntry(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                    Console.WriteLine();
                    break;   

                case "6":
                    Console.WriteLine("Thank you, bye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try again.");
                    break;
            }
        }
    }
}