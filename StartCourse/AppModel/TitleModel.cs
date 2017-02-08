using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModel
{
    public class TitleModel
    {
        public string Stars => "*************************************************";
        public string Title { get; set; }

        public TitleModel(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            var header = new StringBuilder();
            header.AppendLine(Stars);
            header.AppendLine("\t\t" + Title);
            header.AppendLine(Stars);

            return header.ToString();
        }
    }
}
