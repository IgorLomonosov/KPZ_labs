using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask05_06
{
    public class BookToHTMLConverter
    {
        public LightHTML ConvertToHTML(string bookText)
        {
            var lines = bookText.Split('\n');
            var root = new LightWeightNode("div", "");

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                LightNode node;

                if (line.Length < 20)
                {
                    node = new LightWeightNode("h2", line);
                }
                else if (line.StartsWith(" "))
                {
                    node = new LightWeightNode("blockquote", line.Trim());
                }
                else
                {
                    node = new LightWeightNode("p", line);
                }

                root.Content += node.OuterHtml;
            }

            return new LightHTML(root);
        }
    }
}
