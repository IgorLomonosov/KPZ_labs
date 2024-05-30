using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public string DisplayType { get; set; }
        public string ClosingType { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public override string OuterHtml
        {
            get
            {
                OnTextRendered();
                string classes = CssClasses != null ? string.Join(" ", CssClasses) : "";
                OnClassListApplied();
                string childrenHtml = Children != null ? string.Join("", Children.Select(child => child.OuterHtml)) : "";
                string closingTag = ClosingType == "single" ? "/>" : $">{childrenHtml}</{TagName}>";
                OnStylesApplied();

                return $"<{TagName} class=\"{classes}\"{closingTag}";
            }
        }

        public override string InnerHtml
        {
            get
            {
                return Children != null ? string.Join("", Children.Select(child => child.OuterHtml)) : "";
            }
        }

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses, List<LightNode> children)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            CssClasses = cssClasses;
            Children = children;
            OnCreated();
        }
    }
}
