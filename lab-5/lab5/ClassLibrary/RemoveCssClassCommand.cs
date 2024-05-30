using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RemoveCssClassCommand : ICommand
    {
        private readonly LightElementNode _elementNode;
        private readonly string _cssClass;

        public RemoveCssClassCommand(LightElementNode elementNode, string cssClass)
        {
            _elementNode = elementNode;
            _cssClass = cssClass;
        }

        public void Execute()
        {
            if (_elementNode.CssClasses.Contains(_cssClass))
            {
                _elementNode.CssClasses.Remove(_cssClass);
            }
        }

        public void Undo()
        {
            if (!_elementNode.CssClasses.Contains(_cssClass))
            {
                _elementNode.CssClasses.Add(_cssClass);
            }
        }
    }
}

