using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Entry entry = new Entry();
        Journal journal = new Journal();
        char choice = '0';
        while (choice != '5')
        {
            menu.Display();
            choice = Console.ReadKey().KeyChar;
            switch (choice)
            {
                case '1':
                    Console.WriteLine();
                    // get random prompt and send prompt to 
                    journal._entryAnswer += entry.RandomPrompt(journal._entryAnswer);
                    break;
                case '2':
                    journal.DisplayJournal();
                    break;
                case '3':
                    Console.WriteLine();
                    journal.LoadJournal();
                    break;
                case '4':
                    Console.WriteLine();
                    journal.StoreJournal();
                    break;
            }
        }
    }
}