using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    class AnonymousMethod
    {
        delegate void QueueMessage(string message);

        static void Main(string[] args)
        {
            QueueMessage agent = delegate (string msg) //Associating the delegate with an anonymous method.
            {
                Console.WriteLine(msg);
            };

            agent("Take the project and solution for build.");
            agent("Process of building.");

            agent = new QueueMessage(OldProcess); //Associating the delegate with a named method.

            agent("Publish the new version of solution.");
            
            Console.ReadKey(true);
        }

        static void OldProcess(string message)
        {
            Console.WriteLine(message);
        }
    }
}
