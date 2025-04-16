using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running run = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        activities.Add(run);

        Cycling cycle = new Cycling(new DateTime(2023, 10, 2), 45, 9.7);
        activities.Add(cycle);

        Swimming swim = new Swimming(new DateTime(2023, 10, 3), 60, 30);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();

            Console.WriteLine($"{summary}");
        }
    }
}