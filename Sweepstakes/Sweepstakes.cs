using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //member variables
        Dictionary<int, Contestant> contestants;
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        //constructor
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        //methods
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

        //public Contestant PickWinner()
        

        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
