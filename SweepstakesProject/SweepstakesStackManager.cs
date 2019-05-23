using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> StackOfSweepstakes;
        // member variable for stack of sweepstakes
        
        public SweepstakesStackManager()
        {
            Stack<Sweepstakes> StackOfSweepstakes = new Stack<Sweepstakes>();
        }

        public Sweepstakes GetSweepstakes()
        {
            return StackOfSweepstakes.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            StackOfSweepstakes.Push(sweepstakes);
        }
    }
}
