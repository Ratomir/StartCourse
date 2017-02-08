using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Func
    {
        static void Main()
        {
            //
            // Upotreba implicitnih lambda izraza.
            //
            Func<int, int> func1 = x => x + 1;

            //
            // Upotreba lambda izraza sa tijelom metode.
            //
            Func<int, int> func2 = x => { return x + 1; };

            //
            // Upotreba parametara bez tijela metode.
            //
            Func<int, int> func3 = (int x) => x + 1;

            //
            // Upotreba parametara u tijelu metode.
            //
            Func<int, int> func4 = (int x) => { return x + 1; };

            //
            // Upotreba višestrukih parametara.
            //
            Func<int, int, int> func5 = (x, y) => x * y;

            //
            // Nema povratnog tipa u lambda izrazu.
            //
            Action func6 = () => Console.WriteLine();

            //
            // Use delegate method expression.
            //
            Func<int, int> func7 = delegate (int x) { return x + 1; };

            //
            // Upotreba delegata bez parametara.
            //
            Func<int> func8 = delegate { return 1 + 1; };

            //
            // Pozivanje svakog lambda izraza.
            //
            Console.WriteLine(func1.Invoke(1));
            Console.WriteLine(func2.Invoke(1));
            Console.WriteLine(func3.Invoke(1));
            Console.WriteLine(func4.Invoke(1));
            Console.WriteLine(func5.Invoke(2, 2));
            func6.Invoke();
            Console.WriteLine(func7.Invoke(1));
            Console.WriteLine(func8.Invoke());

            Console.ReadKey(true);
        }
    }
}
