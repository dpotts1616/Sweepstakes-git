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
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
        }

        //methods
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            List<int> keys = new List<int>(contestants.Keys);
            int winner = Program.GetRandomNumber(0, keys.Count);
            return contestants[keys[winner]];
        }


        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.Print(contestant.firstName);
            UserInterface.Print(contestant.lastName);
            UserInterface.Print(contestant.eMailAddress);
            UserInterface.Print(contestant.registrationNumber);
        }

    }
}
