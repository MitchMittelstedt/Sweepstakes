using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm 
    {
        //HAS
        ISweepstakesManager sweepstakesManager;

        //CONSTRUCTOR
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.sweepstakesManager = manager;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesManager.InsertSweepstakes(sweepstakes);
        }

        public void GetSweepstakes()
        {
            sweepstakesManager.GetSweepstakes();
        }



    }
}
