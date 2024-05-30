using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LightWeightNode : LightNode
    {
        public string TagName { get; set; }
        public string Content { get; set; }

        public override string OuterHtml
        {
            get { return state.GetOuterHtml(this); }
        }

        public override string InnerHtml
        {
            get { return state.GetInnerHtml(this); }
        }

        public LightWeightNode(string tagName, string content)
        {
            TagName = tagName;
            Content = content;
            state = new WeightNodeState();
        }
    }
}
