using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Winner : Contestant, INotifier
    {
        //member variables

        //constructor
        public Winner(string firstName, string lastName, string eMailAddress, int registrationNumber)
            :base(firstName,lastName,eMailAddress,registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eMailAddress = eMailAddress;
            this.registrationNumber = registrationNumber;
        }


        //methods

        public override void Notify(Contestant contestant)
        {
            string subject = "Congratulations!!";
            string body = $"Congratulations{firstName}, you have won our sweepstakes!! Call 867 - 5309 to claim your prize.";
            SendMail.SendEmail(eMailAddress, subject, body);
        }
    }
}
