using System;
using System.Collections.Generic;

class Menu
{
    public void Display()
    {
        Console.WriteLine("------ Welcome to your Journal! ------");
        Console.WriteLine("1) Write");
        Console.WriteLine("2) Display");
        Console.WriteLine("3) Load");
        Console.WriteLine("4) Save");
        Console.WriteLine("5) Quit");
        Console.Write("What would you like to do?:");
    }
}