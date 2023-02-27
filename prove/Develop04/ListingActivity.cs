using System;
using System.Diagnostics;

class ListingActivity : Activity
{
    public ListingActivity(int duration) : base(
                                            "Listing Activity", 
                                            "This activity will help you refelct on the good things in your life by having you list as many things as you can in a certain area.", 
                                            "Welcome to the Listing Activity.", 
                                            "", 
                                            duration)
    {
    }
    
    public void DoListing()
    {
        Console.Clear();
        base.DisplayStart();
        Console.Clear();
        Console.WriteLine("Get ready...");
        base.DisplayDelay(4);
        Console.Clear();
        ConsoleKeyInfo input;
        do
        {
            Console.WriteLine();
            Console.WriteLine("List as many responses as you can to the following prompt.");
            Console.WriteLine();
            DisplayRandPrompt();
            Console.WriteLine();
            Console.Write("press enter to continue.");
            input = Console.ReadKey();
        } while (input.Key != ConsoleKey.Enter);
        Console.Clear();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while(stopwatch.Elapsed.TotalSeconds < _duration)
        {
        Console.Write("> ");
        Console.ReadLine();
        }
        stopwatch.Stop();
        Console.Clear();
        base.DisplayEnd();
    }

    public void DisplayRandPrompt()
    {
        Random random = new Random();
        List<string> prompt = new List<string>()
        {
            " --- Think of a time when you did something really difficult --- ",
            " --- What was your favorite part of the day? --- ",
            " --- Who was someone that made an impact on you today? --- ",
            " --- Did you do anything kind for someone today? How so? --- ",
            " --- What did you eat today? --- ",
            " --- Do you feel good about what you accomplished today? --- ",
            " --- What are you proud of that you did this week. --- "
        };
        int index = random.Next(prompt.Count());
        Console.WriteLine(prompt[index]);
    }

}