using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Save Goals");
            Console.WriteLine("8. Load Goals");
            Console.WriteLine("9. Quit");

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": DisplayPlayerInfo(); break;
                case "2": ListGoalNames(); break;
                case "3": ListGoalDetails(); break;
                case "4": CreateGoal(); break;
                case "5": RecordEvent(); break;
                case "6": DisplayScore(); break;
                case "7": SaveGoals(); break;
                case "8": LoadGoals(); break;
                case "9": running = false; break;
            }
        }
    }

    // Creativity
    public int GetLevel()
    {
        return (_score / 1000) + 1; 
    }

    // Creativity
    public void DisplayScore()
    {
        Console.WriteLine($"\nYour current score is: {_score}");
        Console.WriteLine($"Your current level is: {GetLevel()}");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYour current score is: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetType().Name} - {_goals[i].GetStringRepresentation().Split('|')[1]}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            if (_goals[i] is ChecklistGoal checklist)
            {
                Console.WriteLine($"{i + 1}. {checklist.GetDetailsString()}");
            }
            else if (_goals[i] is SimpleGoal simple)
            {
                string status = simple.IsComplete() ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {status} {simple.GetStringRepresentation().Split('|')[1]} ({simple.GetStringRepresentation().Split('|')[2]})");
            }
            else if (_goals[i] is EternalGoal eternal)
            {
                Console.WriteLine($"{i + 1}. [∞] {eternal.GetStringRepresentation().Split('|')[1]} ({eternal.GetStringRepresentation().Split('|')[2]})");
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. SimpleGoal");
        Console.WriteLine("2. EternalGoal");
        Console.WriteLine("3. ChecklistGoal");

        string choice = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();

            // Add basic points
            int earnedPoints = 0;

            if (_goals[index] is SimpleGoal sg && !sg.IsComplete())
                earnedPoints = sg.GetPoints();
            else if (_goals[index] is EternalGoal eg)
                earnedPoints = eg.GetPoints();
            else if (_goals[index] is ChecklistGoal cg)
            {
                earnedPoints = cg.GetPoints();
                if (cg.IsComplete() && cg.GetAmountCompleted() == cg.GetTarget())
                {
                    earnedPoints += cg.GetBonus();
                }
            }
            _score += earnedPoints;
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved to file.");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No save file found.");
            return;
        }

        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    var sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4])) sg.RecordEvent();
                    _goals.Add(sg);
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    var cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    int completed = int.Parse(parts[6]);
                    for (int j = 0; j < completed; j++) cg.RecordEvent();
                    _goals.Add(cg);
                    break;
            }
        }

        Console.WriteLine("Goals loaded from file.");
    }
}
