﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LightTextNode : LightNode
    {
        public string Text { get; set; }

        public override string OuterHtml
        {
            get { return Text; }
        }

        public override string InnerHtml
        {
            get { return Text; }
        }

        public LightTextNode(string text)
        {
            Text = text;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
