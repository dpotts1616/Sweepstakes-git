using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManger :ISweepstakesManager
    {
        //member variables
        Queue<Sweepstakes> queue;

        //constructor
        public SweepstakesQueueManger()
        {
            queue = new Queue<Sweepstakes>();
        }

        //methods

        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
    }
}
