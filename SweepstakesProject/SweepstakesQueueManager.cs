using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        public Queue<Sweepstakes> QueueOfSweepstakes;

        public SweepstakesQueueManager()
        {
            Queue<Sweepstakes> StackOfSweepstakes = new Queue<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            return QueueOfSweepstakes.Dequeue();
        }


        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            QueueOfSweepstakes.Enqueue(sweepstakes);
        }
    }
}
