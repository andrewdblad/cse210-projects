
class SwimmingActivity : Activity
{
    private int _lap = 0;

    public SwimmingActivity(string date, int minutes, int lap) : base(date, minutes)
    {
        _lap = lap;
    }

    public override double GetDistance()
    {
        return _lap * 50 / 1000 * 0.62;
    }
    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
    public override double GetSpeed()
    {
        return 60 / GetPace(); 
    }
    public override string GetSummary()
    {
        string summary = $"{_date} Swimming ({_minutes} mins: {Math.Round(GetDistance(), 2)} miles, Speed: {GetSpeed()} mph, Pace: {Math.Round(GetPace(), 2)} min per mile)";
        return summary;
    }
}