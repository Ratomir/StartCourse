using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event
{
    class EventCallEventArgs2
    {
        public class Counter
        {
            public event EventHandler<CountingOver> CountOver;

            public void Count(int temp, int final)
            {
                if ((temp == final) && (CountOver != null))
                {
                    CountOver(this, new CountingOver(final));
                }
            }
        }


        static void Main(string[] args)
        {
            Counter personalCounter = new Counter();
            personalCounter.CountOver += TreatmentOfEvent;
            int countTo = 10;

            var i = 0;

            while (i != countTo)
            {
                personalCounter.Count(++i, countTo);
                Console.WriteLine("> " + i);
                Thread.Sleep(900);
            }

            Console.ReadKey();
        }

        static void TreatmentOfEvent(object sender, CountingOver a)
        {
            Console.WriteLine("Over!!!");
        }

        public class CountingOver : EventArgs
        {
            public int Total { get; set; }

            public CountingOver(int iTotal)
            {
                Total = iTotal;
            }
        }
    }
}
