using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();

            simulation.RunSimulation();
           
        }


        public static int GetRandomNumber(int min, int max)
        {
            Random rand = new Random();
            int randomResult = rand.Next(min, max);
            return randomResult;
        }
    }
}
