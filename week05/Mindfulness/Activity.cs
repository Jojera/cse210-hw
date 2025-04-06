using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public string Name => _name;
    public string Description => _description;
    public int Duration => _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("Enter duration in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int input))
        {
            _duration = input;
        }
        else
        {
            _duration = 30; // default
        }
        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.\n");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
            i++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }


// This is creativity
    public void ShowMotivationalQuote()
    {
        List<string> quotes = new List<string>
        {
            "“Almost everything will work again if you unplug it for a few minutes, including you.” - Anne Lamott",
            "“You are stronger than you think.”",
            "“Breathe. Let go. And remind yourself that this very moment is the only one you know you have for sure.” - Oprah Winfrey",
            "“Don't count the days, make the days count.” - Muhammad Ali",
            "“Your calm mind is the ultimate weapon against your challenges.” - Bryant McGill",
            "“Stillness is where creativity and solutions to problems are found.” - Eckhart Tolle"
        };

        Random rand = new Random();
        string quote = quotes[rand.Next(quotes.Count)];
        Console.WriteLine($"\nMotivational Quote:\n\"{quote}\"\n");

        Console.WriteLine("Take a moment... Press Enter when you're ready to continue.");
        Console.ReadLine();
    }
}