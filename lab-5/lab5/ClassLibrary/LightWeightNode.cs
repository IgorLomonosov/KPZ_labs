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
            get
            {
                OnTextRendered();
                return $"<{TagName}>{Content}</{TagName}>";
            }
        }

        public override string InnerHtml
        {
            get { return state.GetInnerHtml(this); }
        }

        public LightWeightNode(string tagName, string content)
        {
            TagName = tagName;
            Content = content;
            OnCreated();
            state = new WeightNodeState();
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
