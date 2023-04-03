
abstract class Activity
{
    
    protected string _date = "";
    protected int _minutes = 0;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace(); 
    public abstract string GetSummary();
}