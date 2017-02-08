using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModel
{
    public class ConsoleModel
    {
        public string Title
        {
            get { return Console.Title; }
            set
            {
                Console.Title = value;
            }
        }

        public ConsoleColor ForegroundColor
        {
            get { return Console.ForegroundColor; }
            set { Console.ForegroundColor = value; }
        }

        public ConsoleModel()
        {
        }
    }
}
