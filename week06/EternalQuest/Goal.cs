public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    protected string Name => _name;
    protected string Description => _description;
    protected int Points => _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public int GetPoints() => Points;

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
}