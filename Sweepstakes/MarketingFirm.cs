using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //member variables
        ISweepstakesManager _manager;

        //constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        //methods
        public void CreateSweepstakes()
        {
            _manager.InsertSweepstakes(new Sweepstakes(UserInterface.GetUserInputFor("What is the name of your Sweepstakes?")));
        }
    }
}
