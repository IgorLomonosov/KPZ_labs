using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IVisitor
    {
        void Visit(LightElementNode elementNode);
        void Visit(LightTextNode textNode);
        void Visit(LightWeightNode weightNode);
    }
}
