using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        // create a list
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter Number: ");
            string response = Console.ReadLine();
            number = int.Parse(response);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // sum the numbers in the list
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // calculate the average
        float avg =  ((float) sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        // find the largest number
        if (numbers.Count > 0)
        {
            int largest = numbers[0]; 
            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            Console.WriteLine($"The largest number is: {largest}");
        }   
    }
}