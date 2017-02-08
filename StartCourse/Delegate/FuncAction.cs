using AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class FuncAction
    {
        public class MethodCollections
        {
            //Methods that takes parameters but returns nothing:  

            #region << Action >> 

            public static void PrintText()
            {
                Console.WriteLine("*************************************************");
            }

            public static void Counter(int start, int target)
            {
                for (int i = start; i <= target; i++)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }

            public static void Print(string message)
            {
                Console.WriteLine(message);
            }

            #endregion

            //Methods that takes parameters and returns a value:  

            #region << Func >>

            public static int Add(int a, int b)
            {
                return a + b;
            }

            public static string Mul(int a, int b)
            {
                return "Multiple action: " + (a * b);
            }

            public static string ShowName(string firstName, string lastName)
            {
                return string.Format("Your Name is {0} {1}", firstName, lastName);
            }

            public static int ShowNumber()
            {
                Random r = new Random();
                return r.Next();
            }

            #endregion
        }

        static void Main(string[] args)
        {
            Action printStars = new Action(MethodCollections.PrintText);

            var titleModel = new TitleModel("Multicast delegati");
            var consoleModel = new ConsoleModel();
            consoleModel.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(titleModel.ToString());
            consoleModel.Title = "Delegate FUNC part";

            var method = new MethodCollections();

            Func<int> random = new Func<int>(MethodCollections.ShowNumber);

            Console.WriteLine(random() + "");

            int startIndex, endIndex;

            printStars();

            Console.WriteLine("Counter part.");
            consoleModel.ForegroundColor = ConsoleColor.Green;
            Console.Write("Start index > ");

            startIndex = Convert.ToInt32(Console.ReadLine());
            Console.Write("End index > ");

            endIndex = Convert.ToInt32(Console.ReadLine());

            consoleModel.ForegroundColor = ConsoleColor.Yellow;

            Action<int, int> printNumber = new Action<int, int>(MethodCollections.Counter);
            printNumber(startIndex, endIndex);

            printStars();

            Func<int, int, int> add = new Func<int, int, int>(MethodCollections.Add);
            Console.WriteLine("Additional two number equal = " + add(startIndex, endIndex));

            Func<int, int, string> mul = new Func<int, int, string>(MethodCollections.Mul);
            Console.WriteLine(mul(startIndex, endIndex));

            string firstName, lastName;

            printStars();
            Console.WriteLine("Introduction part.");
            consoleModel.ForegroundColor = ConsoleColor.Green;
            Console.Write("First name, please > ");
            firstName = Console.ReadLine();

            Console.Write("Last name, please > ");
            lastName = Console.ReadLine();

            consoleModel.ForegroundColor = ConsoleColor.Yellow;

            Func<string, string, string> introduction = new Func<string, string, string>(MethodCollections.ShowName);

            Console.WriteLine(introduction(firstName, lastName));
            printStars();

            Console.ReadKey(true);
        }
    }
}
