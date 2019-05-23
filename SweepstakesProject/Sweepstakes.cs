using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        //HAS
        public Dictionary<int, Contestant> dictionaryOfContestants = new Dictionary<int, Contestant>();
        string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Last name of contestant cannot be null.");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Size
        {
            get
            {
                return dictionaryOfContestants.Count();
            }
        }

        public int EntryNo
        {
            get
            {
                return (dictionaryOfContestants.Count + 1);
            }

        }

        //CONSTRUCTOR
        public Sweepstakes(string name)
        {
            Name = name;
        }

        //DOES
        public void RegisterContestant(Contestant contestant)
        {
            dictionaryOfContestants.Add(EntryNo, contestant);
        }
        public string PickWinner()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, Size + 1);
            Contestant winner = dictionaryOfContestants[randomNumber];
            string fullName = winner.FirstName + " " + winner.LastName;
            return fullName;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            string fullName = contestant.FirstName + " " + contestant.LastName;
            Console.WriteLine(fullName);
            Console.WriteLine(contestant.Email);
        }
    }
}