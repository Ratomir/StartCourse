﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event
{
    class EventCall
    {
        public delegate int dgPointer(int a, int b);

        public class Counter
        {
            public delegate void OperationHandler();
            public event OperationHandler CountOver;

            public void Count(int temp, int final)
            {
                if ((temp == final) && (CountOver != null))
                {
                    CountOver();
                }
            }
        }


        static void Main(string[] args)
        {
            Counter personalCounter = new Counter();
            personalCounter.CountOver += new Counter.OperationHandler(TreatmentOfEvent);
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

        static void TreatmentOfEvent()
        {
            Console.WriteLine("Over!!!");
        }


    }
}
