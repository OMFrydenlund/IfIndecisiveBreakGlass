using System;
using System.Collections.Generic;

namespace IfIndecisiveBreakGlass
{
    /*
     * Add timer
     * Accept/Decline randomized choice action dependent on timer
     */
    internal class Program
    {
        static void Main()
        {
            BreakGlass();
        }

        private static void BreakGlass()
        {
            FairWarning();
            RandomPickAndShow();
        }

        private static void FairWarning()
        {
            Console.WriteLine("Well, let's see what the button brings today. Pick a random choice by pressing a button.");
            Console.ReadLine();
        }

        private static void RandomPickAndShow()
        {
            List<string> choiceList = new List<string>
            {
                "hopping on Codecademy",
                "working a bit in Moodle",
                "exploring Hackerrank again",
                "going back to a personal project",
            };

            Random RandomizedChoice = new Random();

            int choiceListNumber = RandomizedChoice.Next(1, choiceList.Count + 1);

            Console.WriteLine($"Seems like you're {choiceList[choiceListNumber - 1]} now. Best of luck scrub!");
            Console.ReadLine();
        }
    }
}
