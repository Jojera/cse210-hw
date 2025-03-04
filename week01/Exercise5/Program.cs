using System;

class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcome();

        string name = PromptUserName();

        int favNumber = PromptUserNumber();

        int square = SquareNumber(favNumber);

        DisplayResult(name, square);
    }    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the prorgram.");
    }   

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string fullName = Console.ReadLine();
        return fullName;
    } 

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine()); 
        return number;
    }

    static int SquareNumber(int number)
    {
        int sqNumber = number * number;
        return sqNumber; 
    }

    static void DisplayResult(string fullName, int sqNumber)
    {
        Console.WriteLine($"{fullName}, the square of your number is {sqNumber}");
    }


    
}