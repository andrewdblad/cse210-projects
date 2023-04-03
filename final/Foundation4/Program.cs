using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActiity = new RunningActivity("April 1st 2023", 30, 3.2);
        BicycleActivity bicycleActivity = new BicycleActivity("April 3rd 2023", 25, 6.5, 15.3);
        SwimmingActivity swimmingActivity = new SwimmingActivity("April 3rd 2023", 20, 50);

        Console.WriteLine(runningActiity.GetSummary());
        Console.WriteLine(bicycleActivity.GetSummary());
        Console.WriteLine(swimmingActivity.GetSummary());
    }
}