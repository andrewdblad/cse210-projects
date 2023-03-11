using System;
using System.IO;

class Program
{

    
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
        int totalPoints = 0;
        char choice = '0';
        char goalChoice = '0';
        string inputChoice = "";
        int points = 0;
        string fileName = "";
        string rep = "";

        while (choice != '6')
        {
            Console.WriteLine();
            Console.WriteLine($"YOU HAVE {totalPoints} POINTS.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadKey().KeyChar;

                if(choice == '1')
                {
                    Console.Clear();
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create?: ");
                    goalChoice = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if(goalChoice == '1')
                    {
                        SimpleGoal simple = new SimpleGoal();
                        simple.DoSimpleGoal();
                        Console.Clear();
                        _goals.Add(simple);
                    }
                    if(goalChoice == '2')
                    {
                        EternalGoal eternal = new EternalGoal();
                        eternal.DoEternalGoal();
                        Console.Clear();
                        _goals.Add(eternal);
                    }
                    if(goalChoice =='3')
                    {
                        ChecklistGoal checklist = new ChecklistGoal();      
                        checklist.DoChecklistGoal();
                        Console.Clear();             
                        _goals.Add(checklist);
                    }
                }

                if(choice == '2')
                {
                    Console.WriteLine();
                    foreach (Goal goal in _goals)
                    {
                        goal.Display();
                    }
                }
                
                if(choice == '3')
                {
                    Console.Clear();
                    Console.Write("Name the file you want to save to: ");
                    fileName = Console.ReadLine();
                    SaveFile(fileName);
                    _goals.Clear();
                }
                if(choice == '4')
                {
                    Console.Clear();
                    Console.Write("Name the file you want to load: ");
                    fileName = Console.ReadLine();
                    LoadFile(fileName);
                }    
                if(choice == '5')
                {
                    Console.Clear();
                    foreach(Goal goal in _goals)
                    {
                        goal.DisplayName();
                        Console.WriteLine();
                    }
                    Console.Write("Which goal did you complete? Enter name: ");
                    inputChoice = Console.ReadLine();
                    foreach(Goal goal in _goals)
                    {
                        if (goal.GetName() == inputChoice.ToString())
                        {
                            goal.MarkAsComplete();
                            if(goal.CheckIfComplete() == true)
                            {
                                points = goal.GetPoints();
                                totalPoints = totalPoints + points;  
                            }
                            if(_goals.Any(x => x is ChecklistGoal))
                            {
                                points = goal.GetChecklistPoint();
                                totalPoints = totalPoints + points;
                            }
                        }
                    }
                }
                if(choice == '6')
                {
                    break;
                }            
        }
        void SaveFile(string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(totalPoints);
                foreach(Goal goal in _goals)
                {
                    rep = goal.GetStringRepresentation();
                    outputFile.WriteLine(rep);
                }
            }
        }
        void LoadFile(string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach(string stringRep in lines)
            {
                if(stringRep.Contains("SimpleGoal"))
                {
                    SimpleGoal simple = new SimpleGoal();
                    simple.HandleStringRep(stringRep);
                    _goals.Add(simple);
                }
                if(stringRep.Contains("EternalGoal"))
                {
                    EternalGoal eternal = new EternalGoal();
                    eternal.HandleStringRep(stringRep);
                    _goals.Add(eternal);
                }
                if(stringRep.Contains("ChecklistGoal"))
                {
                    ChecklistGoal checklist = new ChecklistGoal();
                    checklist.HandleStringRep(stringRep);
                    _goals.Add(checklist);
                }
            }
            foreach(Goal goal in _goals)
            {
                totalPoints = goal.GetPoints() + (goal.GetCompletedTimes() * goal.GetChecklistPoint());
            }
        }
    }
}