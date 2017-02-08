using AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class InstantDelegate
    {
        delegate string SuperHash(string input);

        public static string Hash3(string input)
        {
            char[] arrayInput = input.ToCharArray();

            for (int i = 0; i < arrayInput.Length; i++)
            {
                var oneChar = arrayInput[i] + 3;
                arrayInput[i] = Convert.ToChar(oneChar);
            }

            return new string(arrayInput);
        }

        public static string Unhash(string input)
        {
            char[] arrayInput = input.ToCharArray();

            for (int i = 0; i < arrayInput.Length; i++)
            {
                var oneChar = arrayInput[i] - 3;
                arrayInput[i] = Convert.ToChar(oneChar);
            }

            return new string(arrayInput);
        }

        static void Main(string[] args)
        {
            var titleModel = new TitleModel("Instantiating  delegati");
            var consoleModel = new ConsoleModel();
            consoleModel.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(titleModel.ToString());
            consoleModel.Title = "Delegate first part";

            SuperHash hash = new SuperHash(Hash3);
            SuperHash unhash = new SuperHash(Unhash);

            var textToHash = "LANACO";

            Console.WriteLine("Text before hashing: \t" + textToHash);
            textToHash = hash(textToHash);
            Console.WriteLine("1. Hash:\t" + textToHash);
            Console.WriteLine("2. Unhash:\t" + unhash(textToHash));

            Console.ReadKey(true);
        }
    }
}
