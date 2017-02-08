using AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class BaseDelegate
    {
        delegate int Transformer(int x);

        static void Main(string[] args)
        {
            var titleModel = new TitleModel("Delegati first part");
            var consoleModel = new ConsoleModel();
            consoleModel.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(titleModel.ToString());
            consoleModel.Title = "Delegate first part";

            Transformer t = Squere;
            int result = t(3);
            Console.WriteLine(result);
            Console.ReadKey(true);
        }

        static int Squere(int x)
        {
            return x * x;
        }
    }
}
