using System;

abstract class Goal
{
    protected int _point = 0;
    protected string _name = "";
    protected string _description = "";
    protected char _identifierSep = ':';
    protected char _dataSep = '|';

    public Goal() { }

    public string GetName()
    {
        return _name;
    }
    public void DisplayGetName()
    {
        Console.Clear();
        Console.Write("What is the name of your goal?: ");
        _name = Console.ReadLine();
    }
    public void DisplayGetDescription()
    {
        Console.Write("What is a short description of your goal?: ");
        _description = Console.ReadLine();
    }
    public void DisplayGetPoints()
    {
        Console.Write("What is the amount of points associated with this goal?: ");
        _point = Convert.ToInt32(Console.ReadLine());
    }
    public abstract void HandleStringRep(string rep);
    public abstract string GetStringRepresentation();
    public abstract void Display();
    public abstract void DisplayName();
    public abstract void MarkAsComplete();
    public abstract bool CheckIfComplete();
    public abstract int GetPoints();
    public virtual int GetCompletedTimes()
    {
        return 0;
    }

    public int GetChecklistPoint()
    {
        return _point;
    }

}