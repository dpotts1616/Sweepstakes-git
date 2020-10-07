using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant : INotifier
    {
        //member variables
        public string firstName;
        public string lastName;
        public string eMailAddress;
        public int registrationNumber;

        //constructor
        public Contestant()
        {
            firstName = UserInterface.GetUserInputFor("Contestant's First Name:");
            lastName = UserInterface.GetUserInputFor("Contestant's Last Name:");
            eMailAddress = UserInterface.GetUserInputFor("Contestant's Email Address:");
            registrationNumber = new Random().Next();
        }

        public Contestant(string firstName, string lastName, string eMailAddress, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eMailAddress = eMailAddress;
            this.registrationNumber = registrationNumber;
        }


        //methods

        public virtual void Notify(Contestant contestant)
        {
            UserInterface.Print($"Congratulations to our winner of the Sweepstakes, " +
                $"{contestant.firstName} {contestant.lastName}!!!");
        }

    }
}
