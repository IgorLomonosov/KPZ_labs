using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface INodeState
    {
        string GetOuterHtml(LightNode node);
        string GetInnerHtml(LightNode node);
    }

}
