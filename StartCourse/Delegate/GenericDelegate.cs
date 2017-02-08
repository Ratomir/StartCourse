using AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class GenericDelegate
    {
        delegate T Transformer<T>(T x);

        static void Main(string[] args)
        {
            var titleModel = new TitleModel("Delegati generic part");
            var consoleModel = new ConsoleModel();
            consoleModel.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(titleModel.ToString());
            consoleModel.Title = "Delegate generic part";

            Transformer<double> t = Square;
            double result = t(3.3);
            Console.WriteLine(result);

            Transformer<int> d = Square;
            int intSquare = d(3);
            Console.WriteLine(intSquare);

            Console.ReadKey(true);
        }

        static double Square(double x) => x * x;

        static int Square(int x) => x * x;
    }
}
