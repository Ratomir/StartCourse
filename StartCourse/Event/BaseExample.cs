using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class BaseExample
    {
        public delegate string MyDel(string str);

        event MyDel MyEvent;

        public BaseExample()
        {
            MyEvent += new MyDel(WelcomeUser);
        }

        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }

        static void Main(string[] args)
        {
            BaseExample obj1 = new BaseExample();
            string result = obj1.MyEvent(" new Lanaco course.");
            Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }
}
