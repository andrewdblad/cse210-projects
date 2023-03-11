using System;
using System.IO;

class Program
{

    //EXCEEDED REQUIREMENTS BY ADDING NOTIFICATIONS EVERYTIME AN ACTION IS COMPLETED
    static void Main(string[] args)
    {
        List<Goal> goalsList = new List<Goal>();
        int totalPoints = 0;
        char choice = '0';
        char goalChoice = '0';
        string inputChoice = "";
        int points = 0;
        string fileName = "";
        string rep = "";
        string notification = "";

        while (choice != '6')
        {
            Console.Clear();
            Console.WriteLine("-------- Goal Program --------");
            //change notification color to red
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(notification);
            Console.ResetColor();
            //
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
                        simple.GetInputSimpleGoal();
                        Console.Clear();
                        goalsList.Add(simple);
                        notification = "Created new Simple Goal!";
                    }
                    if(goalChoice == '2')
                    {
                        EternalGoal eternal = new EternalGoal();
                        eternal.GetInputEternalGoal();
                        Console.Clear();
                        goalsList.Add(eternal);
                        notification = "Created new Eternal Goal!";
                    }
                    if(goalChoice =='3')
                    {
                        ChecklistGoal checklist = new ChecklistGoal();      
                        checklist.GetInputChecklistGoal();
                        Console.Clear();             
                        goalsList.Add(checklist);
                        notification = "Created new Checklist Goal!";
                    }
                }

                if(choice == '2')
                {
                    Console.Clear();
                    notification = "";
                    Console.WriteLine("------- Goals -------");
                    foreach (Goal goal in goalsList)
                    {
                        goal.Display();
                    }
                    Console.WriteLine("Press Enter to continue: ");
                    Console.ReadKey();

                }
                
                if(choice == '3')
                {
                    Console.Clear();
                    Console.Write("Name the file you want to save to: ");
                    fileName = Console.ReadLine();
                    SaveFile(fileName);
                    goalsList.Clear();
                    totalPoints = 0;
                    notification = $"Goals saved to {fileName} - Load {fileName} to continue your progress!";
                }
                if(choice == '4')
                {
                    Console.Clear();
                    Console.Write("Name the file you want to load: ");
                    fileName = Console.ReadLine();
                    LoadFile(fileName);
                    notification = $"Loaded {fileName}!";
                }    
                if(choice == '5')
                {
                    Console.Clear();
                    foreach(Goal goal in goalsList)
                    {
                        goal.DisplayName();
                        Console.WriteLine();
                    }
                    Console.Write("Which goal did you complete? Enter name: ");
                    inputChoice = Console.ReadLine();
                    foreach(Goal goal in goalsList)
                    {
                        if (goal.GetName() == inputChoice.ToString())
                        {
                            goal.MarkAsComplete();
                            if(goal.CheckIfComplete() == true)
                            {
                                points = goal.GetPoints();
                                totalPoints = totalPoints + points;  
                            }
                            if(goalsList.Any(x => x is ChecklistGoal))
                            {
                                points = goal.GetChecklistPoint();
                                totalPoints = totalPoints + points;
                            }
                        }
                    }
                    notification = $"You completed {inputChoice}! {points} points have been added to your total!";
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
                foreach(Goal goal in goalsList)
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
                    goalsList.Add(simple);
                }
                if(stringRep.Contains("EternalGoal"))
                {
                    EternalGoal eternal = new EternalGoal();
                    eternal.HandleStringRep(stringRep);
                    goalsList.Add(eternal);
                }
                if(stringRep.Contains("ChecklistGoal"))
                {
                    ChecklistGoal checklist = new ChecklistGoal();
                    checklist.HandleStringRep(stringRep);
                    goalsList.Add(checklist);
                }
            }
            foreach(Goal goal in goalsList)
            {
                totalPoints = goal.GetPoints() + (goal.GetCompletedTimes() * goal.GetChecklistPoint());
            }
        }
    }
}