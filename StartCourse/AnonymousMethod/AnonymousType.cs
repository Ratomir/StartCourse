using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousType
{
    class AnonymousType
    {
        static void Main(string[] args)
        {
            var tempList = new List<string>() { "First string", "Secound string", "Third string" };
            var newList = (from p in tempList select new { oneWay = p, reverse = new string(p.Reverse().ToArray()) }).ToList();

            Console.WriteLine(newList[0].oneWay);
            Console.WriteLine(newList[0].reverse);

            Console.ReadKey(true);
        }
    }
}
