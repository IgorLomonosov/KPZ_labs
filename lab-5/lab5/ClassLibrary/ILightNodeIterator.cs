using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface ILightNodeIterator
    {
        bool HasNext();
        LightNode Next();
    }

    public interface IIterableLightNode
    {
        ILightNodeIterator CreateDepthFirstIterator();
        ILightNodeIterator CreateBreadthFirstIterator();
    }
}
