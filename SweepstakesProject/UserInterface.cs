using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UserInterface
    {
        public static void Intro()
        {
            Console.WriteLine("Are you a contestant (1) or a marketing firm (2)?");
            string eitherContestantOrMarketingFirm = Console.ReadLine();
            switch(eitherContestantOrMarketingFirm)
            {
                case "1":
                    Contestant contestant = new Contestant();
                    break;
                case "2":
                    GenerateSweepstakesManager();
                    Console.WriteLine("Are you adding a sweepstake? Write \"yes\" to name the sweepstake. Write \"no\" to ");
                    string yesOrNoSweepstake = Console.ReadLine();
                    switch (yesOrNoSweepstake)
                    {
                        case "yes":
                            GenerateSweepstake();
                            break;
                        case "no":
                            GenerateSweepstakesManager();
                            break;
                    }
                    break;
            }

        }

        public static string GetSweepstakeName()
        {
            Console.WriteLine("What would you like to name this sweepstake?");
            string nameOfSweepstake = Console.ReadLine();
            return nameOfSweepstake;
        }

        public static void GenerateSweepstake()
        {
            Sweepstakes newSweepstake = new Sweepstakes(GetSweepstakeName());
        }

        //FACTORY PATTERN
        public static ISweepstakesManager GenerateSweepstakesManager()
        {
            Console.WriteLine("Would you like to use a stack or a queue?");
            string factoryAnswer = Console.ReadLine().ToLower();

            switch (factoryAnswer)
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    return GenerateSweepstakesManager();

            }

        }


    }
}
