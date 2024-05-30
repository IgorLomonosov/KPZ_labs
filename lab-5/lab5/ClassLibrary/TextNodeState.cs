using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TextNodeState : INodeState
    {
        public string GetOuterHtml(LightNode node)
        {
            var textNode = node as LightTextNode;
            return textNode.Text;
        }

        public string GetInnerHtml(LightNode node)
        {
            var textNode = node as LightTextNode;
            return textNode.Text;
        }
    }
}
