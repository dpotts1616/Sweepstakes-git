using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        //member variables

        //constructor

        //methods
        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static int ChooseSweepstakeManagementType()
        {
            int managementType = 0;
            Console.WriteLine("Welcome, how does your firm manage sweepstakes?");
            Console.WriteLine("1) Stack Management");
            Console.WriteLine("2) Queue Management");
            bool valid = false;
            while (valid == false)
            {
                try
                { 
                    managementType = Convert.ToInt32(Console.ReadLine());
                    return managementType;
                }
                catch { Console.WriteLine("Sorry, that choice is invalid. Please enter 1 or 2."); }
            }
            return managementType;
        }

        public static void Print(string input)
        {
            Console.WriteLine(input);
        }

        public static void Print(int input)
        {
            Console.WriteLine(input);
        }
    }
}
