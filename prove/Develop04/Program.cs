using System;

// EXCEEDED REQUIREMENTS BY ADDING A BREATHING ANIMATION INSTEAD OF JUST A COUNTDOWN
class Program
{
   static void Main(string[] args)
    {
        int duration = 0;
        char choice = '0';
        while (choice != '4')
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadKey().KeyChar;
            switch (choice)
            {
                case '1':
                BreathingActivity breatheAct = new BreathingActivity(duration);
                Console.WriteLine("");
                breatheAct.DoBreathe();
                    break;

                case '2':
                ReflectionActivity reflectAct = new ReflectionActivity(duration);
                Console.WriteLine("");
                reflectAct.DoReflect();
                    break;
                case '3':
                ListingActivity listact = new ListingActivity(duration);
                Console.WriteLine("");
                listact.DoListing();

                    break;
            }
        }
    }
}