using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        List<string> verses = new List<string>();

        verses.Add("O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish.");
        verses.Add("But to be learned is good if they hearken unto the counsels of God.");

        Scripture scripture = new Scripture(verses);

        int count = verses.Count;
        Console.WriteLine(count);

        string input = "";
        while (input != "quit")
        {
            Console.WriteLine("");
            Console.Write("Please hit enter to start the scripture memorizer program or type 'quit' to exit: ");
            input = Console.ReadLine();
            while (input != "quit")
            {
                Console.WriteLine("");
                scripture.Display();
                Console.WriteLine("");
                Console.Write("Hit enter to hide words or type 'quit' to exit: ");
                input = Console.ReadLine();
                //scripture.WordsList(verses);
                // pass method as parameter
                List<string> wordsMethod = scripture.WordsList(verses);
                scripture.RandomWords(wordsMethod);
                
            }
        }    
    }
}