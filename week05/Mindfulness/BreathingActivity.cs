using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();
        int interval = 6;
        int duration = Duration;
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountDown(3);
            Console.WriteLine();

            elapsed += interval;
        }

        DisplayEndingMessage();
        ShowMotivationalQuote();
    }
}