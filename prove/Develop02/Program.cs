using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Entry entry = new Entry();
        char choice = '0';
        while (choice != '5')
        {
            menu.Display();
            choice = Console.ReadKey().KeyChar;
            switch (choice)
            {
                case '1':
                    Console.WriteLine();
                    string prompt = entry.RandomPrompt();
                    string response = Console.ReadLine();
                    entry.Write(response, prompt);
                    break;
                case '2':
                    Console.WriteLine();
                    Console.WriteLine("Displayyyyyyyy");
                    break;
                case '3':
                    Console.WriteLine();
                    Console.WriteLine("Loaddddddd");
                    break;
                case '4':
                    Console.WriteLine();
                    Console.WriteLine("Saveeeeeeee");
                    break;
            }
        }
    }
}