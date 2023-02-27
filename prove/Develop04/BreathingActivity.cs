using System;
using System.Diagnostics;

class BreathingActivity : Activity
{

    public BreathingActivity(int duration) : base(
                                            "Breathing Activity", 
                                            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 
                                            "Welcome to the breathing Activity.", 
                                            "endding B", 
                                            duration)
    {

    }   
    public void DoBreathe()
    {
        Console.Clear();
        base.DisplayStart(); 
        Console.Clear(); 
        Console.WriteLine("Get ready...");
        base.DisplayDelay(4);
        Console.Clear();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while(stopwatch.Elapsed.TotalSeconds < _duration)
        {
        DisplayBreatheAnimation();
        }
        stopwatch.Stop();
        Console.Clear();
        DisplayEnd();     
    }
    public void DisplayBreatheAnimation()
    {
        // BREATHE IN
    Console.Clear();
    int time = 1000/10;
    string deleteDashes = "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b";
    string text = "Breath in";
    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
    string dashes = "-------------------------------------------------------------------------------------------------------------";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = " ----------------------------------------------------------------------------------------------------------- ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "  ---------------------------------------------------------------------------------------------------------  ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "   -------------------------------------------------------------------------------------------------------   ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "    -----------------------------------------------------------------------------------------------------    ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "      -------------------------------------------------------------------------------------------------      ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "        ---------------------------------------------------------------------------------------------        ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "          -----------------------------------------------------------------------------------------          ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "            -------------------------------------------------------------------------------------            ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "              ---------------------------------------------------------------------------------              ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                -----------------------------------------------------------------------------                ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                  -------------------------------------------------------------------------                  ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                    ---------------------------------------------------------------------                    ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                       ---------------------------------------------------------------                       ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);
//
    Console.Write(deleteDashes);
    dashes = "                          ---------------------------------------------------------                          ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                             ---------------------------------------------------                             ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);
    
    Console.Write(deleteDashes);
    dashes = "                               -----------------------------------------------                               ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);
//
    Console.Write(deleteDashes);
    dashes = "                                 -------------------------------------------                                 ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                    -------------------------------------                                    ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                       -------------------------------                                       ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);
//
    Console.Write(deleteDashes);
    dashes = "                                          -------------------------                                          ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                             -------------------                                             ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);
//
    Console.Write(deleteDashes);
    dashes = "                                                -------------                                                ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                                   -------                                                   ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                                     ---                                                     ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                                      -                                                      ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Console.Clear();
  
    // BREATHE OUT

    text = "Breath out";
    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
    dashes = "                                                      -                                                      ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                                     ---                                                     ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                                   -------                                                   ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                                -------------                                                ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                             -------------------                                             ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                          -------------------------                                          ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                       -------------------------------                                       ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                    -------------------------------------                                    ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                                 -------------------------------------------                                 ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                               -----------------------------------------------                               ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                             ---------------------------------------------------                             ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                          ---------------------------------------------------------                          ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                       ---------------------------------------------------------------                       ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                  -------------------------------------------------------------------------                  ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "                -----------------------------------------------------------------------------                ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "              ---------------------------------------------------------------------------------              ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "            -------------------------------------------------------------------------------------            ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "          -----------------------------------------------------------------------------------------          ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "        ---------------------------------------------------------------------------------------------        ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "      -------------------------------------------------------------------------------------------------      ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "    -----------------------------------------------------------------------------------------------------    ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "   -------------------------------------------------------------------------------------------------------   ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "  ---------------------------------------------------------------------------------------------------------  ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

   Console.Write(deleteDashes);
    dashes = " ----------------------------------------------------------------------------------------------------------- ";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);

    Console.Write(deleteDashes);
    dashes = "-------------------------------------------------------------------------------------------------------------";
    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (dashes.Length / 2)) + "}", dashes));
    Thread.Sleep(time);
    }     
}