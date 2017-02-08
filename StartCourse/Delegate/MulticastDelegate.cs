using AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class MuticastDelegate
    {
        delegate string SuperHash();

        public static string textToHash = "LANACO";

        public static string Reverse()
        {
            char[] arrayInput = textToHash.ToCharArray();

            Array.Reverse(arrayInput);

            textToHash = new string(arrayInput);
            return textToHash;
        }

        public static string Hash3()
        {
            char[] arrayInput = textToHash.ToCharArray();

            for (int i = 0; i < arrayInput.Length; i++)
            {
                var oneChar = arrayInput[i] + 3;
                arrayInput[i] = Convert.ToChar(oneChar);
            }

            return new string(arrayInput);
        }

        static void Main(string[] args)
        {
            var titleModel = new TitleModel("Multicast delegati");
            var consoleModel = new ConsoleModel();
            consoleModel.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(titleModel.ToString());
            consoleModel.Title = "Delegate first part";

            Console.WriteLine("Text before hashing: \t" + textToHash);

            SuperHash reverse = new SuperHash(Reverse);
            SuperHash hash = new SuperHash(Hash3);

            SuperHash superHash = reverse;
            superHash += hash;
            
            Console.WriteLine("Hash text:\t" + superHash());

            Console.ReadKey(true);
        }
    }
}
