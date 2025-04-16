using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int length, int laps) : base (date, length)
    {
        _laps = laps;
    }

    public override double GetDistanceKm()
    {
        return _laps * 0.05;
    }

    public override double GetSpeed()
    {
        return (GetDistanceKm() / GetLength()) * 60.0;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistanceKm();
    }
}

