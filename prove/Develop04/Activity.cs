using System;

class Activity
{
    private string _name = "";
    private string _desc = "";
    private string _welcomeMessage = "";
    private string _enddingMessage = "";
    protected int _duration = 0;

    public Activity()
    {
       // nothing 
    }

    public Activity(string name, 
             string desc, 
             string welcome, 
             string endding, 
             int duration)
    {
        _name = name;
        _desc = desc; 
        _welcomeMessage = welcome; 
        _enddingMessage = endding; 
        _duration = duration;
    }

    public void DisplayStart()
    {
        System.Console.WriteLine(_welcomeMessage);
        Console.WriteLine();
        System.Console.WriteLine (_desc);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for you session?: ");
        _duration = Convert.ToInt32(Console.ReadLine());
            
    }
    public void DisplayEnd()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        DisplayDelay(5);
        Console.Clear();
    }
    public void DisplayDelay(int count)
    {
        for (int i = 0; i < count; i++)
        {
        Console.Write("\b\b");
        Console.Write("|");

        Thread.Sleep(250);
        Console.Write("\b\b");
        Console.Write("/");

        Thread.Sleep(250);
        Console.Write("\b\b");
        Console.Write("-");

        Thread.Sleep(250);
        Console.Write("\b\b");
        Console.Write("\\");
        }
    }


}