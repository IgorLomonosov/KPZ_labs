using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DepthFirstIterator : ILightNodeIterator
    {
        private Stack<LightNode> _stack;

        public DepthFirstIterator(LightNode root)
        {
            _stack = new Stack<LightNode>();
            _stack.Push(root);
        }

        public bool HasNext()
        {
            return _stack.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext())
                throw new InvalidOperationException();

            LightNode node = _stack.Pop();

            if (node is LightElementNode elementNode)
            {
                for (int i = elementNode.Children.Count - 1; i >= 0; i--)
                {
                    _stack.Push(elementNode.Children[i]);
                }
            }

            return node;
        }
    }
}
