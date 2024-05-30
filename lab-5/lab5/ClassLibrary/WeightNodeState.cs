using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WeightNodeState : INodeState
    {
        public string GetOuterHtml(LightNode node)
        {
            var weightNode = node as LightWeightNode;
            return $"<{weightNode.TagName}>{weightNode.Content}</{weightNode.TagName}>";
        }

        public string GetInnerHtml(LightNode node)
        {
            var weightNode = node as LightWeightNode;
            return weightNode.Content;
        }
    }
}
