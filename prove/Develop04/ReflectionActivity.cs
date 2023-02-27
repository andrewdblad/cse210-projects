using System;
using System.Diagnostics;

class ReflectionActivity : Activity
{

    public ReflectionActivity(int duration) : base(
                                            "Reflecting Activity", 
                                            "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 
                                            "Welcome to the Reflection Activity.", 
                                            "", 
                                            duration)
    {
    }

    public void DoReflect()
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
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            DisplayRandPrompt();
            Console.WriteLine();
            Console.Write("When you have something in mind, press enter to continue.");
            input = Console.ReadKey();
        } while (input.Key != ConsoleKey.Enter);
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Now ponder each of the following questions as they related to this experience.");
        DisplayDelay(3);
        Console.Clear();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        ConsoleKeyInfo input2;

        while(stopwatch.Elapsed.TotalSeconds < _duration)
        {
            do
            {
                DisplayRandPrompt2();
                input2 = Console.ReadKey();
            } while (input2.Key != ConsoleKey.Enter);
        }
        stopwatch.Stop();
        Console.Clear();
        DisplayEnd();
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
    public void DisplayRandPrompt2()
    {
        Random random = new Random();
        List<string> prompt = new List<string>()
        {
            "> How did you feel when it was complete?",
            "> What was your favorite part of this experience?",
            "> What did you think during this experience?",
            "> Would you do this again?",
            "> What would you do differently next time?",
            "> What are some things you could improve on?"
        };
        int index = random.Next(prompt.Count());
        Console.WriteLine(prompt[index]);
    }


}