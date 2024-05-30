using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NodeCounterVisitor : IVisitor
    {
        public int ElementNodeCount { get; private set; } = 0;
        public int TextNodeCount { get; private set; } = 0;
        public int WeightNodeCount { get; private set; } = 0;

        public void Visit(LightElementNode elementNode)
        {
            ElementNodeCount++;
            if (elementNode.Children != null)
            {
                foreach (var child in elementNode.Children)
                {
                    child.Accept(this);
                }
            }
        }

        public void Visit(LightTextNode textNode)
        {
            TextNodeCount++;
        }

        public void Visit(LightWeightNode weightNode)
        {
            WeightNodeCount++;
        }
    }
}

