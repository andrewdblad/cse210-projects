using System;

class Program
{
    static void Main(string[] args)
    {

Random randomGen = new Random();
int magicNum = randomGen.Next(1,100);

int guess = 0;

    while (guess != magicNum)
    {
        Console.WriteLine("What is your guess?: ");
        guess = int.Parse(Console.ReadLine());

        if (guess < magicNum)
        {
            Console.WriteLine("Higher!");
        }

        if (guess > magicNum)
        {
            Console.WriteLine("Lower!");
        }


    }

    Console.WriteLine("Correct!");

    }
}