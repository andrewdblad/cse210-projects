using System;

class ChecklistGoal : Goal
{
    private string _objectName = "ChecklistGoal";
    private int _goalTimes = 0;
    private int _completedTimes = 0;
    private int _bonusPoints = 0;
    public ChecklistGoal() : base() {}

    public override int GetPoints()
    {
        return _bonusPoints;
    }
    public void DisplayGetGoalTimes()
    {
        Console.Write("How many times does this goal need to be completed for a bonus?: ");
        _goalTimes = Convert.ToInt32(Console.ReadLine());
    }
    public void DoChecklistGoal()
    {
        this.DisplayGetName();
        this.DisplayGetDescription();
        this.DisplayGetPoints();
        this.DisplayGetGoalTimes();
        this.DisplayGetBonusPoints();
    }
    public void DisplayGetBonusPoints()
    {
        Console.Write("How many bonus points for completion?: ");
        _bonusPoints = Convert.ToInt32(Console.ReadLine());
    }
    public override void Display()
    {
        if(CheckIfComplete() == false)
        {
            Console.WriteLine($"> [ ] {_name} ({_description}) -- Curently completed: {_completedTimes}/{_goalTimes}");
        }
        if(CheckIfComplete() == true)
        {
            Console.WriteLine($"> [X] {_name} ({_description}) -- Curently completed: {_completedTimes}/{_goalTimes}");           
        }
    }
    public override void DisplayName()
    {
        Console.Write($"> {_name}");
    }
    public override void MarkAsComplete()
    {
        _completedTimes = _completedTimes + 1;   
    }
    public override bool CheckIfComplete()
    {
    
        if(_completedTimes == _goalTimes)
        {
            return true;
        }
        else
            return false;
    }
    public override string GetStringRepresentation()
    {
        string rep = _objectName + _identifierSep
                                  + _name 
                                  + _dataSep 
                                  + _description
                                  + _dataSep
                                  + _point.ToString()
                                  + _dataSep
                                  + _bonusPoints.ToString()
                                  + _dataSep
                                  + _goalTimes.ToString()
                                  + _dataSep
                                  + _completedTimes.ToString(); 
            return rep;
    }
    public override void HandleStringRep(string rep)
    {
        char[] seperators = new char[] {_identifierSep, _dataSep};
        string[] parts = rep.Split(seperators);
        if (rep.Contains(_objectName))
        {
            _objectName = parts[0];
            _name = parts[1];
            _description = parts[2];
            _point = Int32.Parse(parts[3]);
            _bonusPoints = Int32.Parse(parts[4]);
            _goalTimes = Int32.Parse(parts[5]);
            _completedTimes = Int32.Parse(parts[6]);
        }
    }
    public override int GetCompletedTimes()
    {
        return _completedTimes;
    }

}