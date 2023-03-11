using System;

class EternalGoal : Goal
{
    private string _objectName = "EternalGoal";
    private bool _isComplete = false;
    public EternalGoal() : base() {}
    public override int GetPoints()
    {
        return _point;
    }
    public void GetInputEternalGoal()
    {
        DisplayGetName();
        DisplayGetDescription();
        DisplayGetPoints();
    }
    public override void Display()
    {
        Console.WriteLine($"> [ ] {_name} ({_description})");
    }
    public override void DisplayName()
    {
        Console.Write($"> {_name}");
    }
    public override void MarkAsComplete()
    {
        _isComplete = true;
    }
    public override bool CheckIfComplete()
    {
        if(_isComplete == true)
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
                                  + _point.ToString();
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
        }


    }
}