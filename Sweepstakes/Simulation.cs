using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        //member variables
        MarketingFirm stackFirm = new MarketingFirm(new SweepstakesStackManager());
        MarketingFirm queueFirm = new MarketingFirm(new SweepstakesQueueManger());

        //constructor

        //methods
        public void RunSimulation()
        {


        }

    }
}
