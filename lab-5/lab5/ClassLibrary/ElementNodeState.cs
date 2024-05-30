using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ElementNodeState : INodeState
    {
        public string GetOuterHtml(LightNode node)
        {
            var elementNode = node as LightElementNode;
            string classes = elementNode.CssClasses != null ? string.Join(" ", elementNode.CssClasses) : "";
            string childrenHtml = elementNode.Children != null ? string.Join("", elementNode.Children.Select(child => child.OuterHtml)) : "";
            string closingTag = elementNode.ClosingType == "single" ? "/>" : $">{childrenHtml}</{elementNode.TagName}>";

            return $"<{elementNode.TagName} class=\"{classes}\"{closingTag}";
        }

        public string GetInnerHtml(LightNode node)
        {
            var elementNode = node as LightElementNode;
            return elementNode.Children != null ? string.Join("", elementNode.Children.Select(child => child.OuterHtml)) : "";
        }
    }
}
