
class RunningActivity : Activity
{
    private double _distance = 0.0;

    public RunningActivity(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return _minutes / _distance;
    }
    public override double GetSpeed()
    {
        return 60 / GetPace(); 
    }
    public override string GetSummary()
    {
        string summary = $"{_date} Running ({_minutes} mins: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {Math.Round(GetPace(), 2)} min per mile)";
        return summary;
    }
}