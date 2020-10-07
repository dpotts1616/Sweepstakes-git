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
            //Sweepstakes sweepstakes1 = firm.CreateSweepstakes();
            firm.CreateSweepstakes();
            Sweepstakes sweepstakes1 = firm.GetSweepstakes();
            sweepstakes1.RegisterContestant(new Contestant());
            Contestant winner = sweepstakes1.PickWinner();
            Console.ReadLine();
            sweepstakes1.PrintContestantInfo(winner);
            Console.ReadLine();
            sweepstakes1.AnnounceWinner(winner);
            Console.ReadLine();

        }




        
    }
}
