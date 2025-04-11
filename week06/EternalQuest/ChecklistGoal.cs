public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int GetBonus() => _bonus;
    public int GetAmountCompleted() => _amountCompleted;
    public int GetTarget() => _target;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        int totalPoints = Points;

        if (_amountCompleted == _target)
        {
            totalPoints += _bonus;
            Console.WriteLine($"You completed the checklist and earned a bonus of {_bonus} points!");
        }

        Console.WriteLine($"You earned {totalPoints} points.");
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {Name} ({Description}) -- Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}