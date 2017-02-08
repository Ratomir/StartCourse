using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event
{
    class EventCallEventArgs1
    {
        public class Counter
        {
            public event EventHandler<EventArgs> CountOver;

            public void Count(int temp, int final)
            {
                if ((temp == final) && (CountOver != null))
                {
                    CountOver(this, EventArgs.Empty);
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

        static void TreatmentOfEvent(object sender, EventArgs a)
        {
            Console.WriteLine("Over!!!");
        }
    }
}
