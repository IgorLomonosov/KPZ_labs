using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BreadthFirstIterator : ILightNodeIterator
    {
        private Queue<LightNode> _queue;

        public BreadthFirstIterator(LightNode root)
        {
            _queue = new Queue<LightNode>();
            _queue.Enqueue(root);
        }

        public bool HasNext()
        {
            return _queue.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext())
                throw new InvalidOperationException();

            LightNode node = _queue.Dequeue();

            if (node is LightElementNode elementNode)
            {
                foreach (var child in elementNode.Children)
                {
                    _queue.Enqueue(child);
                }
            }

            return node;
        }
    }
}

