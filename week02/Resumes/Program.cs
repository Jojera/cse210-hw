using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2004;
        job1._endYear= 2008;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2020;
        job2._endYear= 2024;

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._name = "Jonathan Ojera";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    } 
}