using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {

                // Prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");

                string entry = Console.ReadLine();

                if (entry == "quit"){
                    keepGoing = false;
                }
                else
                {
                 int minutes = int.Parse(entry);
            

                // add minutes exercised to total
                runningTotal = runningTotal + minutes;

                // display total minutes exercised to the screen
                Console.WriteLine("You've exercised " + runningTotal + " minutes");
                
                }//Repeat until the user quits

            }
            Console.WriteLine("Adios, Suckafish!");
        }
    }
}