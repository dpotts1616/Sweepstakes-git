﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string eMailAddress;
        public int registrationNumber;
        int count = 0;

        //constructor
        public Contestant()
        {
            firstName = UserInterface.GetUserInputFor("Contestant's First Name:");
            lastName = UserInterface.GetUserInputFor("Contestant's Last Name:");
            eMailAddress = UserInterface.GetUserInputFor("Contestant's Email Address:");
            registrationNumber = count;
            count++;
        }

        //methods
    }
}
