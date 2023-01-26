using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public string _entryAnswer = "";

    public void StoreJournal()
    {
        Console.Write("Please enter the name of the file you would like to save your journal to: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_entryAnswer}");
        }
    }

    public void LoadJournal()
    {
        Console.Write("Please enter the name of the file you would like to read: ");
        string loadFile = Console.ReadLine();
        string contentFile = File.ReadAllText(loadFile);
        _entryAnswer += contentFile;
    }

    public void DisplayJournal()
    {
        Console.WriteLine($"{_entryAnswer}");
    }

}