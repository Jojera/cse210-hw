using System;

class Program
{
    static void Main(string[] args)
    {
        // core requirement 1
        // Console.Write("What is your magic number? ");
        // string userInput = Console.ReadLine();
        // int magicNumber = int.Parse(userInput);

        // core requirement 3
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        // core requiremnent 2
        int guess = 0;
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }    
    }
}