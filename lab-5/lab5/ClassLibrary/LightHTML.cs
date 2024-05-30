using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LightHTML
    {
        public LightNode Root { get; set; }

        public LightHTML(LightNode root)
        {
            Root = root;
        }

        public string GetHtml()
        {
            return Root.OuterHtml;
        }

        public IEnumerable<LightNode> GetNodesDepthFirst()
        {
            var iterator = ((IIterableLightNode)Root).CreateDepthFirstIterator();
            while (iterator.HasNext())
            {
                yield return iterator.Next();
            }
        }

        public IEnumerable<LightNode> GetNodesBreadthFirst()
        {
            var iterator = ((IIterableLightNode)Root).CreateBreadthFirstIterator();
            while (iterator.HasNext())
            {
                yield return iterator.Next();
            }
        }
    }
}

