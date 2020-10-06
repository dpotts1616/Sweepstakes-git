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
        MarketingFirmFactory factory = new MarketingFirmFactory();

        //constructor

        //methods
        public void RunSimulation()
        {
            int firmChoice = UserInterface.ChooseSweepstakeManagementType();
            MarketingFirm firm = factory.CreateAFirm(firmChoice);

        }

    }
}
