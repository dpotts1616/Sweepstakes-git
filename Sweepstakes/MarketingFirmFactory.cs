using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirmFactory : ICreateFirms
    {
        public MarketingFirm CreateAFirm(int choice)
        {
            if (choice == 1)
            {
                return new MarketingFirm(new SweepstakesStackManager());
            }
            if (choice == 2)
            {
                return new MarketingFirm(new SweepstakesQueueManger());
            }
            return null;
        }
    }

}
