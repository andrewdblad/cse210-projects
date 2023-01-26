using System;
using System.Collections.Generic;
using System.IO;
class Entry
{

    public void Write(string response, string prompt)
    {
        string fileName = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // get current date
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            // print response into file
            outputFile.WriteLine(prompt);
            outputFile.WriteLine($"> {response}");
            
            
        }
    }
    public string RandomPrompt()
    {
        List<string> list = new List<string>();
        list.Add("What was your favorite part of the day?");
        list.Add("What was one funny thing that happend today?");
        list.Add("How did you see the lords hand today?");
        list.Add("Who was the first person you talked to today?");
        list.Add("What was a cool car you saw today?");
        // get random prompt from list
        var r = new Random();
        int count = list.Count;
        int indexVal = r.Next(count);
        // print random prompt
        var prompt = list[indexVal];
        Console.WriteLine(prompt);
        // print random prompt to file
        return prompt;
    }
}