using System;

class Program
{
    static void Main(string[] args)
    {   
        // core requirement 1 and 3
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        

        string letter = "";

        if (percentage >= 90)
        {
            letter ="A";
        }
        else if (percentage >= 80)
        {
            letter ="B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Grade: {letter}");

        // core requirement 2
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed.");
        }
        else
        {
            Console.WriteLine("Please work harder next time.");
        }

    }
}