public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"You earned {Points} points.");
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
    }
}