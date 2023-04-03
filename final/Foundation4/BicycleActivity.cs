class BicycleActivity : Activity
{
    private double _distance = 0.0;
    private double _speed = 0.0;

    public BicycleActivity(string date, int minutes,double distance, double speed) : base(date, minutes)
    {
        _distance = distance;
        _speed = speed;
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
        return _speed;
    }
    public override string GetSummary()
    {
        string summary = $"{_date} Stationary Bicycle ({_minutes} mins: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {Math.Round(GetPace(), 2)} min per mile)";
        return summary;
    }
}